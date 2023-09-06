using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class ReshistConfiguration : IEntityTypeConfiguration<Reshist>
    {
        public void Configure(EntityTypeBuilder<Reshist> builder)
        {
            builder
                .HasNoKey()
                .ToTable("RESHIST");

            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Device)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DEVICE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Namelist)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAMELIST");
            builder.Property(e => e.NumNames)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUM_NAMES");
            builder.Property(e => e.Resend)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESEND");
            builder.Property(e => e.RhDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("RH_DATE");
            builder.Property(e => e.RhTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RH_TIME");
            builder.Property(e => e.User)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USER");
        }
    }
}