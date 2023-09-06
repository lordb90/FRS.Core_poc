using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class LxAuthConfiguration : IEntityTypeConfiguration<LxAuth>
    {
        public void Configure(EntityTypeBuilder<LxAuth> builder)
        {
            builder
                .HasNoKey()
                .ToTable("LX_AUTH");

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
            builder.Property(e => e.Filename)
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