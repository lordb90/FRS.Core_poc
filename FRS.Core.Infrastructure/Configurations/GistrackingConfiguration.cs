using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class GistrackingConfiguration : IEntityTypeConfiguration<Gistracking>
    {
        public void Configure(EntityTypeBuilder<Gistracking> builder)
        {
            builder
                .HasNoKey()
                .ToTable("GISTRACKING");

            builder.Property(e => e.County)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNTY");
            builder.Property(e => e.DtReceive)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DT_RECEIVE");
            builder.Property(e => e.DtReturn)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DT_RETURN");
            builder.Property(e => e.Familyname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FAMILYNAME");
            builder.Property(e => e.Givenname)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("GIVENNAME");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Idvalue)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IDVALUE");
            builder.Property(e => e.Middlename)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MIDDLENAME");
            builder.Property(e => e.Returned).HasColumnName("RETURNED");
            builder.Property(e => e.Ssn)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.Uniqueid)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("UNIQUEID");

        }
    }
}