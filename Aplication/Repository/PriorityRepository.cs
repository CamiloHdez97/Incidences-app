using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class PriorityRepository : GenericRepository<Priority>, IPriorityRepository{

    public PriorityRepository(ApiIncidencesContext contex) : base(contex){}

}