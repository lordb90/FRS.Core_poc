using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class StireqQConfiguration : IEntityTypeConfiguration<StireqQ>
    {
        public void Configure(EntityTypeBuilder<StireqQ> builder)
        {
            builder
                .HasNoKey()
                .ToTable("STIREQ_Q");

            builder.Property(e => e.Checkdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("CHECKDATE");
            builder.Property(e => e.Controlno)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CONTROLNO");
            builder.Property(e => e.Cresponse)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRESPONSE");
            builder.Property(e => e.Cuserid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CUSERID");
            builder.Property(e => e.Date1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DATE1");
            builder.Property(e => e.Ecode)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("ECODE");
            builder.Property(e => e.Fname1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FNAME1");
            builder.Property(e => e.History1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HISTORY1");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Lapsedtime).HasColumnName("LAPSEDTIME");
            builder.Property(e => e.License1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LICENSE1");
            builder.Property(e => e.Lname1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LNAME1");
            builder.Property(e => e.Middle1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MIDDLE1");
            builder.Property(e => e.PfKey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("PF_KEY");
            builder.Property(e => e.Policy1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("POLICY1");
            builder.Property(e => e.Processed).HasColumnName("PROCESSED");
            builder.Property(e => e.Qback)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QBACK");
            builder.Property(e => e.Rdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("RDATE");
            builder.Property(e => e.Rdatetime)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("RDATETIME");
            builder.Property(e => e.Reqtypeava)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQTYPEAVA");
            builder.Property(e => e.RetrAtweb).HasColumnName("RETR_ATWEB");
            builder.Property(e => e.Retries)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("RETRIES");
            builder.Property(e => e.Rtime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RTIME");
            builder.Property(e => e.Senddate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SENDDATE");
            builder.Property(e => e.Sendtime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SENDTIME");
            builder.Property(e => e.SentDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SENT_DATE");
            builder.Property(e => e.SentTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SENT_TIME");
            builder.Property(e => e.Sex1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEX1");
            builder.Property(e => e.Site)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SITE");
            builder.Property(e => e.Social1)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SOCIAL1");
            builder.Property(e => e.State1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE1");
            builder.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATUS");
            builder.Property(e => e.Uploaded)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("UPLOADED");
            builder.Property(e => e.Username)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERNAME");
        }
    }
}