using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class AreaRepository : GenericRepository<Area>, IAreaRepository{
    public AreaRepository(ApiIncidencesContext contex) : base(contex){}
}