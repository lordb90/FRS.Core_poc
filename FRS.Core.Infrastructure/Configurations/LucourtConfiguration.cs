using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class LucourtConfiguration : IEntityTypeConfiguration<Lucourt>
    {
        public void Configure(EntityTypeBuilder<Lucourt> builder)
        {
            builder
                .HasNoKey()
                .ToTable("LUCOURT");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Text)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TEXT");

        }
    }
}