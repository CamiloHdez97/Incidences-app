using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class GenderRepository : GenericRepository<Gender>, IGenderRepository{

    public GenderRepository(ApiIncidencesContext contex) : base(contex){
 
    }
}