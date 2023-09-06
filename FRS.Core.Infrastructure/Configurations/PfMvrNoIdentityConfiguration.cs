using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Core.Infrastructure.Configurations
{
    public class PfMvrNoIdentityConfiguration : IEntityTypeConfiguration<PfMvrNoIdentity>
    {
        public void Configure(EntityTypeBuilder<PfMvrNoIdentity> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PF_MVR_NO_IDENTITY");

            builder.Property(e => e.Dlflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLFLAG");
            builder.Property(e => e.Dlnum)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLNUM");
            builder.Property(e => e.Dlstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLSTATE");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.LxstruRes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LXSTRU_RES");
            builder.Property(e => e.MvrPflag)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("MVR_PFLAG");
            builder.Property(e => e.NbrYears)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("NBR_YEARS");
            builder.Property(e => e.PfKey).HasColumnName("PF_KEY");
            builder.Property(e => e.ResReturn)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_RETURN");
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
            builder.Property(e => e.ShortSumm)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SHORT_SUMM");
            builder.Property(e => e.Summary)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUMMARY");
            builder.Property(e => e.Vendor)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VENDOR");
        }
    }
}
