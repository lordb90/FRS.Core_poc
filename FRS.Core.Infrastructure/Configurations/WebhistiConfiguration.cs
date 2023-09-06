using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WebhistiConfiguration : IEntityTypeConfiguration<Webhisti>
    {
        public void Configure(EntityTypeBuilder<Webhisti> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WEBHISTI");

            builder.Property(e => e.DateStamp)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DATE_STAMP");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.TimeStamp)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TIME_STAMP");
            builder.Property(e => e.UnqOrder)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("UNQ_ORDER");

        }
    }
}