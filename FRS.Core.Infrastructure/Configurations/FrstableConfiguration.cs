using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class FrstableConfiguration : IEntityTypeConfiguration<Frstable>
    {
        public void Configure(EntityTypeBuilder<Frstable> builder)
        {
            builder
                .HasNoKey()
                .ToTable("FRSTABLES");

            builder.Property(e => e.Checkifc).HasColumnName("CHECKIFC");
            builder.Property(e => e.Cnt4thermo).HasColumnName("CNT4THERMO");
            builder.Property(e => e.Descriptn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESCRIPTN");
            builder.Property(e => e.Fptexists).HasColumnName("FPTEXISTS");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Indxcolate)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INDXCOLATE");
            builder.Property(e => e.Indxfilter)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INDXFILTER");
            builder.Property(e => e.Indxkey)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INDXKEY");
            builder.Property(e => e.Indxorder)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INDXORDER");
            builder.Property(e => e.Indxtag)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INDXTAG");
            builder.Property(e => e.Indxtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INDXTYPE");
            builder.Property(e => e.Opt4bkup).HasColumnName("OPT4BKUP");
            builder.Property(e => e.Tablename)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TABLENAME");

        }
    }
}