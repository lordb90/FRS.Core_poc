using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class UsedFileConfiguration : IEntityTypeConfiguration<UsedFile>
    {
        public void Configure(EntityTypeBuilder<UsedFile> builder)
        {
            builder
                .HasNoKey()
                .ToTable("USED_FILES");

            builder.Property(e => e.Filename)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILENAME");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");

        }
    }
}