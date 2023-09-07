using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class PlaceRepository : GenericRepository<Place>, IPlaceRepository{

    public PlaceRepository(ApiIncidencesContext contex) : base(contex){}

}