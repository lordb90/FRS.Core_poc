using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class ResBackConfiguration : IEntityTypeConfiguration<ResBack>
    {
        public void Configure(EntityTypeBuilder<ResBack> builder)
        {
            builder
                .HasNoKey()
                .ToTable("RES_BACK");

            builder.Property(e => e.Cmcv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CMCV");
            builder.Property(e => e.Cost)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("COST");
            builder.Property(e => e.County)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNTY");
            builder.Property(e => e.ExresCost)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("EXRES_COST");
            builder.Property(e => e.HowRemove)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HOW_REMOVE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.ResCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_CODE");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPE");
        }
    }
}