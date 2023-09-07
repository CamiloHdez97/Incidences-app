using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class TypeDocumentRepository : GenericRepository<TypeDocument>, ITypeDocumentRepository{

    public TypeDocumentRepository(ApiIncidencesContext contex) : base(contex){
        
    }

}