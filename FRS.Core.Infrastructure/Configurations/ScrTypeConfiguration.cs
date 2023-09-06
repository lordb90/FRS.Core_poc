using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class ScrTypeConfiguration : IEntityTypeConfiguration<ScrType>
    {
        public void Configure(EntityTypeBuilder<ScrType> builder)
        {
            builder
                .HasNoKey()
                .ToTable("SCR_TYPE");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.ScreenCnt).HasColumnName("SCREEN_CNT");
            builder.Property(e => e.Screentype)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SCREENTYPE");
            builder.Property(e => e.Sequence).HasColumnName("SEQUENCE");

        }
    }
}