using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class TypePersonRepository : GenericRepository<TypePerson>, ITyperPersonRepository{
    public TypePersonRepository(ApiIncidencesContext contex) : base(contex){
        
    }
}