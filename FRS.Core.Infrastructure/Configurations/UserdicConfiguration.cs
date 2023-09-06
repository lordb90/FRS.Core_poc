using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class UserdicConfiguration : IEntityTypeConfiguration<Userdic>
    {
        public void Configure(EntityTypeBuilder<Userdic> builder)
        {
            builder
                .HasNoKey()
                .ToTable("USERDIC");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Word)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WORD");

        }
    }
}