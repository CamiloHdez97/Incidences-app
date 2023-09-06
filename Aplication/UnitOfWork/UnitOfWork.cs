using Aplication.Repository;
using APlication.Repository;
using Domain.Interfaces;
using Persistence;

namespace Aplication.UnitOfWork;

    public class UnitOfWork : IUnitOfWork, IDisposable{

        private readonly ApiIncidencesContext _context;
        private CountryRepository _Countries;
        private CityRepository _City;
        private ClassroomRepository _Classrooms;
        private GenderRepository _Gender;
        private PersonRepository _Person;
        private RegionRepository _Region;
        private TrainerClassroomRepository _TrainerClassroom;
        private TuitionRepository _Tuition;
        private TypePersonRepository _TypePerson;
        private UserRepository _User;
        

        public UnitOfWork(ApiIncidencesContext context)
        {
            _context = context;
        }

        public ICountryRepository Countries{

            get{
                if (_Countries == null){
                    _Countries = new CountryRepository(_context);
                }return _Countries;
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

        public IClassroomRepository Classrooms
        {
            get
            {
                if (_Classrooms is not null)
                {
                    return _Classrooms;
                }
                return _Classrooms = new ClassroomRepository(_context);
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

        public void Dispose(){
            _context.Dispose();
        }

        public async Task<int> SaveAsync(){
            return await _context.SaveChangesAsync();
        }


}
