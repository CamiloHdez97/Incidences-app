using Domain;
using Domain.Interfaces;
using Persistence;
using Microsoft.EntityFrameworkCore;


namespace Aplication.Repository;
public class UserRepository : GenericRepository<User>, IUserRepository
{
    private readonly ApiIncidencesContext _context;
    public UserRepository(ApiIncidencesContext context) : base(context)
    {
        _context = context;
    }
    public async Task<User> GetByUserNameAsync (string userName)
    {
        return await _context.Users.Include(u => u.Rols).FirstOrDefaultAsync (u => u.NameUser.ToLower()==userName.ToLower());
    }
}