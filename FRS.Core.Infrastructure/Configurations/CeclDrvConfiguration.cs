using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class CeclDrvConfiguration : IEntityTypeConfiguration<CeclDrv>
{
    public void Configure(EntityTypeBuilder<CeclDrv> builder)
    {
        builder
            .HasNoKey()
            .ToTable("CECL_DRV");

        builder.Property(e => e.Active).HasColumnName("ACTIVE");
        builder.Property(e => e.Caution)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("CAUTION");
        builder.Property(e => e.Desc)
            .HasMaxLength(40)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DESC");
        builder.Property(e => e.DispOrder)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("DISP_ORDER");
        builder.Property(e => e.Greenbar)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("GREENBAR");
        builder.Property(e => e.Help)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("HELP");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.Position)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("POSITION");
        builder.Property(e => e.ReqCode)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("REQ_CODE");
    }
}