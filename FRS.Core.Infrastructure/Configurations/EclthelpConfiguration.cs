using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class EclthelpConfiguration : IEntityTypeConfiguration<Eclthelp>
    {
        public void Configure(EntityTypeBuilder<Eclthelp> builder)
        {
            builder
                .HasNoKey()
                .ToTable("ECLTHELP");

            builder.Property(e => e.Content)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CONTENT");
            builder.Property(e => e.Desc)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
            builder.Property(e => e.HelpNbr)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("HELP_NBR");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Lastupdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LASTUPDATE");
            builder.Property(e => e.Lastuser)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LASTUSER");
            builder.Property(e => e.Title)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TITLE");
        }
    }
}