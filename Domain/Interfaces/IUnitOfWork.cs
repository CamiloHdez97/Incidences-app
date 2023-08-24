namespace Domain.Interfaces;

public interface IUnitOfWork{

    ICityRepository Country {get;}
    IClassroomRepository Classroom {get;}
    IGenderRepository Gender {get;}
    IPersonRepository Person {get;}
    IRegionRepository Region {get;}
    ITrainerClassroomRepository TrainerClassroom {get;}
    ITuitionRepository Tuition {get;}
    ITyperPersonRepository TyperPerson {get;}

}