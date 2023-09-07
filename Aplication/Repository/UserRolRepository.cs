using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class UserRolRepository : GenericRepository<UserRol>, IUserRolRepository{
    public UserRolRepository(ApiIncidencesContext contex) : base(contex){
        
    }
}