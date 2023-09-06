using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WebattchConfiguration : IEntityTypeConfiguration<Webattch>
    {
        public void Configure(EntityTypeBuilder<Webattch> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WEBATTCH");

            builder.Property(e => e.Archived).HasColumnName("ARCHIVED");
            builder.Property(e => e.Attachdttm)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("ATTACHDTTM");
            builder.Property(e => e.Cc).HasColumnName("CC");
            builder.Property(e => e.Descriptn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESCRIPTN");
            builder.Property(e => e.Filename)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILENAME");
            builder.Property(e => e.Fx).HasColumnName("FX");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Location)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCATION");
            builder.Property(e => e.Postdttm)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("POSTDTTM");
            builder.Property(e => e.Posted).HasColumnName("POSTED");
            builder.Property(e => e.Vr).HasColumnName("VR");
            builder.Property(e => e.Weborder)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("WEBORDER");
            builder.Property(e => e.Whoattach)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WHOATTACH");
            builder.Property(e => e.Wk).HasColumnName("WK");
            builder.Property(e => e.Zipfile)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ZIPFILE");

        }
    }
}