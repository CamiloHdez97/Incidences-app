using Domain;
using Microsoft.EntityFrameworkCore;
namespace Persistence
{
    public class ApiIncidencesContext : DbContext
    {
        public ApiIncidencesContext(DbContextOptions<ApiIncidencesContext> options) : base(options){
        }
        public DbSet<City> Cities {get;set;}
        public DbSet<Person> Persons {get;set;}
        public DbSet<Lounge> Lounges {get;set;}
        public DbSet<Tuition> Tuitions {get;set;}
        public DbSet<TypePerson> TypePersons {get;set;}
        public DbSet<TrainerLounge> TrainerLounges {get;set;}
        public DbSet<Region> Regions {get;set;}
        public DbSet<Country> Countries {get;set;}
        public DbSet<Gender> Genders {get;set;}

    }

}