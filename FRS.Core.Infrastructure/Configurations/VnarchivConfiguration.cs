using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class VnarchivConfiguration : IEntityTypeConfiguration<Vnarchiv>
    {
        public void Configure(EntityTypeBuilder<Vnarchiv> builder)
        {
            builder
                .HasNoKey()
                .ToTable("VNARCHIV");

            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Name)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAME");
            builder.Property(e => e.ReqDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("REQ_DATE");
            builder.Property(e => e.ReqTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ_TIME");
            builder.Property(e => e.Sdesc)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SDESC");
            builder.Property(e => e.Type)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPE");
            builder.Property(e => e.Vrcd)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VRCD");
            builder.Property(e => e.WcompDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WCOMP_DATE");
            builder.Property(e => e.WcompTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WCOMP_TIME");
            builder.Property(e => e.WebDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WEB_DATE");
            builder.Property(e => e.WebTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEB_TIME");
            builder.Property(e => e.Weborder)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("WEBORDER");
            builder.Property(e => e.Wresults)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WRESULTS");
        }
    }
}