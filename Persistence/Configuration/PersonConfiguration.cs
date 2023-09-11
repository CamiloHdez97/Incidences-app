using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration{

    public class PersonConfiguration : IEntityTypeConfiguration<Person>{

        public void Configure(EntityTypeBuilder<Person> builder){

  builder.ToTable("person");

        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("id_person")
        .HasColumnType("int")
        .IsRequired();

        builder.Property(p => p.NamePerson)
        .HasColumnName("name")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();

        builder.Property(p => p.LastNamePerson)
        .HasColumnName("lastname")
        .HasColumnType("varchar")
        .HasMaxLength(150)
        .IsRequired();


        builder.HasOne(u => u.City)
        .WithMany(a => a.Persons)
        .HasForeignKey(u => u.IdCity)
        .IsRequired();

        builder.HasOne(u => u.Gender)
        .WithMany(a => a.Persons)
        .HasForeignKey(u => u.IdGender)
        .IsRequired();

        
        builder.HasOne(u => u.TypePerson)
        .WithMany(a => a.Persons)
        .HasForeignKey(u => u.IdTypePer)
        .IsRequired();

        }

    }

}