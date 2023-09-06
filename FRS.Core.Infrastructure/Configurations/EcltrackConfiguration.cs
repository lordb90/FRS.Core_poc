using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class EcltrackConfiguration : IEntityTypeConfiguration<Ecltrack>
    {
        public void Configure(EntityTypeBuilder<Ecltrack> builder)
        {
            builder
                .HasNoKey()
                .ToTable("ECLTRACK");

            builder.Property(e => e.HttpUser)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HTTP_USER");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.LocalAddr)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCAL_ADDR");
            builder.Property(e => e.Logdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LOGDATE");
            builder.Property(e => e.Logsuccess)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOGSUCCESS");
            builder.Property(e => e.Logtime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOGTIME");
            builder.Property(e => e.Logurl)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOGURL");
            builder.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PASSWORD");
            builder.Property(e => e.RemoteAdd)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REMOTE_ADD");
            builder.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERNAME");

        }
    }
}