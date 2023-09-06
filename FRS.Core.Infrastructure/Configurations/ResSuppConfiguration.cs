using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class ResSuppConfiguration : IEntityTypeConfiguration<ResSupp>
    {
        public void Configure(EntityTypeBuilder<ResSupp> builder)
        {
            builder
                .HasNoKey()
                .ToTable("RES_SUPP");

            builder.Property(e => e.Aka)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AKA");
            builder.Property(e => e.County)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNTY");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.ResCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_CODE");
            builder.Property(e => e.ResWhen)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("RES_WHEN");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.SubjName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBJ_NAME");

        }
    }
}