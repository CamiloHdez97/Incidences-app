using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class PersonConfiguration : IEntityTypeConfiguration<Person>{

        public void Configure(EntityTypeBuilder<Person> builder){

            builder.ToTable("person");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasMaxLength(20);

            builder.Property(p => p.NamePerson).IsRequired().HasMaxLength(50);

            builder.HasOne(p => p.Gender).WithMany(p => p.Persons).HasForeignKey(p => p.IdGender);

            builder.HasOne(p => p.City).WithMany(p => p.Persons).HasForeignKey(p => p.IdCity);

            builder.HasOne(p => p.TypePerson).WithMany(p => p.Persons).HasForeignKey(p => p.IdTypePer);


        }

    }

}