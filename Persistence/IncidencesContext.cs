using Domain;
using Microsoft.EntityFrameworkCore;
namespace Persistence;

    public class ApiIncidencesContext : DbContext
    {
        public ApiIncidencesContext(DbContextOptions<ApiIncidencesContext> options) : base(options){
        }

        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities {get;set;}
        public DbSet<Person> Persons {get;set;}
        public DbSet<Classroom> Classrooms {get;set;}
        public DbSet<Tuition> Tuitions {get;set;}
        public DbSet<TypePerson> TypePersons {get;set;}
        public DbSet<TrainerClassroom> TrainerClassrooms {get;set;}
        public DbSet<Region> Regions {get;set;}
        public DbSet<Country> Countries {get;set;}
        public DbSet<Gender> Genders {get;set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }

