using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class EmplookConfiguration : IEntityTypeConfiguration<Emplook>
    {
        public void Configure(EntityTypeBuilder<Emplook> builder)
        {
            builder
                .HasNoKey()
                .ToTable("EMPLOOK");

            builder.Property(e => e.Clearhouse)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CLEARHOUSE");
            builder.Property(e => e.EFax)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("E_FAX");
            builder.Property(e => e.EPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("E_PHONE");
            builder.Property(e => e.EmpCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_CODE");
            builder.Property(e => e.Employer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMPLOYER");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Location)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCATION");
            builder.Property(e => e.Notes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NOTES");
            builder.Property(e => e.Supervisor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUPERVISOR");
            builder.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TITLE");

        }
    }
}