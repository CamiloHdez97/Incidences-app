using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class RegionRepository : GenericRepository<Region>, IRegionRepository{

    public RegionRepository(ApiIncidencesContext contex) : base(contex){
        
    }

}