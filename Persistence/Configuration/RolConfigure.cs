using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;
public class RolConfiguration : IEntityTypeConfiguration<Rol>
{
    public void Configure(EntityTypeBuilder<Rol> builder)
    {
        builder.ToTable("Rol");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("id_rol")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.NameRol)
            .HasColumnName("name_rol")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();


            builder.Property(p => p.Description)
            .HasColumnName("description")
            .HasColumnType("varchar")
            .HasMaxLength(100)
            .IsRequired();

    }
}