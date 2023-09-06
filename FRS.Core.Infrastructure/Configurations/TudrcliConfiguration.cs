using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class TudrcliConfiguration : IEntityTypeConfiguration<Tudrcli>
    {
        public void Configure(EntityTypeBuilder<Tudrcli> builder)
        {
            builder
                .HasNoKey()
                .ToTable("TUDRCLI");

            builder.Property(e => e.Autoasgndr)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("AUTOASGNDR");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Createmvr)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("CREATEMVR");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Lastemail)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LASTEMAIL");
            builder.Property(e => e.TdrEmail)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TDR_EMAIL");
            builder.Property(e => e.TdrFee)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("TDR_FEE");
            builder.Property(e => e.TdraFee)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("TDRA_FEE");
            builder.Property(e => e.Tdrautogen).HasColumnName("TDRAUTOGEN");
            builder.Property(e => e.Tdrbillper)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("TDRBILLPER");
            builder.Property(e => e.Tdremlmsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TDREMLMSG");

        }
    }
}