using Persistence;
using Aplication.Repository;
using Domain.Interfaces;
using Persistence;

namespace Aplication.UnitOfWork;

    public class UnitOfWork : IUnitOfWork, IDisposable{
    private readonly ApiIncidencesContext _context;
    private AddressRepository _Address;
    private AreaRepository _Area;
    private CategoryIncidenceRepository _CategoryIncidence;
    private CategoryContactRepository _CategoryContact;
    private CityRepository _City;
    private CountryRepository _Country;
    private ContactRepository _Contact;
    private GenderRepository _Gender;
    private IncidenceRepository _Incidence;
    private PersonRepository _Person;
    private PlaceRepository _Place;
    private PriorityRepository _Priority;
    private RegionRepository _Region;
    private RolRepository _Rol;
    private StateRepository _State;
    private TeamRepository _Team;
    private TrainerClassroomRepository _TrainerClassroom;
    private TuitionRepository _Tuition;
    private TypeContactRepository _TypeContact;
    private TypeDocumentRepository _TypeDocument;
    private TypePersonRepository _TypePerson;
    private UserRepository _User;
    private UserRolRepository _UserRol;

        public UnitOfWork(ApiIncidencesContext context)
        {
            _context = context;
        }

        public ICountryRepository Countries{

            get{
                if (_Country == null){
                    _Country = new CountryRepository(_context);
                }return _Country;
            }

        }

        public ICityRepository Cities
        {
            get
            {
                if (_City is not null)
                {
                    return _City;
                }
                return _City = new CityRepository(_context);
            }
        }

        public IPlaceRepository Places
        {
            get
            {
                if (_Place is not null)
                {
                    return _Place;
                }
                return _Place = new PlaceRepository(_context);
            }
        }

        public IGenderRepository Genders
        {
            get
            {
                if (_Gender is not null)
                {
                    return _Gender;
                }
                return _Gender = new GenderRepository(_context);
            }
        }

        public IPersonRepository Persons
        {
            get
            {
                if (_Person is not null)
                {
                    return _Person;
                }
                return _Person = new PersonRepository(_context);
            }
        }

        public IRegionRepository Regions
        {
            get
            {
                if (_Region is not null)
                {
                    return _Region;
                }
                return _Region = new RegionRepository(_context);
            }
        }

        public ITrainerClassroomRepository TrainerClassrooms
        {
            get
            {
                if (_TrainerClassroom is not null)
                {
                    return _TrainerClassroom;
                }
                return _TrainerClassroom = new TrainerClassroomRepository(_context);
            }
        }


        public ITypePersonRepository TypePersons
        {
            get
            {
                if (_TypePerson is not null)
                {
                    return _TypePerson;
                }
                return _TypePerson = new TypePersonRepository(_context);
            }
        }

        public ITuitionRepository Tuitions
        {
            get
            {
                if (_Tuition is not null)
                {
                    return _Tuition;
                }
                return _Tuition = new TuitionRepository(_context);
            }
        }

        public IUserRepository Users
        {
            get
            {
                if (_User is not null)
                {
                    return _User;
                }
                return _User = new UserRepository(_context);
            }
        }

        public IAddressRepository Addresses {
            get
            {
                if (_Address is not null)
                {
                    return _Address;
                }
                return _Address = new AddressRepository(_context);
            }
        } 

        public IAreaRepository Areas {
            get
            {
                if (_Area is not null){

                    return _Area;         
                }
                return _Area = new AreaRepository(_context);
            }
        } 

        public ICategoryIncidenceRepository CategoryIncidences {
            get
            {
                if (_CategoryIncidence is not null){
                    return _CategoryIncidence;
                }
                return _CategoryIncidence = new CategoryIncidenceRepository(_context);
            }
        } 

        public ICategoryContactRepository CategoryContacts {
            get
            {
                if (_CategoryContact is not null){
                    return _CategoryContact;
                }
                return _CategoryContact = new CategoryContactRepository(_context);
            }
        } 

        public IContactRepository Contacts {
            get
            {
                if (_Contact is not null){
                    return _Contact;
                }
                return _Contact = new ContactRepository(_context);
            }
        } 

        public IIncidenceRepository Incidences {
            get
            {
                if (_Incidence is not null){
                    return _Incidence;
                }
                return _Incidence = new IncidenceRepository(_context);
            }
        } 

        public IPriorityRepository Priorities {
            get
            {
                if (_Priority is not null){
                    return _Priority;
                }
                return _Priority = new PriorityRepository(_context);
            }
        } 

        public IStateRepository States {
            get
            {
                if (_State is not null){
                    return _State;
                }
                return _State = new StateRepository(_context);
            }
        } 

        public ITeamRepository Teams{
            get
            {
                if (_Team is not null){
                    return _Team;
                }
                return _Team = new TeamRepository(_context);
            }
        } 

        public ITypeContactRepository TypeContacts {
            get
            {
                if (_TypeContact is not null){
                    return _TypeContact;
                }
                return _TypeContact = new TypeContactRepository(_context);
            }
        } 

        public IUserRolRepository UserRols {
            get
            {
                if (_UserRol is not null){
                    return _UserRol;
                }
                return _UserRol = new UserRolRepository(_context);
            }
            
        } 

        public ITypeDocumentRepository TypeDocuments {
            get
            {
                if (_TypeDocument is not null){
                    return _TypeDocument;
                }
                    return _TypeDocument = new TypeDocumentRepository(_context);
            }
        } 

        public IRolRepository Rols {
            get
            {
                if (_Rol is not null){
                    return _Rol;
                }
                return _Rol = new RolRepository(_context);
            }
        } 

        public void Dispose(){
            _context.Dispose();
        }

        public async Task<int> SaveAsync(){
            return await _context.SaveChangesAsync();
        }
 } 


















