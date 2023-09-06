using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Core.Infrastructure.Configurations
{
    public class PfWkcmpNoIdentityConfiguration : IEntityTypeConfiguration<PfWkcmpNoIdentity>
    {
        public void Configure(EntityTypeBuilder<PfWkcmpNoIdentity> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PF_WKCMP_NO_IDENTITY");

            builder.Property(e => e.Fromdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("FROMDATE");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.PfKey).HasColumnName("PF_KEY");
            builder.Property(e => e.ResStat)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_STAT");
            builder.Property(e => e.ResWhen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_WHEN");
            builder.Property(e => e.Todate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("TODATE");
            builder.Property(e => e.Wcstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WCSTATE");
        }
    }
}
