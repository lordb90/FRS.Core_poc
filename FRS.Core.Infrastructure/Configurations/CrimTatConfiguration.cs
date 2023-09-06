using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class CrimTatConfiguration : IEntityTypeConfiguration<CrimTat>
    {
        public void Configure(EntityTypeBuilder<CrimTat> builder)
        {
            builder.HasNoKey()
                .ToTable("CRIM_TAT");

            builder.Property(e => e.County)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNTY");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.TatAdded)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("TAT_ADDED");
            builder.Property(e => e.TatHrs)
                .HasColumnType("numeric(9, 2)")
                .HasColumnName("TAT_HRS");
            builder.Property(e => e.TatMins)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("TAT_MINS");
        }
    }
}