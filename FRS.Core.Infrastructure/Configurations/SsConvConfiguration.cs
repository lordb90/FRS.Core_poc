using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class SsConvConfiguration : IEntityTypeConfiguration<SsConv>
    {
        public void Configure(EntityTypeBuilder<SsConv> builder)
        {
            builder
                .HasNoKey()
                .ToTable("SS_CONV");

            builder.Property(e => e.Char2)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CHAR2");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Num)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NUM");

        }
    }
}