using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class CityRepository : GenericRepository<City>, ICityRepository{
    public CityRepository(ApiIncidencesContext contex) : base(contex){}
}