using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class ResDistributeConfiguration : IEntityTypeConfiguration<ResDistribute>
    {
        public void Configure(EntityTypeBuilder<ResDistribute> builder)
        {
            builder
                .HasNoKey()
                .ToTable("RES_DISTRIBUTE");

            builder.Property(e => e.CmcvFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CMCV_FLAG");
            builder.Property(e => e.County)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNTY");
            builder.Property(e => e.Court)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COURT");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Method)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("METHOD");
            builder.Property(e => e.Processed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROCESSED");
            builder.Property(e => e.ResCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_CODE");
            builder.Property(e => e.ResRecip)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_RECIP");
            builder.Property(e => e.Sent)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SENT");
            builder.Property(e => e.SpecInstr)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SPEC_INSTR");
            builder.Property(e => e.SrchCrit)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRCH_CRIT");
            builder.Property(e => e.SrchType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRCH_TYPE");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.Submitted)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SUBMITTED");
            builder.Property(e => e.VoicePhon)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VOICE_PHON");
            builder.Property(e => e.Yesrectype)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("YESRECTYPE");

        }
    }
}