using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configuration{

    public class TrainerClassroomConfiguration : IEntityTypeConfiguration<TrainerClassroom>{

        public void Configure(EntityTypeBuilder<TrainerClassroom> builder){

            builder.ToTable("trainer_classroom");
            builder.Property(p => p.IdPerTrainer).HasColumnName("id_trainer")
            .HasColumnType("int").HasMaxLength(20);
            builder.Property(p => p.IdClassroom).HasColumnName("id_classroom")
            .HasColumnType("int").HasColumnType("int");
            
            builder.HasOne(p => p.Person).WithMany(p => p.TrainerClassrooms).HasForeignKey(p => p.IdPerTrainer);
            builder.HasOne(p => p.Place).WithMany(p => p.TrainerClassrooms).HasForeignKey(p => p.IdClassroom);
    

        }

    }

}