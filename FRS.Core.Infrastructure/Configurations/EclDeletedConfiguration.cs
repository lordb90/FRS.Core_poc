using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class EclDeletedConfiguration : IEntityTypeConfiguration<EclDeleted>
    {
        public void Configure(EntityTypeBuilder<EclDeleted> builder)
        {
            builder.HasNoKey()
                .ToTable("ECL_DELETED");

            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Deleted)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DELETED");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Viewed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VIEWED");
        }
    }
}