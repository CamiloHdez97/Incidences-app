using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class TuitionRepository : GenericRepository<Tuition>, ITuitionRepository{

    public TuitionRepository(ApiIncidencesContext contex) : base(contex){
        
    }

}