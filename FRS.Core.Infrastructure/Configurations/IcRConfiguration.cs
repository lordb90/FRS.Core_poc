using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class IcRConfiguration : IEntityTypeConfiguration<IcR>
    {
        public void Configure(EntityTypeBuilder<IcR> builder)
        {
            builder
                .HasNoKey()
                .ToTable("IC_RS");

            builder.Property(e => e.Fullname)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FULLNAME");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Setup)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("SETUP");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");

        }
    }
}