namespace Domain.Interfaces;

public interface IUnitOfWork{
    IAddressRepository Addresses {get;}
    IAreaRepository Areas {get;}
    ICategoryIncidenceRepository CategoryIncidences {get;}
    ICategoryContactRepository CategoryContacts {get;}
    ICityRepository Cities {get;}
    ICountryRepository Countries {get;}
    IContactRepository Contacts {get;}
    IGenderRepository Genders {get;}
    IIncidenceRepository Incidences {get;}
    IPersonRepository Persons {get;}
    IPlaceRepository Places {get;}
    IPriorityRepository Priorities {get;}
    IRegionRepository Regions {get;}
    IRolRepository Rols {get;}
    IStateRepository States {get;}
    ITeamRepository Teams {get;}
    ITrainerClassroomRepository TrainerClassrooms {get;}
    ITuitionRepository Tuitions {get;}
    ITypeContactRepository TypeContacts {get;}
    ITypeDocumentRepository TypeDocuments {get;}
    ITypePersonRepository TypePersons {get;}
    IUserRepository Users {get;}
    IUserRolRepository UserRols {get;}
    Task<int> SaveAsync();
}