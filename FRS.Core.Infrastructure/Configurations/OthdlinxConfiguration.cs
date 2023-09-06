using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class OthdlinxConfiguration : IEntityTypeConfiguration<Othdlinx>
    {
        public void Configure(EntityTypeBuilder<Othdlinx> builder)
        {
            builder
                .HasNoKey()
                .ToTable("OTHDLINX");

            builder.Property(e => e.Desc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.NoRecord)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NO_RECORD");
            builder.Property(e => e.YesRecord)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("YES_RECORD");

        }
    }
}