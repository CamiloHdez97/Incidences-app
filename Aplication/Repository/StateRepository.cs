using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;
public class StateRepository : GenericRepository<State>, IStateRepository
{
    public StateRepository(ApiIncidencesContext context) : base(context)
    {
        
    }
}