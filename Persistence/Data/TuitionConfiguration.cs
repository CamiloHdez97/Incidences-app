using System.Security.Cryptography.X509Certificates;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class TuitionConfiguration : IEntityTypeConfiguration<Tuition>{

        public void Configure(EntityTypeBuilder<Tuition> builder)
        {

            builder.ToTable("tuition");

            builder.HasKey(e => e.IdTuition);
            builder.Property(e => e.IdTuition);

        }

    }

}