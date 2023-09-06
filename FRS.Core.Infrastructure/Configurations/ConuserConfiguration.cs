using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class ConuserConfiguration : IEntityTypeConfiguration<Conuser>
{
    public void Configure(EntityTypeBuilder<Conuser> builder)
    {
        builder.HasNoKey()
            .ToTable("CONUSERS");

        builder.Property(e => e.AvgCall)
            .HasColumnType("numeric(4, 0)")
            .HasColumnName("AVG_CALL");
        builder.Property(e => e.FcId)
            .HasMaxLength(12)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("FC_ID");
        builder.Property(e => e.Fusercall)
            .HasColumnType("numeric(8, 0)")
            .HasColumnName("FUSERCALL");
        builder.Property(e => e.Fusertype)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("FUSERTYPE");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.LastCall)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("LAST_CALL");
        builder.Property(e => e.LastVer)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("LAST_VER");
        builder.Property(e => e.SiteName)
            .HasMaxLength(40)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SITE_NAME");
    }
}