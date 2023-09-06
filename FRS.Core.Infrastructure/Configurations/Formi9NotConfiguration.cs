using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class Formi9NotConfiguration : IEntityTypeConfiguration<Formi9Not>
    {
        public void Configure(EntityTypeBuilder<Formi9Not> builder)
        {
            builder
                .HasNoKey()
                .ToTable("FORMI9_NOT");

            builder.Property(e => e.Alipartid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALIPARTID");
            builder.Property(e => e.Casenumber)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CASENUMBER");
            builder.Property(e => e.Dob)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOB");
            builder.Property(e => e.Errorcode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ERRORCODE");
            builder.Property(e => e.Errormsg)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ERRORMSG");
            builder.Property(e => e.Fi9key)
                .HasColumnType("numeric(12, 0)")
                .HasColumnName("FI9KEY");
            builder.Property(e => e.Firstname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FIRSTNAME");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Invoiceamt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INVOICEAMT");
            builder.Property(e => e.Lastname)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LASTNAME");
            builder.Property(e => e.Mi)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MI");
            builder.Property(e => e.Postdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("POSTDATE");
            builder.Property(e => e.Posttime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("POSTTIME");
            builder.Property(e => e.ProcDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("PROC_DATE");
            builder.Property(e => e.ProcTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROC_TIME");
            builder.Property(e => e.ProcTrack)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROC_TRACK");
            builder.Property(e => e.Processed).HasColumnName("PROCESSED");
            builder.Property(e => e.Requestid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQUESTID");
            builder.Property(e => e.Resultid)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESULTID");
            builder.Property(e => e.Resultxml)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESULTXML");
            builder.Property(e => e.Service)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERVICE");
            builder.Property(e => e.Serviceres)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERVICERES");
            builder.Property(e => e.Ssn)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN");
            builder.Property(e => e.Status)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATUS");
            builder.Property(e => e.Versionnbr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VERSIONNBR");
        }
    }
}