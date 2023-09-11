using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration{

    public class CuidadConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder){
            
            builder.ToTable("city");
            builder.Property(p => p.Id)
                .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
                .HasColumnName("id_city")
                .HasColumnType("int")
                .IsRequired();
    
            builder.Property(p => p.NameCity).HasColumnName("name_city")
        .HasColumnType("varchar").IsRequired().HasMaxLength(50);

            builder.HasOne(e => e.Region).WithMany(p => p.Cities).HasForeignKey(p => p.IdRegion);

        }

    }

}