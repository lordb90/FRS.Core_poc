using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class PrCrimConfiguration : IEntityTypeConfiguration<PrCrim>
    {
        public void Configure(EntityTypeBuilder<PrCrim> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PR_CRIM");

            builder.Property(e => e.Aka)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AKA");
            builder.Property(e => e.Birthdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDATE");
            builder.Property(e => e.City)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CITY");
            builder.Property(e => e.CmcvFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CMCV_FLAG");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.CompDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("COMP_DATE");
            builder.Property(e => e.CompTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_TIME");
            builder.Property(e => e.County)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNTY");
            builder.Property(e => e.Crstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRSTATE");
            builder.Property(e => e.Crstatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRSTATUS");
            builder.Property(e => e.Csrchinstr)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CSRCHINSTR");
            builder.Property(e => e.DispInfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DISP_INFO");
            builder.Property(e => e.Fname)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FNAME");
            builder.Property(e => e.Freeze)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FREEZE");
            builder.Property(e => e.HomeKey7)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("HOME_KEY7");
            builder.Property(e => e.HomeKey8)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("HOME_KEY8");
            builder.Property(e => e.IntId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_ID");
            builder.Property(e => e.IntTrk1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_1");
            builder.Property(e => e.IntTrk2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_2");
            builder.Property(e => e.IntTrk3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_3");
            builder.Property(e => e.IntTrk4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_4");
            builder.Property(e => e.IntTrk5)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_5");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Lastupdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            builder.Property(e => e.Lname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LNAME");
            builder.Property(e => e.Mname)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MNAME");
            builder.Property(e => e.Numrecs)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("NUMRECS");
            builder.Property(e => e.OthDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTH_DESC");
            builder.Property(e => e.RecDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("REC_DATE");
            builder.Property(e => e.RecReview).HasColumnName("REC_REVIEW");
            builder.Property(e => e.RecTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REC_TIME");
            builder.Property(e => e.ResName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_NAME");
            builder.Property(e => e.ResStat)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_STAT");
            builder.Property(e => e.Reviewed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REVIEWED");
            builder.Property(e => e.Selected).HasColumnName("SELECTED");
            builder.Property(e => e.Snapshot)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SNAPSHOT");
            builder.Property(e => e.SrchCrit)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRCH_CRIT");
            builder.Property(e => e.SrchFel).HasColumnName("SRCH_FEL");
            builder.Property(e => e.SrchInd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRCH_IND");
            builder.Property(e => e.SrchInstr)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRCH_INSTR");
            builder.Property(e => e.SrchLc).HasColumnName("SRCH_LC");
            builder.Property(e => e.SrchMisd).HasColumnName("SRCH_MISD");
            builder.Property(e => e.SrchOth).HasColumnName("SRCH_OTH");
            builder.Property(e => e.SrchUc).HasColumnName("SRCH_UC");
            builder.Property(e => e.Ssn)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN");
            builder.Property(e => e.Subprofile)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBPROFILE");
            builder.Property(e => e.Turnaround)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("TURNAROUND");
        }
    }
}