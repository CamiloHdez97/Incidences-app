using System.Reflection.Metadata;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Persistence.Configuration{

    public class TypePersonConfiguration : IEntityTypeConfiguration<TypePerson>{

        public void Configure(EntityTypeBuilder<TypePerson> builder){

            builder.ToTable("type_person");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(P => P.DescriptionTypePerson).HasColumnName("description")
            .HasColumnType("varchar").IsRequired().HasMaxLength(50);

        }

    }

}