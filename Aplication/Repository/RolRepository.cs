using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;
public class RolRepository : GenericRepository<Rol>, IRolRepository
{
    public RolRepository(ApiIncidencesContext context) : base(context)
    {
        
    }
}