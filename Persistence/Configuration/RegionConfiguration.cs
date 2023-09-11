using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration{

    public class RegionConfiguration : IEntityTypeConfiguration<Region>{
        public void Configure(EntityTypeBuilder<Region> builder){
            builder.ToTable("region");

            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id_region")
                .HasColumnType("int")
                .IsRequired();

            builder.Property(p => p.NameRegion).HasColumnName("name_region")
        .HasColumnType("varchar").IsRequired().HasMaxLength(50);

            builder.HasOne(p => p.Country).WithMany(p => p.Regions).HasForeignKey(p => p.IdCountry);

        }
    }

}