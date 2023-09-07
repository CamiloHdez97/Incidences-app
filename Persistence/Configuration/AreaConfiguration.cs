using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
       
        builder.ToTable("Area");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Area")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.NameArea)
            .HasColumnName("Descriptionarea")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

    }
    
}