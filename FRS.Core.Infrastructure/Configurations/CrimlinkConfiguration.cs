using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class CrimlinkConfiguration : IEntityTypeConfiguration<Crimlink>
    {
        public void Configure(EntityTypeBuilder<Crimlink> builder)
        {
            builder.HasNoKey()
                .ToTable("CRIMLINKS");

            builder.Property(e => e.Desc)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Link)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LINK");
        }
    }
}