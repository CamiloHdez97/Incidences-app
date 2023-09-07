using Domain;

namespace Aplication.Contratos;

public interface IJwtGenerator
{
    string CrearToken(User user);
}