using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;
public class TypeContactConfiguration : IEntityTypeConfiguration<TypeContact>
{
    public void Configure(EntityTypeBuilder<TypeContact> builder)
    {
        builder.ToTable("ContactType");

                builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id_contacttype")
                .HasColumnType("int")
                .IsRequired();

                builder.Property(p => p.NameContact)
                .HasColumnName("name_contact")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                builder.Property(p => p.Description)
                .HasColumnName("description")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();  

    }

}