using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class VnattachConfiguration : IEntityTypeConfiguration<Vnattach>
    {
        public void Configure(EntityTypeBuilder<Vnattach> builder)
        {
            builder
                .HasNoKey()
                .ToTable("VNATTACH");

            builder.Property(e => e.Descriptn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESCRIPTN");
            builder.Property(e => e.Filename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILENAME");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Location)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCATION");
            builder.Property(e => e.WebStat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEB_STAT");
            builder.Property(e => e.Weborder)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("WEBORDER");
        }
    }
}