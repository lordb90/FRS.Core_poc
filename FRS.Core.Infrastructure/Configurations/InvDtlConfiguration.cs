using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class InvDtlConfiguration : IEntityTypeConfiguration<InvDtl>
    {
        public void Configure(EntityTypeBuilder<InvDtl> builder)
        {
            builder
                .HasNoKey()
                .ToTable("INV_DTLS");

            builder.Property(e => e.BasisDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("BASIS_DATE");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.DtlInfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DTL_INFO");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Invnum)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INVNUM");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Lpbkup).HasColumnName("LPBKUP");
            builder.Property(e => e.SubjName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBJ_NAME");

        }
    }
}