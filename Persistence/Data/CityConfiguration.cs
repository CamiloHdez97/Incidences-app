using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class CuidadConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder){
            
            builder.ToTable("city");
            builder.HasKey(e => e.IdCity);
            builder.Property(e => e.IdCity).HasMaxLength(3);
    
            builder.Property(p => p.NameCity).IsRequired().HasMaxLength(50);

            builder.HasOne(e => e.Region).WithMany(p => p.Cities).HasForeignKey(p => p.IdRegFk);

        }

    }

}