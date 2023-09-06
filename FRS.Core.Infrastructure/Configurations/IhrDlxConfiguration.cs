using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class IhrDlxConfiguration : IEntityTypeConfiguration<IhrDlx>
    {
        public void Configure(EntityTypeBuilder<IhrDlx> builder)
        {
            builder
                .HasNoKey()
                .ToTable("IHR_DLX");

            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.DateAdd)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DATE_ADD");
            builder.Property(e => e.Frsproduct)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FRSPRODUCT");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.OstDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OST_DESC");
            builder.Property(e => e.Reason)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REASON");
            builder.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATUS");
            builder.Property(e => e.SubjName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBJ_NAME");

        }
    }
}