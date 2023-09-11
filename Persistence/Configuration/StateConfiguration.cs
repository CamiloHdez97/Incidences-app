using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;
public class StateConfiguration : IEntityTypeConfiguration<State>
{
    public void Configure(EntityTypeBuilder<State> builder)
        {
            builder.ToTable("state");


            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("id_state")
            .HasColumnType("int")
            .IsRequired();


            builder.Property(p => p.Description)
            .HasColumnName("description")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();
        }
}