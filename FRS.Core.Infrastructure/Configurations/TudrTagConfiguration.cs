using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class TudrTagConfiguration : IEntityTypeConfiguration<TudrTag>
    {
        public void Configure(EntityTypeBuilder<TudrTag> builder)
        {
            builder
                .HasNoKey()
                .ToTable("TUDR_TAGS");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Tagdesc)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TAGDESC");
            builder.Property(e => e.Tagdisplay).HasColumnName("TAGDISPLAY");
            builder.Property(e => e.Tagname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TAGNAME");

        }
    }
}