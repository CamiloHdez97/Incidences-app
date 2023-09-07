using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class TrainerClassroomConfiguration : IEntityTypeConfiguration<TrainerClassroom>{

        public void Configure(EntityTypeBuilder<TrainerClassroom> builder){

            builder.ToTable("trainerClassroom");
            builder.Property(p => p.IdPerTrainer).HasMaxLength(20);
            builder.Property(p => p.IdClassroom).HasColumnType("int");
            
            builder.HasOne(p => p.Person).WithMany(p => p.TrainerClassrooms).HasForeignKey(p => p.IdPerTrainer);
            builder.HasOne(p => p.Place).WithMany(p => p.TrainerClassrooms).HasForeignKey(p => p.IdClassroom);
    

        }

    }

}