using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

public class PriorityConfiguration : IEntityTypeConfiguration<Priority>
{

    public void Configure(EntityTypeBuilder<Priority> builder){

        builder.ToTable("priority");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.Description).IsRequired().HasMaxLength(50);

    }

}
}