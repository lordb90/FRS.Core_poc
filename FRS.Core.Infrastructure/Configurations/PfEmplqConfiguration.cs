using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class PfEmplqConfiguration : IEntityTypeConfiguration<PfEmplq>
    {
        public void Configure(EntityTypeBuilder<PfEmplq> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PF_EMPLQ");

            builder.Property(e => e.Answer)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ANSWER");
            builder.Property(e => e.Key)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("KEY");
            builder.Property(e => e.Question)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QUESTION");

        }
    }
}