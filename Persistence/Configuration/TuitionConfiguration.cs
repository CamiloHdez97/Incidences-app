using System.Security.Cryptography.X509Certificates;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class TuitionConfiguration : IEntityTypeConfiguration<Tuition>{

        public void Configure(EntityTypeBuilder<Tuition> builder)
        {

            builder.ToTable("tuition");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.HasOne(y => y.Person)
            .WithMany(l => l.Tuitions)
            .HasForeignKey(z => z.IdPerson)
            .IsRequired();

            builder.HasOne(y => y.Team)
            .WithMany(l => l.Tuitions)
            .HasForeignKey(z => z.IdPerson)
            .IsRequired();

            builder.HasOne(y => y.Place)
            .WithMany(l => l.Tuitions)
            .HasForeignKey(z => z.IdPerson)
            .IsRequired();
        }

    }

}