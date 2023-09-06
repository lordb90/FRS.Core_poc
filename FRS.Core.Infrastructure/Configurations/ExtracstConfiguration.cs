using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class ExtracstConfiguration : IEntityTypeConfiguration<Extracst>
    {
        public void Configure(EntityTypeBuilder<Extracst> builder)
        {
            builder
                .HasNoKey()
                .ToTable("EXTRACST");

            builder.Property(e => e.Amount)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("AMOUNT");
            builder.Property(e => e.Desc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");

        }
    }
}