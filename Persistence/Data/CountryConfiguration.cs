using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.ToTable("country");

            builder.HasKey(e => e.IdCountry);
            builder.Property(e => e.IdCountry).HasMaxLength(3);

            builder.Property(p => p.NameCountry).IsRequired().HasMaxLength(50);
        }
    }

}