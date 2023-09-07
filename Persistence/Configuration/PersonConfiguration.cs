using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class PersonConfiguration : IEntityTypeConfiguration<Person>{

        public void Configure(EntityTypeBuilder<Person> builder){

  builder.ToTable("Person");


        builder.Property(p => p.Id)
        .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
        .HasColumnName("id_user")
        .HasColumnType("int")
        .IsRequired();

        builder.Property(p => p.IdDocumentType)
        .HasColumnName("document_type")
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


        builder.Property(p => p.IdGender)
       .HasColumnName("id_gender")
       .HasColumnType("varchar")
       .HasMaxLength(150)
       .IsRequired();


        builder.HasOne(u => u.City)
        .WithMany(a => a.Persons)
        .HasForeignKey(u => u.IdCity)
        .IsRequired();

        
        builder.HasOne(u => u.TypePerson)
        .WithMany(a => a.Persons)
        .HasForeignKey(u => u.IdTypePer)
        .IsRequired();


        }

    }

}