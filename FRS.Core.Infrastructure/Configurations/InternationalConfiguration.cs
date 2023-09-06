using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class InternationalConfiguration : IEntityTypeConfiguration<International>
    {
        public void Configure(EntityTypeBuilder<International> builder)
        {
            builder
                .HasNoKey()
                .ToTable("INTERNATIONAL");

            builder.Property(e => e.Atweb)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATWEB");
            builder.Property(e => e.Country)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNTRY");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.IntSri)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_SRI");

        }
    }
}