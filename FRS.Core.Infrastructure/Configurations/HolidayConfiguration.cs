using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class HolidayConfiguration : IEntityTypeConfiguration<Holiday>
    {
        public void Configure(EntityTypeBuilder<Holiday> builder)
        {
            builder
                .HasNoKey()
                .ToTable("HOLIDAY");

            builder.Property(e => e.Desc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
            builder.Property(e => e.Holidate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("HOLIDATE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        }
    }
}