using System.Reflection.Metadata;
using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Persistence.Data.Configuration{

    public class TypePersonConfiguration : IEntityTypeConfiguration<TypePerson>{

        public void Configure(EntityTypeBuilder<TypePerson> builder){

            builder.ToTable("typeperson");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id);

            builder.Property(P => P.DescriptionTypePerson).IsRequired().HasMaxLength(50);

        }

    }

}