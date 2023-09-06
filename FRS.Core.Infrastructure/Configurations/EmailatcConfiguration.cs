using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class EmailatcConfiguration : IEntityTypeConfiguration<Emailatc>
    {
        public void Configure(EntityTypeBuilder<Emailatc> builder)
        {
            builder
                .HasNoKey()
                .ToTable("EMAILATC");

            builder.Property(e => e.Descriptn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESCRIPTN");
            builder.Property(e => e.EmailId)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("EMAIL_ID");
            builder.Property(e => e.Filename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILENAME");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Location)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCATION");
            builder.Property(e => e.OrigFname)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ORIG_FNAME");
        }
    }
}