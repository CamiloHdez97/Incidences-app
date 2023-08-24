using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class ClassroomConfiguration : IEntityTypeConfiguration<Classroom>{

        public void Configure(EntityTypeBuilder<Classroom> builder){

            builder.ToTable("Lounge");
            builder.HasKey(e => e.IdClassroom);
            builder.Property(e => e.IdClassroom).HasMaxLength(20);

            builder.Property(p => p.NameClassroom).IsRequired().HasMaxLength(50);

            builder.Property(p => p.Capacity).HasColumnType("int");

        }


    }


}