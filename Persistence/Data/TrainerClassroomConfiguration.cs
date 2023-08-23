using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class TrainerClassroomConfiguration : IEntityTypeConfiguration<TrainerClassroom>{

        public void Configure(EntityTypeBuilder<TrainerClassroom> builder){

            builder.ToTable("trainerlounge");
            builder.Property(p => p.IdPerTrainerFk).HasMaxLength(20);
            builder.Property(p => p.IdClassroomFk).HasColumnType("int");
            
            builder.HasOne(p => p.Person).WithMany(p => p.TrainerClassrooms).HasForeignKey(p => p.IdPerTrainerFk);
            builder.HasOne(p => p.Classroom).WithMany(p => p.TrainerClassrooms).HasForeignKey(p => p.IdClassroomFk);
    

        }

    }

}