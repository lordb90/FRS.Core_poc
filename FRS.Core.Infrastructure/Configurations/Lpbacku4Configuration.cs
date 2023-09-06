using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Core.Infrastructure.Configurations
{
    public class Lpbacku4Configuration : IEntityTypeConfiguration<Lpbacku4>
    {
        public void Configure(EntityTypeBuilder<Lpbacku4> builder)
        {
            builder
                .HasNoKey()
                .ToTable("LPBACKU4");

            builder.Property(e => e.Compressed).HasColumnName("COMPRESSED");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.SsnRes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN_RES");
            builder.Property(e => e.Uncompsize).HasColumnName("UNCOMPSIZE");
        }
    }
}
