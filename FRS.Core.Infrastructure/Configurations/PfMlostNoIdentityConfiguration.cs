using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Core.Infrastructure.Configurations
{
    public class PfMlostNoIdentityConfiguration : IEntityTypeConfiguration<PfMlostNoIdentity>
    {
        public void Configure(EntityTypeBuilder<PfMlostNoIdentity> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PF_MLOST_NO_IDENTITY");

            builder.Property(e => e.Advdt2gen)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("ADVDT2GEN");
            builder.Property(e => e.Complete).HasColumnName("COMPLETE");
            builder.Property(e => e.Compressed).HasColumnName("COMPRESSED");
            builder.Property(e => e.DlinxRetr).HasColumnName("DLINX_RETR");
            builder.Property(e => e.Eorder)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("EORDER");
            builder.Property(e => e.FmtSrcrit)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FMT_SRCRIT");
            builder.Property(e => e.FmtXtra)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FMT_XTRA");
            builder.Property(e => e.Grossalary)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("GROSSALARY");
            builder.Property(e => e.InoteComp).HasColumnName("INOTE_COMP");
            builder.Property(e => e.InoteUcsz).HasColumnName("INOTE_UCSZ");
            builder.Property(e => e.IntNotes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_NOTES");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Lastmodify)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LASTMODIFY");
            builder.Property(e => e.Mlodiscrep).HasColumnName("MLODISCREP");
            builder.Property(e => e.NoCharge).HasColumnName("NO_CHARGE");
            builder.Property(e => e.Oresults)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ORESULTS");
            builder.Property(e => e.OrigRes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ORIG_RES");
            builder.Property(e => e.OsrchCrit)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OSRCH_CRIT");
            builder.Property(e => e.OstDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OST_DESC");
            builder.Property(e => e.PfKey).HasColumnName("PF_KEY");
            builder.Property(e => e.Print).HasColumnName("PRINT");
            builder.Property(e => e.RecReview).HasColumnName("REC_REVIEW");
            builder.Property(e => e.RecalLast)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RECAL_LAST");
            builder.Property(e => e.RecallCnt)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("RECALL_CNT");
            builder.Property(e => e.RecallDt)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RECALL_DT");
            builder.Property(e => e.RefFlag).HasColumnName("REF_FLAG");
            builder.Property(e => e.Rentamount)
                .HasColumnType("numeric(11, 2)")
                .HasColumnName("RENTAMOUNT");
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
            builder.Property(e => e.Tntresults)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TNTRESULTS");
            builder.Property(e => e.Uncompsize).HasColumnName("UNCOMPSIZE");
            builder.Property(e => e.Verifyinc).HasColumnName("VERIFYINC");
        }
    }
}
