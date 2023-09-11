using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration{

    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.ToTable("team");

            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasMaxLength(3);

            builder.Property(p => p.NameTeam).HasColumnName("name_team")
        .HasColumnType("varchar").IsRequired().HasMaxLength(50);
        }
    }

}