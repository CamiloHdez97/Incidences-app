using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class CategoryContactRepository : GenericRepository<CategoryContact>, ICategoryContactRepository{
    public CategoryContactRepository(ApiIncidencesContext contex) : base(contex){}
}