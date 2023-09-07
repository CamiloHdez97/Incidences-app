using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using ApiIncidences.Dtos;
using ApiIncidences.Services;
using ApiIncidences.Helpers;
using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;


namespace API.Services;
public class UserService : IUserService
{
    private readonly JWT _jwt;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IPasswordHasher<User> _passwordHasher;

    public UserService(IUnitOfWork unitOfWork, IOptions<JWT> jwt, IPasswordHasher<User> passwordHasher)
    {
        _jwt = jwt.Value;
        _unitOfWork = unitOfWork;
        _passwordHasher = passwordHasher;
    }

    public async Task<string> RegistrerAsync(RegisterDto registerDto)
    {
        var usuario = new User
        {
            Email = registerDto.Email,
            NameUser = registerDto.UserName,

        };

        usuario.Password = _passwordHasher.HashPassword(usuario, registerDto.Password);

        var usuarioExiste = _unitOfWork.Users
                                            .Find(u => u.NameUser.ToLower() == registerDto.UserName.ToLower())
                                            .FirstOrDefault();

        if (usuarioExiste == null)
        {
            /* var rolPredeterminado = _unitOfWork.Rols
                                                 .Find(u => u.Name_Rol == Autorizacion.Rol_PorDefecto.ToString())
                                                 .First();*/
            try
            {
                //usuario.Rols.Add(rolPredeterminado);
                _unitOfWork.Users.Add(usuario);
                await _unitOfWork.SaveAsync();

                return $"El Usuario {registerDto.UserName} Registro Exitoso";
            }

            catch (Exception ex)
            {
                var message = ex.Message;
                return $"Error: {message}";
            }
        }
        else
        {

            return $"El usuario con {registerDto.UserName} ya se encuentra resgistrado.";
        }

    }

    public async Task<string> AddRoleAsync(AddRoleDto model)
    {
        var usuario = await _unitOfWork.Users
                                                .GetByUserNameAsync(model.UserName);

        if (usuario == null)
        {
            return $"No existe algun usuario registrado con la cuenta olvido algun caracter?{model.UserName}.";
        }

        var rslt = _passwordHasher.VerifyHashedPassword(usuario, usuario.Password, model.Password);

        if (rslt == PasswordVerificationResult.Success)
        {
            var rolExiste = _unitOfWork.Rols
                                            .Find(u => u.NameRol.ToLower() == model.Role.ToLower())
                                            .FirstOrDefault();

            if (rolExiste != null)
            {
                var usuarioTieneRol = usuario.Rols
                                                .Any(u => u.Id == rolExiste.Id);

                if (usuarioTieneRol == false)
                {
                    usuario.Rols.Add(rolExiste);
                    _unitOfWork.Users.Update(usuario);
                    await _unitOfWork.SaveAsync();
                }

                return $"Rol {model.Role} agregado a la cuenta {model.UserName} de forma exitosa.";
            }

            return $"Rol {model.Role} no encontrado.";
        }

        return $"Credenciales incorrectas para el ususario {usuario.NameUser}.";
    }




    public async Task<DatosUsuarioDto> GetTokenAsync(LoginDto model)
    {
        DatosUsuarioDto dataUserDto = new DatosUsuarioDto();
        var usuario = await _unitOfWork.Users
                                                    .GetByUserNameAsync(model.UserName);

        if (usuario == null)
        {
            dataUserDto.EstaAutenticado = false;
            dataUserDto.Mensaje = $"No existe ningun usuario con el username {model.UserName}.";
            return dataUserDto;
        }

        var result = _passwordHasher.VerifyHashedPassword(usuario, usuario.Password, model.Password);
        if (result == PasswordVerificationResult.Success)
        {
            dataUserDto.Mensaje = "OK";
            dataUserDto.EstaAutenticado = true;
            if (usuario != null && usuario != null)
            {
                JwtSecurityToken jwtSecurityToken = CreateJwtToken(usuario);
                dataUserDto.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
                dataUserDto.UserName = usuario.NameUser;
                dataUserDto.Email = usuario.Email;
                dataUserDto.Rols = usuario.Rols
                                                    .Select(p => p.NameRol)
                                                    .ToList();


                return dataUserDto;
            }
            else
            {
                dataUserDto.EstaAutenticado = false;
                dataUserDto.Mensaje = $"Credenciales incorrectas {usuario.NameUser}.";

                return dataUserDto;
            }
        }

        dataUserDto.EstaAutenticado = false;
        dataUserDto.Mensaje = $"Credenciales incorrectas {usuario.NameUser}.";

        return dataUserDto;

    }

  private JwtSecurityToken CreateJwtToken(User usuario)
{
    if (usuario == null)
    {
        throw new ArgumentNullException(nameof(usuario), "El usuario no puede ser nulo.");
    }

    var roles = usuario.Rols;
    var roleClaims = new List<Claim>();
    foreach (var role in roles)
    {
        roleClaims.Add(new Claim("roles", role.NameRol));
    }
    
    var claims = new[]
    {
        new Claim(JwtRegisteredClaimNames.Sub, usuario.NameUser),
        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        new Claim("uid", usuario.Id.ToString())
    }
    .Union(roleClaims);

    if (string.IsNullOrEmpty(_jwt.Key) || string.IsNullOrEmpty(_jwt.Issuer) || string.IsNullOrEmpty(_jwt.Audience))
    {
        throw new ArgumentNullException("La configuración del JWT es nula o vacía.");
    }

    var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_jwt.Key));

    var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256Signature);
    
    var JwtSecurityToken = new JwtSecurityToken(
        issuer: _jwt.Issuer,
        audience: _jwt.Audience,
        claims: claims,
        expires: DateTime.UtcNow.AddMinutes(_jwt.DurationInMinutes),
        signingCredentials: signingCredentials);

    return JwtSecurityToken;
    }
}