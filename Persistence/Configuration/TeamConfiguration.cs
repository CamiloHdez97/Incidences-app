using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("Team");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasMaxLength(3);

            builder.Property(p => p.NameTeam).IsRequired().HasMaxLength(50);
        }
    }

}