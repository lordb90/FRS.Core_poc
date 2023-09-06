using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class VmtchlogConfiguration : IEntityTypeConfiguration<Vmtchlog>
    {
        public void Configure(EntityTypeBuilder<Vmtchlog> builder)
        {
            builder
                .HasNoKey()
                .ToTable("VMTCHLOG");

            builder.Property(e => e.Date)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DATE");
            builder.Property(e => e.Details)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DETAILS");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Name)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAME");
            builder.Property(e => e.Type)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPE");
            builder.Property(e => e.Weborder)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("WEBORDER");

        }
    }
}