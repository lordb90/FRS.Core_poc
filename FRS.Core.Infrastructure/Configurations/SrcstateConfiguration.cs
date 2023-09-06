using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class SrcstateConfiguration : IEntityTypeConfiguration<Srcstate>
    {
        public void Configure(EntityTypeBuilder<Srcstate> builder)
        {
            builder
                .HasNoKey()
                .ToTable("SRCSTATE");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");

        }
    }
}