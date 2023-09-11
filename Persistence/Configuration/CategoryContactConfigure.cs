using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;
public class CategoryContactConfiguration : IEntityTypeConfiguration<CategoryContact>
{
    public void Configure(EntityTypeBuilder<CategoryContact> builder)
    {
        builder.ToTable("category_contact");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("id_categoryContact")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.Description)
            .HasColumnName("description")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();

         }
}