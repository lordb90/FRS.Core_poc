using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class RecsubjConfiguration : IEntityTypeConfiguration<Recsubj>
    {
        public void Configure(EntityTypeBuilder<Recsubj> builder)
        {
            builder
                .HasNoKey()
                .ToTable("RECSUBJ");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Lastmodify)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LASTMODIFY");
            builder.Property(e => e.SubjKey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("SUBJ_KEY");
            builder.Property(e => e.SubjName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBJ_NAME");
            builder.Property(e => e.Userid)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERID");

        }
    }
}