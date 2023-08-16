using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class PersonConfiguration : IEntityTypeConfiguration<Person>{

        public void Configure(EntityTypeBuilder<Person> builder){

            builder.ToTable("person");
            builder.HasKey(e => e.IdPerson);
            builder.Property(e => e.IdPerson).HasMaxLength(20);

            builder.Property(p => p.NamePerson).IsRequired().HasMaxLength(50);

            builder.HasOne(p => p.Gender).WithMany(p => p.Persons).HasForeignKey(p => p.IdGenderFk);

            builder.HasOne(p => p.City).WithMany(p => p.Persons).HasForeignKey(p => p.IdCityFk);

            builder.HasOne(p => p.TypePerson).WithMany(p => p.Persons).HasForeignKey(p => p.IdTypePerFk);


        }

    }

}