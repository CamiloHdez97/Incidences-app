using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class CategoryIncidenceRepository : GenericRepository<CategoryIncidence>, ICategoryIncidenceRepository{
    public CategoryIncidenceRepository(ApiIncidencesContext contex) : base(contex){}
}