using Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace persistencia.Configuration;
public class IncidenceConfiguration : IEntityTypeConfiguration<Incidence>
{
    public void Configure(EntityTypeBuilder<Incidence> builder)
    {
        builder.ToTable("Incidence");

            builder.Property(p => p.Id)
            .HasAnnotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn)
            .HasColumnName("Id_Incidence")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.IdPerson)
            .HasColumnName("id_user")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.IdPlace)
            .HasColumnName("id_place")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.IdState)
            .HasColumnName("id_state")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.IdPriority)
            .HasColumnName("id_priority")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.Date)
            .HasColumnName("date")
            .HasColumnType("Date")
            .IsRequired();

            builder.Property(p => p.IdCategoryIncidence)
            .HasColumnName("IdCategoryIncidence")
            .HasColumnType("int")
            .IsRequired();

            builder.Property(p => p.Description)
            .HasColumnName("Description")
            .HasColumnType("varchar")
            .HasMaxLength(50)
            .IsRequired();

            builder.HasOne(y => y.Person)
            .WithMany(l => l.Incidences)
            .HasForeignKey(z => z.IdPerson)
            .IsRequired();

            builder.HasOne(y => y.Place)
            .WithMany(l => l.Incidences)
            .HasForeignKey(z => z.IdPlace)
            .IsRequired();

            builder.HasOne(y => y.State)
            .WithMany(l => l.Incidences)
            .HasForeignKey(z => z.IdState)
            .IsRequired();

            builder.HasOne(y => y.Priority)
            .WithMany(l => l.Incidences)
            .HasForeignKey(z => z.IdPriority)
            .IsRequired();
            
            builder.HasOne(y => y.CategoryIncidence)
            .WithMany(l => l.Incidences)
            .HasForeignKey(z => z.IdCategoryIncidence)
            .IsRequired();


         
    }
}