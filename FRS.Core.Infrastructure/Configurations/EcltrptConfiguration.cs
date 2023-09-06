using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class EcltrptConfiguration : IEntityTypeConfiguration<Ecltrpt>
    {
        public void Configure(EntityTypeBuilder<Ecltrpt> builder)
        {
            builder
                .HasNoKey()
                .ToTable("ECLTRPTS");

            builder.Property(e => e.AttView)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATT_VIEW");
            builder.Property(e => e.Attach)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATTACH");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Dtsent)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DTSENT");
            builder.Property(e => e.Group)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("GROUP");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Link)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LINK");
            builder.Property(e => e.Mstrgroup)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MSTRGROUP");
            builder.Property(e => e.Rdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("RDATE");
            builder.Property(e => e.Rdesc)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RDESC");
            builder.Property(e => e.Rdetails)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RDETAILS");
            builder.Property(e => e.Remdttime)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("REMDTTIME");
            builder.Property(e => e.Remfromweb)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REMFROMWEB");
            builder.Property(e => e.Remusrname)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REMUSRNAME");
            builder.Property(e => e.Sent2web).HasColumnName("SENT2WEB");
            builder.Property(e => e.ToRemove).HasColumnName("TO_REMOVE");
            builder.Property(e => e.Viewed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VIEWED");

        }
    }
}