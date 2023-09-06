using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WknreqQConfiguration : IEntityTypeConfiguration<WknreqQ>
    {
        public void Configure(EntityTypeBuilder<WknreqQ> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WKNREQ_Q");

            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.EmpCode)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_CODE");
            builder.Property(e => e.EmpName)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_NAME");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Invoiceamt)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("INVOICEAMT");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Noincdoemp).HasColumnName("NOINCDOEMP");
            builder.Property(e => e.Nsctransid)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NSCTRANSID");
            builder.Property(e => e.Postdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("POSTDATE");
            builder.Property(e => e.Processed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROCESSED");
            builder.Property(e => e.Rdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("RDATE");
            builder.Property(e => e.Request)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQUEST");
            builder.Property(e => e.Requestid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQUESTID");
            builder.Property(e => e.Response)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESPONSE");
            builder.Property(e => e.Resultid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESULTID");
            builder.Property(e => e.Retrydate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("RETRYDATE");
            builder.Property(e => e.Rtime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RTIME");
            builder.Property(e => e.Ssno)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("SSNO");
            builder.Property(e => e.Status)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATUS");
            builder.Property(e => e.Stored)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STORED");
            builder.Property(e => e.SubjAdded)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SUBJ_ADDED");
            builder.Property(e => e.SubjName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBJ_NAME");

        }
    }
}