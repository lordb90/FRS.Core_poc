using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class PfWkcmpConfiguration : IEntityTypeConfiguration<PfWkcmp>
    {
        public void Configure(EntityTypeBuilder<PfWkcmp> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PF_WKCMP");

            builder.Property(e => e.Fromdate)
                .HasColumnType("datetime")
                .HasColumnName("FROMDATE");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.PfKey)
                .ValueGeneratedOnAdd()
                .HasColumnName("PF_KEY");
            builder.Property(e => e.ResStat)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("RES_STAT");
            builder.Property(e => e.ResWhen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("RES_WHEN");
            builder.Property(e => e.Todate)
                .HasColumnType("datetime")
                .HasColumnName("TODATE");
            builder.Property(e => e.Wcstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("WCSTATE");

        }
    }
}