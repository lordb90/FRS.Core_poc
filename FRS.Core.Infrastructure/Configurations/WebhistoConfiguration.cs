using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WebhistoConfiguration : IEntityTypeConfiguration<Webhisto>
    {
        public void Configure(EntityTypeBuilder<Webhisto> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WEBHISTO");

            builder.Property(e => e.AtWeb)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AT_WEB");
            builder.Property(e => e.FirstDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("FIRST_DATE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Partial)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PARTIAL");
            builder.Property(e => e.Pdf)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PDF");
            builder.Property(e => e.SendDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SEND_DATE");
            builder.Property(e => e.SendTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEND_TIME");

        }
    }
}