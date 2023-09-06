using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class I3scrnQConfiguration : IEntityTypeConfiguration<I3scrnQ>
    {
        public void Configure(EntityTypeBuilder<I3scrnQ> builder)
        {
            builder
                .HasNoKey()
                .ToTable("I3SCRN_Q");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Providrkey)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROVIDRKEY");
            builder.Property(e => e.SubjKey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("SUBJ_KEY");

        }
    }
}