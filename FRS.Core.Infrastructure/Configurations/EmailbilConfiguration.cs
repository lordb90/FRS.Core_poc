using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class EmailbilConfiguration : IEntityTypeConfiguration<Emailbil>
    {
        public void Configure(EntityTypeBuilder<Emailbil> builder)
        {
            builder
                .HasNoKey()
                .ToTable("EMAILBIL");

            builder.Property(e => e.EmSent).HasColumnName("EM_SENT");
            builder.Property(e => e.EmailId)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("EMAIL_ID");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.PdfName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PDF_NAME");
            builder.Property(e => e.WebPost).HasColumnName("WEB_POST");
            builder.Property(e => e.WebSent).HasColumnName("WEB_SENT");
        }
    }
}