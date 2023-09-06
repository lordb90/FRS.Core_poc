using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class LucivtypConfiguration : IEntityTypeConfiguration<Lucivtyp>
    {
        public void Configure(EntityTypeBuilder<Lucivtyp> builder)
        {
            builder
                .HasNoKey()
                .ToTable("LUCIVTYP");

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