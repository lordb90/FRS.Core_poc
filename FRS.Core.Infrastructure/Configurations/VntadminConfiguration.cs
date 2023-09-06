using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class VntadminConfiguration : IEntityTypeConfiguration<Vntadmin>
    {
        public void Configure(EntityTypeBuilder<Vntadmin> builder)
        {
            builder
                .HasNoKey()
                .ToTable("VNTADMIN");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.RTrace)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("R_TRACE_");
            builder.Property(e => e.ResCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_CODE");
            builder.Property(e => e.Userid)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERID");
            builder.Property(e => e.Username)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERNAME");
            builder.Property(e => e.WebPw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEB_PW");

        }
    }
}