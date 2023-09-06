using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class GlobkeyConfiguration : IEntityTypeConfiguration<Globkey>
    {
        public void Configure(EntityTypeBuilder<Globkey> builder)
        {
            builder
                .HasNoKey()
                .ToTable("GLOBKEYS");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Keyname)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("KEYNAME");
            builder.Property(e => e.Keyvaluec)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("KEYVALUEC");
            builder.Property(e => e.Keyvaluen)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("KEYVALUEN");
            builder.Property(e => e.Lockbyuser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCKBYUSER");
            builder.Property(e => e.Lockdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LOCKDATE");

        }
    }
}