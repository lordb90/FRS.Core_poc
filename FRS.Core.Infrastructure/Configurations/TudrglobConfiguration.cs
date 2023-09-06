using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class TudrglobConfiguration : IEntityTypeConfiguration<Tudrglob>
    {
        public void Configure(EntityTypeBuilder<Tudrglob> builder)
        {
            builder
                .HasNoKey()
                .ToTable("TUDRGLOB");

            builder.Property(e => e.Certname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CERTNAME");
            builder.Property(e => e.Disabletdr).HasColumnName("DISABLETDR");
            builder.Property(e => e.FrzTudr).HasColumnName("FRZ_TUDR");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.OstAlert)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OST_ALERT");
            builder.Property(e => e.OstMonitr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OST_MONITR");
            builder.Property(e => e.Xtrafeedra)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("XTRAFEEDRA");
            builder.Property(e => e.Xtrafeedrm)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("XTRAFEEDRM");

        }
    }
}