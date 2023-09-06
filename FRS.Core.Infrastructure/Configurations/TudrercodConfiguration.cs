using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class TudrercodConfiguration : IEntityTypeConfiguration<Tudrercod>
    {
        public void Configure(EntityTypeBuilder<Tudrercod> builder)
        {
            builder
                .HasNoKey()
                .ToTable("TUDRERCODS");

            builder.Property(e => e.Codedesc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CODEDESC");
            builder.Property(e => e.Codenumber)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CODENUMBER");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");

        }
    }
}