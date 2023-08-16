using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration{

    public class LoungeConfiguration : IEntityTypeConfiguration<Lounge>{

        public void Configure(EntityTypeBuilder<Lounge> builder){

            builder.ToTable("Lounge");
            builder.HasKey(e => e.IdLounge);
            builder.Property(e => e.IdLounge).HasMaxLength(20);

            builder.Property(p => p.NameLounge).IsRequired().HasMaxLength(50);

            builder.Property(p => p.Capacity).HasColumnType("int");

        }


    }


}