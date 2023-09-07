using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class TeamRepository : GenericRepository<Team>, ITeamRepository{
    public TeamRepository(ApiIncidencesContext contex) : base(contex){
        
    }
}