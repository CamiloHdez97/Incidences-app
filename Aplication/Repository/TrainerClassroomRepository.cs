using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class TrainerClassroomRepository : GenericRepository<TrainerClassroom>, ITrainerClassroomRepository{
    public TrainerClassroomRepository(ApiIncidencesContext contex) : base(contex){}
}