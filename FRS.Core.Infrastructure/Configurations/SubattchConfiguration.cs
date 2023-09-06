using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class SubattchConfiguration : IEntityTypeConfiguration<Subattch>
    {
        public void Configure(EntityTypeBuilder<Subattch> builder)
        {
            builder
                .HasNoKey()
                .ToTable("SUBATTCH");

            builder.Property(e => e.Archived).HasColumnName("ARCHIVED");
            builder.Property(e => e.AttachDoc)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATTACH_DOC");
            builder.Property(e => e.Attachdttm)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("ATTACHDTTM");
            builder.Property(e => e.DelFile).HasColumnName("DEL_FILE");
            builder.Property(e => e.Descriptn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESCRIPTN");
            builder.Property(e => e.EmailId)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("EMAIL_ID");
            builder.Property(e => e.Filename)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILENAME");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Internal).HasColumnName("INTERNAL");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Location)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCATION");
            builder.Property(e => e.Post2email).HasColumnName("POST2EMAIL");
            builder.Property(e => e.Post2emldt)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("POST2EMLDT");
            builder.Property(e => e.Post2web).HasColumnName("POST2WEB");
            builder.Property(e => e.Post2webdt)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("POST2WEBDT");
            builder.Property(e => e.Push2web).HasColumnName("PUSH2WEB");
            builder.Property(e => e.Weborder)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("WEBORDER");
            builder.Property(e => e.Whoattach)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WHOATTACH");
            builder.Property(e => e.Zipfile)
                .HasMaxLength(80)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ZIPFILE");
        }
    }
}