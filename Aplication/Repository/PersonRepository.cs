using Aplication.Repository;
using Domain;
using Domain.Interfaces;
using Persistence;

namespace APlication.Repository;

public class PersonRepository : GenericRepository<Person>, IPersonRepository{

    public PersonRepository(ApiIncidencesContext contex) : base(contex){
        
    }

}
