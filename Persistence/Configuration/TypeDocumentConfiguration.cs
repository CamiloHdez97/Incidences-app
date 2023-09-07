using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistencia.Configuration;
public class TypeDocumentConfiguration : IEntityTypeConfiguration<TypeDocument>
{
    public void Configure(EntityTypeBuilder<TypeDocument> builder)
    {
        builder.ToTable("DocumentType");


            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("id_documentType")
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