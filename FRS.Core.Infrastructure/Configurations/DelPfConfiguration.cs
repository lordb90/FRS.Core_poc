using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class DelPfConfiguration : IEntityTypeConfiguration<DelPf>
    {
        public void Configure(EntityTypeBuilder<DelPf> builder)
        {
            builder.HasNoKey()
                .ToTable("DEL_PFS");

            builder.Property(e => e.Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Lastmodify)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LASTMODIFY");
            builder.Property(e => e.PfRec)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("PF_REC");
            builder.Property(e => e.Type)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPE");
        }
    }
}