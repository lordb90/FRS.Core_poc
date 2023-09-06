using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Core.Infrastructure.Configurations
{
    public class Lpbacku2Configuration : IEntityTypeConfiguration<Lpbacku2>
    {
        public void Configure(EntityTypeBuilder<Lpbacku2> builder)
        {
            builder
                .HasNoKey()
                .ToTable("LPBACKU2");

            builder.Property(e => e.Compressed).HasColumnName("COMPRESSED");
            builder.Property(e => e.CredRes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRED_RES");
            builder.Property(e => e.EiComprsd).HasColumnName("EI_COMPRSD");
            builder.Property(e => e.EiUncmpsz).HasColumnName("EI_UNCMPSZ");
            builder.Property(e => e.ExtraInfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXTRA_INFO");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Uncompsize).HasColumnName("UNCOMPSIZE");
        }
    }
}
