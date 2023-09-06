using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Core.Infrastructure.Configurations
{
    public class BkRefrqConfiguration : IEntityTypeConfiguration<BkRefrq>
    {
        public void Configure(EntityTypeBuilder<BkRefrq> builder)
        {
            builder
                .HasNoKey()
                .ToTable("BK_REFRQ");

            builder.Property(e => e.Aka)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AKA");
            builder.Property(e => e.AttHist)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATT_HIST");
            builder.Property(e => e.Attempts)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("ATTEMPTS");
            builder.Property(e => e.Clientid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CLIENTID");
            builder.Property(e => e.Clntsubid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CLNTSUBID");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Empkey)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMPKEY");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.InternFlg).HasColumnName("INTERN_FLG");
            builder.Property(e => e.Jurisdict)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("JURISDICT");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.LongType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LONG_TYPE");
            builder.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAME");
            builder.Property(e => e.Namefirst)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAMEFIRST");
            builder.Property(e => e.Namelast)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAMELAST");
            builder.Property(e => e.Namemiddle)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAMEMIDDLE");
            builder.Property(e => e.NumAkas)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("NUM_AKAS");
            builder.Property(e => e.OtherInfo)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTHER_INFO");
            builder.Property(e => e.Processed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROCESSED");
            builder.Property(e => e.Qdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("QDATE");
            builder.Property(e => e.Qtime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QTIME");
            builder.Property(e => e.Response)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESPONSE");
            builder.Property(e => e.Returned)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RETURNED");
            builder.Property(e => e.Rpconfirm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RPCONFIRM");
            builder.Property(e => e.Rperrormsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RPERRORMSG");
            builder.Property(e => e.Rporderid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RPORDERID");
            builder.Property(e => e.Rppassword)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RPPASSWORD");
            builder.Property(e => e.Sdesc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SDESC");
            builder.Property(e => e.Senddate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SENDDATE");
            builder.Property(e => e.Sendtime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SENDTIME");
            builder.Property(e => e.Srequest)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SREQUEST");
            builder.Property(e => e.Ssn)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN");
            builder.Property(e => e.Stored)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STORED");
            builder.Property(e => e.StrPoints)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STR_POINTS");
            builder.Property(e => e.VerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VER_TYPE");
            builder.Property(e => e.WcompDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WCOMP_DATE");
            builder.Property(e => e.WcompTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WCOMP_TIME");
            builder.Property(e => e.WebStat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEB_STAT");
            builder.Property(e => e.Wtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WTYPE");
        }
    }
}
