using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class DefdiscrConfiguration : IEntityTypeConfiguration<Defdiscr>
    {
        public void Configure(EntityTypeBuilder<Defdiscr> builder)
        {
            builder.HasNoKey()
                .ToTable("DEFDISCR");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Reason)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REASON");
        }
    }
}