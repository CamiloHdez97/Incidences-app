using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class IncidenceRepository : GenericRepository<Incidence>, IIncidenceRepository{
    public IncidenceRepository(ApiIncidencesContext contex) : base(contex){}
}