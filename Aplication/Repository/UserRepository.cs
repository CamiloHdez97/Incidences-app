using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;


namespace Aplicacion.Repository;
public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly ApiIncidencesContext _context;
    public UserRepository(ApiIncidencesContext context) : base(context)
    {
        _context = context;
    }
    public async Task<User> GetByUserNameAsync (string userName)
    {
        return await _context.Users.Include(u => u.Rols).FirstOrDefaultAsync (u => u.Name_User.ToLower()==userName.ToLower());
    }
}