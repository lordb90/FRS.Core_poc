using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class RptScrConfiguration : IEntityTypeConfiguration<RptScr>
    {
        public void Configure(EntityTypeBuilder<RptScr> builder)
        {
            builder
                .HasNoKey()
                .ToTable("RPT_SCR");

            builder.Property(e => e.DataType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DATA_TYPE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Mediatype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MEDIATYPE");
            builder.Property(e => e.NodeName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NODE_NAME");
            builder.Property(e => e.Precision)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("PRECISION");
            builder.Property(e => e.Primary)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PRIMARY");
            builder.Property(e => e.Qualifier).HasColumnName("QUALIFIER");
            builder.Property(e => e.RefType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REF_TYPE");
            builder.Property(e => e.Reference)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REFERENCE");
            builder.Property(e => e.Screentype)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SCREENTYPE");
            builder.Property(e => e.Sequence).HasColumnName("SEQUENCE");
            builder.Property(e => e.Special)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SPECIAL");
            builder.Property(e => e.SubNode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUB_NODE");

        }
    }
}