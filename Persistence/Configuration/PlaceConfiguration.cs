using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;
public class PlaceConfiguration : IEntityTypeConfiguration<Place>
{
    public void Configure(EntityTypeBuilder<Place> builder)
    {
        builder.ToTable("place");

                builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id_place")
                .HasColumnType("int")
                .IsRequired();


                builder.Property(p => p.NamePlace)
                .HasColumnName("name_place")
                .HasColumnType("varchar")
                .HasMaxLength(50)
                .IsRequired();

                builder.Property(p => p.Capacity)
                .HasColumnName("capacity")
                .HasColumnType("varchar")
                .HasMaxLength(200)
                .IsRequired();

                builder.HasOne(y => y.Area)
                .WithMany(l => l.Places)
                .HasForeignKey(z => z.IdArea)
                .IsRequired();
    }
}