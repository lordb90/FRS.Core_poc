using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class LudispConfiguration : IEntityTypeConfiguration<Ludisp>
    {
        public void Configure(EntityTypeBuilder<Ludisp> builder)
        {
            builder
                .HasNoKey()
                .ToTable("LUDISP");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Text)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TEXT");

        }
    }
}