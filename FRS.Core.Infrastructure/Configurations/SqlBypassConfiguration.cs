using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class SqlBypassConfiguration : IEntityTypeConfiguration<SqlBypass>
    {
        public void Configure(EntityTypeBuilder<SqlBypass> builder)
        {
            builder
                .HasNoKey()
                .ToTable("SQL_BYPASS");

            builder.Property(e => e.Action)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ACTION");
            builder.Property(e => e.Fromwhere)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FROMWHERE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Lastattmpt)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LASTATTMPT");
            builder.Property(e => e.PfKey).HasColumnName("PF_KEY");
            builder.Property(e => e.Tablename)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TABLENAME");

        }
    }
}