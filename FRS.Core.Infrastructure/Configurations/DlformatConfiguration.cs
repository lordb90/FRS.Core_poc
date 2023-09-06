using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class DlformatConfiguration : IEntityTypeConfiguration<Dlformat>
    {
        public void Configure(EntityTypeBuilder<Dlformat> builder)
        {
            builder.HasNoKey()
                .ToTable("DLFORMAT");

            builder.Property(e => e.BtcCutoff)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BTC_CUTOFF");
            builder.Property(e => e.BtcRetryd)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BTC_RETRYD");
            builder.Property(e => e.BtcRetryt)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BTC_RETRYT");
            builder.Property(e => e.BtcTurnar)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BTC_TURNAR");
            builder.Property(e => e.ByYears).HasColumnName("BY_YEARS");
            builder.Property(e => e.C01)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C02)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C03)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C04)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C05)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C06)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C07)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C08)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C09)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C10)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C11)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C12)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C13)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C14)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C15)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C16)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C17)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C18)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C19)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.C20)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.Crule1)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRULE1");
            builder.Property(e => e.Crule2)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRULE2");
            builder.Property(e => e.Ctext)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CTEXT");
            builder.Property(e => e.HiYears).HasColumnName("HI_YEARS");
            builder.Property(e => e.Hrange)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("HRANGE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.LoYears).HasColumnName("LO_YEARS");
            builder.Property(e => e.Lrange)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("LRANGE");
            builder.Property(e => e.NumTypes).HasColumnName("NUM_TYPES");
            builder.Property(e => e.Req1field1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ1FIELD1");
            builder.Property(e => e.Req1field2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ1FIELD2");
            builder.Property(e => e.Req1field3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ1FIELD3");
            builder.Property(e => e.Req1field4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ1FIELD4");
            builder.Property(e => e.Req1field5)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ1FIELD5");
            builder.Property(e => e.Req1field6)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ1FIELD6");
            builder.Property(e => e.Req1field7)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ1FIELD7");
            builder.Property(e => e.Req2field1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ2FIELD1");
            builder.Property(e => e.Req2field2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ2FIELD2");
            builder.Property(e => e.Req2field3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ2FIELD3");
            builder.Property(e => e.Req2field4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ2FIELD4");
            builder.Property(e => e.Req2field5)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ2FIELD5");
            builder.Property(e => e.Req2field6)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ2FIELD6");
            builder.Property(e => e.Req2field7)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ2FIELD7");
            builder.Property(e => e.Req3field1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ3FIELD1");
            builder.Property(e => e.Req3field2)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ3FIELD2");
            builder.Property(e => e.Req3field3)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ3FIELD3");
            builder.Property(e => e.Req3field4)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ3FIELD4");
            builder.Property(e => e.Req3field5)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ3FIELD5");
            builder.Property(e => e.Req3field6)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ3FIELD6");
            builder.Property(e => e.Req3field7)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ3FIELD7");
            builder.Property(e => e.St)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ST");
            builder.Property(e => e.StBatch).HasColumnName("ST_BATCH");
            builder.Property(e => e.StMvr).HasColumnName("ST_MVR");
            builder.Property(e => e.StUnique).HasColumnName("ST_UNIQUE");
            builder.Property(e => e.State)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.TypeReq1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPE_REQ1");
            builder.Property(e => e.TypeReq2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPE_REQ2");
            builder.Property(e => e.TypeReq3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPE_REQ3");
            builder.Property(e => e.VerNum)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("VER_NUM");

        }
    }
}