namespace Domain.Interfaces;

public interface IUnitOfWork{

    ICityRepository Countries {get;}
    IClassroomRepository Classrooms {get;}
    IGenderRepository Genders {get;}
    IPersonRepository Persons {get;}
    IRegionRepository Regions {get;}
    ITrainerClassroomRepository TrainerClassrooms {get;}
    ITuitionRepository Tuitions {get;}
    ITyperPersonRepository TyperPersons {get;}

}