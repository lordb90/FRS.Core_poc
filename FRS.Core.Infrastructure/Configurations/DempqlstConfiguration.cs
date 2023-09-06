using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class DempqlstConfiguration : IEntityTypeConfiguration<Dempqlst>
    {
        public void Configure(EntityTypeBuilder<Dempqlst> builder)
        {
            builder.HasNoKey()
                .ToTable("DEMPQLST");

            builder.Property(e => e.Ans1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ANS1");
            builder.Property(e => e.Ans2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ANS2");
            builder.Property(e => e.Ans3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ANS3");
            builder.Property(e => e.Ans4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ANS4");
            builder.Property(e => e.Ans5)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ANS5");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.NbrAns)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("NBR_ANS");
            builder.Property(e => e.Question)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QUESTION");
            builder.Property(e => e.ShortDesc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SHORT_DESC");
        }
    }
}