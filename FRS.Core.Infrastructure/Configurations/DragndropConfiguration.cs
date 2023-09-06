using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class DragndropConfiguration : IEntityTypeConfiguration<Dragndrop>
    {
        public void Configure(EntityTypeBuilder<Dragndrop> builder)
        {
            builder
                .HasNoKey()
                .ToTable("DRAGNDROP");

            builder.Property(e => e.Dragroup)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DRAGROUP");
            builder.Property(e => e.Dragtext)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DRAGTEXT");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
        }
    }
}