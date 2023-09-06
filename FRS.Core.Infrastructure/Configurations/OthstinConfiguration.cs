using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class OthstinConfiguration : IEntityTypeConfiguration<Othstin>
    {
        public void Configure(EntityTypeBuilder<Othstin> builder)
        {
            builder
                .HasNoKey()
                .ToTable("OTHSTINS");

            builder.Property(e => e.Desc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Instruct)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INSTRUCT");
            builder.Property(e => e.LastMod)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LAST_MOD");
            builder.Property(e => e.WebForm)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEB_FORM");
            builder.Property(e => e.WebMod)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WEB_MOD");

        }
    }
}