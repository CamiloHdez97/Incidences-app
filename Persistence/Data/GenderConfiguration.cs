using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

public class GenderConfiguration : IEntityTypeConfiguration<Gender>
{

    public void Configure(EntityTypeBuilder<Gender> builder){

        builder.ToTable("gender");
        builder.HasKey(e => e.IdGender);
        builder.Property(e => e.IdGender);

        builder.Property(p => p.NameGender).IsRequired().HasMaxLength(50);

    }

}
}