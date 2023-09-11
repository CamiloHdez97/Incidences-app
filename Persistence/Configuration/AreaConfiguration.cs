using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;
public class AreaConfiguration : IEntityTypeConfiguration<Area>
{
    public void Configure(EntityTypeBuilder<Area> builder)
    {
       
        builder.ToTable("area");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("id_area")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.NameArea)
            .HasColumnName("descriptionarea")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

    }
    
}