using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class IccodesCaConfiguration : IEntityTypeConfiguration<IccodesCa>
    {
        public void Configure(EntityTypeBuilder<IccodesCa> builder)
        {
            builder
                .HasNoKey()
                .ToTable("ICCODES_CA");

            builder.Property(e => e.Code)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CODE");
            builder.Property(e => e.Desc)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");

        }
    }
}