using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using FRS.Core.Domain.Entities;

namespace FRS.Core.Infrastructure.Configurations;

public class ActivityConfiguration : IEntityTypeConfiguration<Activity>
{
    public void Configure(EntityTypeBuilder<Activity> builder)
    {
        builder
            .HasNoKey()
            .ToTable("ACTIVITY");

        builder.Property(e => e.DateIn)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("DATE_IN");

        builder.Property(e => e.DateOut)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("DATE_OUT");

        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");

        builder.Property(e => e.Logoutcode)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("LOGOUTCODE");

        builder.Property(e => e.Userid)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("USERID");
    }
}
