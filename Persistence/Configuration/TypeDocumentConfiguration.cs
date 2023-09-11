using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration;
public class TypeDocumentConfiguration : IEntityTypeConfiguration<TypeDocument>
{
    public void Configure(EntityTypeBuilder<TypeDocument> builder)
    {
        builder.ToTable("type_document");


            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("id_documenttype")
            .HasColumnType("int")
            .IsRequired();


            builder.Property(p => p.NameDocumentType)
            .HasColumnName("description")
            .HasColumnType("varchar")
            .HasMaxLength(200)
            .IsRequired();       

            builder.Property(p => p.Abbreviation)
            .HasColumnName("abbreviation")
            .HasColumnType("varchar")
            .HasMaxLength(10)
            .IsRequired();                    

    }
}