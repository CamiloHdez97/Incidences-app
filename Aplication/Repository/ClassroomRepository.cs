using Domain;
using Domain.Interfaces;
using Persistence;

namespace Aplication.Repository;

public class ClassroomRepository : GenericRepository<Classroom>, IClassroomRepository{

    public ClassroomRepository(ApiIncidencesContext contex) : base(contex){}

}