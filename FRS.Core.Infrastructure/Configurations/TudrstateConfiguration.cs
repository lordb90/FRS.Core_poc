using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class TudrstateConfiguration : IEntityTypeConfiguration<Tudrstate>
    {
        public void Configure(EntityTypeBuilder<Tudrstate> builder)
        {
            builder
                .HasNoKey()
                .ToTable("TUDRSTATES");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Lookback)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("LOOKBACK");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.Statelong)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATELONG");
        }
    }
}