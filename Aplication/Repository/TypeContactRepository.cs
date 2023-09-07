using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class TypeContactRepository : GenericRepository<TypeContact>, ITypeContactRepository{

    public TypeContactRepository(ApiIncidencesContext contex) : base(contex){
        
    }

}