using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class TdrreqQConfiguration : IEntityTypeConfiguration<TdrreqQ>
    {
        public void Configure(EntityTypeBuilder<TdrreqQ> builder)
        {
            builder
                .HasNoKey()
                .ToTable("TDRREQ_Q");

            builder.Property(e => e.Attempts)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("ATTEMPTS");
            builder.Property(e => e.Birthdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDATE");
            builder.Property(e => e.City)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CITY");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.DateAdded)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DATE_ADDED");
            builder.Property(e => e.DatePost)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DATE_POST");
            builder.Property(e => e.Dlnum)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLNUM");
            builder.Property(e => e.Dlstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLSTATE");
            builder.Property(e => e.Fname)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FNAME");
            builder.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("GENDER");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
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
            builder.Property(e => e.PfmlosKey).HasColumnName("PFMLOS_KEY");
            builder.Property(e => e.PfmvrKey).HasColumnName("PFMVR_KEY");
            builder.Property(e => e.PresAddr1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PRES_ADDR1");
            builder.Property(e => e.Processed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROCESSED");
            builder.Property(e => e.ProdCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROD_CODE");
            builder.Property(e => e.Request)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQUEST");
            builder.Property(e => e.Response)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESPONSE");
            builder.Property(e => e.Retrydate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("RETRYDATE");
            builder.Property(e => e.Ssno)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("SSNO");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.Statuscode)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("STATUSCODE");
            builder.Property(e => e.Statustext)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATUSTEXT");
            builder.Property(e => e.Stored)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STORED");
            builder.Property(e => e.TdrreqKey)
                .ValueGeneratedOnAdd()
                .HasColumnName("TDRREQ_KEY");
            builder.Property(e => e.Tdrtrackid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TDRTRACKID");
            builder.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ZIP");
        }
    }
}