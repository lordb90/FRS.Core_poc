using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class PrPlicConfiguration : IEntityTypeConfiguration<PrPlic>
    {
        public void Configure(EntityTypeBuilder<PrPlic> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PR_PLIC");

            builder.Property(e => e.AcctMgr)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ACCT_MGR");
            builder.Property(e => e.Aka)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AKA");
            builder.Property(e => e.Birthdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDATE");
            builder.Property(e => e.ChCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CH_CODE");
            builder.Property(e => e.Clearhouse)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CLEARHOUSE");
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
            builder.Property(e => e.Complete).HasColumnName("COMPLETE");
            builder.Property(e => e.Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
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
            builder.Property(e => e.Groupval)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("GROUPVAL");
            builder.Property(e => e.HomeKey7)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("HOME_KEY7");
            builder.Property(e => e.HomeKey8)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("HOME_KEY8");
            builder.Property(e => e.IntComm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_COMM");
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
            builder.Property(e => e.Location)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCATION");
            builder.Property(e => e.Longdesc)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LONGDESC");
            builder.Property(e => e.Mname)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MNAME");
            builder.Property(e => e.PfKey).HasColumnName("PF_KEY");
            builder.Property(e => e.RecDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("REC_DATE");
            builder.Property(e => e.RecDttm)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REC_DTTM");
            builder.Property(e => e.RecTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REC_TIME");
            builder.Property(e => e.RecallCnt)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("RECALL_CNT");
            builder.Property(e => e.RecallDt)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RECALL_DT");
            builder.Property(e => e.ResMeth)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_METH");
            builder.Property(e => e.ResName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_NAME");
            builder.Property(e => e.ResReturn)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_RETURN");
            builder.Property(e => e.ResStat)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_STAT");
            builder.Property(e => e.ResWhen)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_WHEN");
            builder.Property(e => e.Reviewed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REVIEWED");
            builder.Property(e => e.Selected).HasColumnName("SELECTED");
            builder.Property(e => e.ShortType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SHORT_TYPE");
            builder.Property(e => e.Ssn)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN");
            builder.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATUS");
            builder.Property(e => e.SubjName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBJ_NAME");
            builder.Property(e => e.Turnaround)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("TURNAROUND");
            builder.Property(e => e.Type)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPE");
        }
    }
}