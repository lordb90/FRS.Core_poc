using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class RelformConfiguration : IEntityTypeConfiguration<Relform>
    {
        public void Configure(EntityTypeBuilder<Relform> builder)
        {
            builder
                .HasNoKey()
                .ToTable("RELFORMS");

            builder.Property(e => e.DelFile).HasColumnName("DEL_FILE");
            builder.Property(e => e.DelRec).HasColumnName("DEL_REC");
            builder.Property(e => e.FormDesc)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FORM_DESC");
            builder.Property(e => e.FormFile)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FORM_FILE");
            builder.Property(e => e.FormName)
                .HasMaxLength(120)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FORM_NAME");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Push2web).HasColumnName("PUSH2WEB");
            builder.Property(e => e.RelCode)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REL_CODE");
            builder.Property(e => e.RelCounty)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REL_COUNTY");
            builder.Property(e => e.RelDesc)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REL_DESC");
            builder.Property(e => e.RelState)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REL_STATE");
            builder.Property(e => e.RelType)
                .HasMaxLength(38)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REL_TYPE");

        }
    }
}