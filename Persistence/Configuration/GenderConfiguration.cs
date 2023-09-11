using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration{

public class GenderConfiguration : IEntityTypeConfiguration<Gender>
{

    public void Configure(EntityTypeBuilder<Gender> builder){

        builder.ToTable("gender");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.NameGender).HasColumnName("name_gender")
        .HasColumnType("varchar").IsRequired().HasMaxLength(50);

    }

    }
}