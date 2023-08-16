using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class TrainerLoungeConfiguration : IEntityTypeConfiguration<TrainerLounge>{

        public void Configure(EntityTypeBuilder<TrainerLounge> builder){

            builder.ToTable("trainerlounge");
            builder.Property(p => p.IdPerTrainerFk).HasMaxLength(20);
            builder.Property(p => p.IdLoungeFk).HasColumnType("int");
            
            builder.HasOne(p => p.Person).WithMany(p => p.TrainerLounges).HasForeignKey(p => p.IdPerTrainerFk);
            builder.HasOne(p => p.Lounge).WithMany(p => p.TrainerLounges).HasForeignKey(p => p.IdLoungeFk);
    

        }

    }

}