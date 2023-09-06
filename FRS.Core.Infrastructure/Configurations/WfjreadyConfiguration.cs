using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WfjreadyConfiguration : IEntityTypeConfiguration<Wfjready>
    {
        public void Configure(EntityTypeBuilder<Wfjready> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WFJREADY");

            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.IncCred).HasColumnName("INC_CRED");
            builder.Property(e => e.IncMvr).HasColumnName("INC_MVR");
            builder.Property(e => e.IncSsn).HasColumnName("INC_SSN");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.RrType)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("RR_TYPE");
            builder.Property(e => e.WfjPrint).HasColumnName("WFJ_PRINT");

        }
    }
}