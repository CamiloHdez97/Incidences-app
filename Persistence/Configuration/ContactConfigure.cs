using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.ToTable("Contact");

                builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id_contact")
                .HasColumnType("int")
                .IsRequired();

                builder.Property(p => p.IdTypeCon)
                .HasColumnName("type_contact")
                .HasColumnType("int")
                .IsRequired();

                builder.Property(p => p.IdCategoryContact)
                .HasColumnName("category_contact")
                .HasColumnType("int")
                .IsRequired();

                builder.Property(p => p.DescriptionContact)
                .HasColumnName("description")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                builder.HasOne(y => y.Person)
                .WithMany(l => l.Contacts)
                .HasForeignKey(z => z.IdPerson)
                .IsRequired();

                builder.HasOne(y => y.TypeContact)
                .WithMany(l => l.Contacts)
                .HasForeignKey(z => z.IdTypeCon)
                .IsRequired();

                builder.HasOne(y => y.CategoryContact)
                .WithMany(l => l.Contacts)
                .HasForeignKey(z => z.IdCategoryContact)
                .IsRequired();

    }
    
}