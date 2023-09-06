using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class DisclStConfiguration : IEntityTypeConfiguration<DisclSt>
    {
        public void Configure(EntityTypeBuilder<DisclSt> builder)
        {
            builder.HasNoKey()
                .ToTable("DISCL_ST");

            builder.Property(e => e.Clientflag).HasColumnName("CLIENTFLAG");
            builder.Property(e => e.DisclBody)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DISCL_BODY");
            builder.Property(e => e.FontSize)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("FONT_SIZE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.LastUpd)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LAST_UPD");
            builder.Property(e => e.LogoFlag).HasColumnName("LOGO_FLAG");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.SubjFlag).HasColumnName("SUBJ_FLAG");
        }
    }
}