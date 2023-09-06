using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class IcrreqQConfiguration : IEntityTypeConfiguration<IcrreqQ>
    {
        public void Configure(EntityTypeBuilder<IcrreqQ> builder)
        {
            builder
                .HasNoKey()
                .ToTable("ICRREQ_Q");

            builder.Property(e => e.BurType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BUR_TYPE");
            builder.Property(e => e.Bureau)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BUREAU");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Compressed).HasColumnName("COMPRESSED");
            builder.Property(e => e.ExtraInfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXTRA_INFO");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Name)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAME");
            builder.Property(e => e.RetrAtweb).HasColumnName("RETR_ATWEB");
            builder.Property(e => e.Returned)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RETURNED");
            builder.Property(e => e.Senddate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SENDDATE");
            builder.Property(e => e.Sendtime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SENDTIME");
            builder.Property(e => e.Ssn)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN");
            builder.Property(e => e.Uncompsize).HasColumnName("UNCOMPSIZE");
            builder.Property(e => e.Webresults)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEBRESULTS");

        }
    }
}