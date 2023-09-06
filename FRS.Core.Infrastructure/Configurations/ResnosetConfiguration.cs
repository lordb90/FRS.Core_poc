using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class ResnosetConfiguration : IEntityTypeConfiguration<Resnoset>
    {
        public void Configure(EntityTypeBuilder<Resnoset> builder)
        {
            builder
                .HasNoKey()
                .ToTable("RESNOSET");

            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.DelDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DEL_DATE");
            builder.Property(e => e.DelId)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DEL_ID");
            builder.Property(e => e.DelTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DEL_TIME");
            builder.Property(e => e.Device)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DEVICE");
            builder.Property(e => e.EmailIt).HasColumnName("EMAIL_IT");
            builder.Property(e => e.FaxIt).HasColumnName("FAX_IT");
            builder.Property(e => e.Fullname)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FULLNAME");
            builder.Property(e => e.FullyComp).HasColumnName("FULLY_COMP");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.PrntIt).HasColumnName("PRNT_IT");
            builder.Property(e => e.RecDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("REC_DATE");
            builder.Property(e => e.RecTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REC_TIME");
            builder.Property(e => e.WebIt).HasColumnName("WEB_IT");

        }
    }
}