using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class EclresultConfiguration : IEntityTypeConfiguration<Eclresult>
    {
        public void Configure(EntityTypeBuilder<Eclresult> builder)
        {
            builder
                .HasNoKey()
                .ToTable("ECLRESULT");

            builder.Property(e => e.AdjudRes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADJUD_RES");
            builder.Property(e => e.DailyInv).HasColumnName("DAILY_INV");
            builder.Property(e => e.DlxCharge)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLX_CHARGE");
            builder.Property(e => e.ExtraInfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXTRA_INFO");
            builder.Property(e => e.FullDiscl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FULL_DISCL");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.InvDat)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INV_DAT");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.PostDtime)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("POST_DTIME");
            builder.Property(e => e.PrSupplem).HasColumnName("PR_SUPPLEM");
            builder.Property(e => e.Resultinfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESULTINFO");
            builder.Property(e => e.StateText)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE_TEXT");
            builder.Property(e => e.Statecover).HasColumnName("STATECOVER");
            builder.Property(e => e.Whichres)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("WHICHRES");

        }
    }
}