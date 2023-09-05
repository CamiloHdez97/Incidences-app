namespace Domain.Interfaces;

public interface IUnitOfWork{

    ICountryRepository Countries {get;}
    ICityRepository Cities {get;}
    IClassroomRepository Classrooms {get;}
    IGenderRepository Genders {get;}
    IPersonRepository Persons {get;}
    IRegionRepository Regions {get;}
    ITrainerClassroomRepository TrainerClassrooms {get;}
    ITuitionRepository Tuitions {get;}
    ITypePersonRepository TypePersons {get;}

}