using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class DlxakabillConfiguration : IEntityTypeConfiguration<Dlxakabill>
    {
        public void Configure(EntityTypeBuilder<Dlxakabill> builder)
        {
            builder.HasNoKey()
                .ToTable("DLXAKABILL");

            builder.Property(e => e.AddLoc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADD_LOC");
            builder.Property(e => e.ChrgItem).HasColumnName("CHRG_ITEM");
            builder.Property(e => e.ChrgPkg).HasColumnName("CHRG_PKG");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Norectxt)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NORECTXT");
            builder.Property(e => e.OrderAka).HasColumnName("ORDER_AKA");
            builder.Property(e => e.OstDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OST_DESC");
            builder.Property(e => e.Yesrectxt)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("YESRECTXT");
        }
    }
}