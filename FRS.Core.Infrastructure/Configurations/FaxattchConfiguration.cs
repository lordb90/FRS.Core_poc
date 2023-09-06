using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class FaxattchConfiguration : IEntityTypeConfiguration<Faxattch>
    {
        public void Configure(EntityTypeBuilder<Faxattch> builder)
        {
            builder.HasNoKey()
                .ToTable("FAXATTCH");

            builder.Property(e => e.Faxid)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("FAXID");
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
        }
    }
}