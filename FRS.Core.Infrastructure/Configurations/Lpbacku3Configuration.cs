using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Core.Infrastructure.Configurations
{
    public class Lpbacku3Configuration : IEntityTypeConfiguration<Lpbacku3>
    {
        public void Configure(EntityTypeBuilder<Lpbacku3> builder)
        {
            builder
                .HasNoKey()
                .ToTable("LPBACKU3");

            builder.Property(e => e.Compressed).HasColumnName("COMPRESSED");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.SsnRsumm)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN_RSUMM");
            builder.Property(e => e.Uncompsize).HasColumnName("UNCOMPSIZE");
        }
    }
}
