using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class LxfrErrConfiguration : IEntityTypeConfiguration<LxfrErr>
    {
        public void Configure(EntityTypeBuilder<LxfrErr> builder)
        {
            builder
                .HasNoKey()
                .ToTable("LXFR_ERR");

            builder.Property(e => e.Acctcode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ACCTCODE");
            builder.Property(e => e.Batchid)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BATCHID");
            builder.Property(e => e.DSiteid)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("D_SITEID");
            builder.Property(e => e.Datetime)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DATETIME");
            builder.Property(e => e.Errmsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ERRMSG");
            builder.Property(e => e.Filename)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILENAME");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.SSiteid)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("S_SITEID");
            builder.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPE");
            builder.Property(e => e.Viewed).HasColumnName("VIEWED");

        }
    }
}