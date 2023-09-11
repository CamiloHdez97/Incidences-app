using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Domain;

namespace Persistence;

    public class ApiIncidencesContext : DbContext
    {
        public ApiIncidencesContext(DbContextOptions<ApiIncidencesContext> options) : base(options){
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Area> Areas {get;set;}
        public DbSet<City> Cities {get;set;}
        public DbSet<CategoryContact> CategoryContacts {get;set;}
        public DbSet<Person> Persons {get;set;}
        public DbSet<Place> Place {get;set;}
        public DbSet<Tuition> Tuitions {get;set;}
        public DbSet<TypePerson> TypePersons {get;set;}
        public DbSet<TrainerClassroom> TrainerClassrooms {get;set;}
        public DbSet<Region> Regions {get;set;}
        public DbSet<Country> Countries {get;set;}
        public DbSet<Gender> Genders {get;set;}
        public DbSet<Contact> Contacts {get;set;}
        public DbSet<State> States {get;set;}
        public DbSet<Priority> Priorities {get;set;}
        public DbSet<Rol> Roles {get;set;}
        public DbSet<Team> Teams {get;set;}
        public DbSet<TypeContact> TypeContacts {get;set;}
        public DbSet<TypeDocument> TypeDocuments {get;set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }

