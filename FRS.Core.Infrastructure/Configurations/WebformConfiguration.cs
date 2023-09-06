using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WebformConfiguration : IEntityTypeConfiguration<Webform>
    {
        public void Configure(EntityTypeBuilder<Webform> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WEBFORMS");

            builder.Property(e => e.Disporder)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("DISPORDER");
            builder.Property(e => e.Formdesc)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FORMDESC");
            builder.Property(e => e.Formlink)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FORMLINK");
            builder.Property(e => e.Formname)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FORMNAME");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Send2web)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEND2WEB");

        }
    }
}