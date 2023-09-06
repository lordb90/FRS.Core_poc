using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class StihistoryConfiguration : IEntityTypeConfiguration<Stihistory>
    {
        public void Configure(EntityTypeBuilder<Stihistory> builder)
        {
            builder
                .HasNoKey()
                .ToTable("STIHISTORY");

            builder.Property(e => e.Cresponse)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRESPONSE");
            builder.Property(e => e.Cuserid)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CUSERID");
            builder.Property(e => e.Date1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DATE1");
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
                .HasMaxLength(20)
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
            builder.Property(e => e.Policy1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("POLICY1");
            builder.Property(e => e.Processed).HasColumnName("PROCESSED");
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
            builder.Property(e => e.Rtime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RTIME");
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