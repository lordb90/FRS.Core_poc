using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class TudrcodeConfiguration : IEntityTypeConfiguration<Tudrcode>
    {
        public void Configure(EntityTypeBuilder<Tudrcode> builder)
        {
            builder
                .HasNoKey()
                .ToTable("TUDRCODES");

            builder.Property(e => e.Bureau)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BUREAU");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Industry)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INDUSTRY");
            builder.Property(e => e.Licensekey)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LICENSEKEY");
            builder.Property(e => e.Majoronly).HasColumnName("MAJORONLY");
            builder.Property(e => e.Newlicense).HasColumnName("NEWLICENSE");
            builder.Property(e => e.Notes)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NOTES");
            builder.Property(e => e.Passwrd)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PASSWRD");
            builder.Property(e => e.ProdCode)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROD_CODE");
            builder.Property(e => e.Siteshort)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SITESHORT");
            builder.Property(e => e.SubBureau)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUB_BUREAU");
            builder.Property(e => e.SubCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUB_CODE");
            builder.Property(e => e.Testing).HasColumnName("TESTING");
            builder.Property(e => e.Userrefnum)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERREFNUM");
        }
    }
}