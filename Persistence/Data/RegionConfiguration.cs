using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class RegionConfiguration : IEntityTypeConfiguration<Region>{
        public void Configure(EntityTypeBuilder<Region> builder){
            builder.ToTable("region");

            builder.HasKey(e => e.IdRegion);
            builder.Property(e => e.IdRegion).HasMaxLength(3);

            builder.Property(p => p.NameRegion).IsRequired().HasMaxLength(50);

            builder.HasOne(p => p.Country).WithMany(p => p.Regions).HasForeignKey(p => p.IdCountryFk);

        }
    }

}