using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class OthstfrmConfiguration : IEntityTypeConfiguration<Othstfrm>
    {
        public void Configure(EntityTypeBuilder<Othstfrm> builder)
        {
            builder.HasNoKey()
                .ToTable("OTHSTFRM");

            builder.Property(e => e.Desc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
            builder.Property(e => e.Form)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FORM");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.LastMod)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LAST_MOD");

        }
    }
}