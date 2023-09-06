using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class Dict2Configuration : IEntityTypeConfiguration<Dict2>
    {
        public void Configure(EntityTypeBuilder<Dict2> builder)
        {
            builder
                .HasNoKey()
                .ToTable("DICT2");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Word)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WORD");
        }
    }
}