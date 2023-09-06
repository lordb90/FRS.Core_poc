using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class VcancelConfiguration : IEntityTypeConfiguration<Vcancel>
    {
        public void Configure(EntityTypeBuilder<Vcancel> builder)
        {
            builder
                .HasNoKey()
                .ToTable("VCANCEL");

            builder.Property(e => e.Done).HasColumnName("DONE");
            builder.Property(e => e.Empkey)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMPKEY");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Jurisdict)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("JURISDICT");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.LongType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LONG_TYPE");
            builder.Property(e => e.OtherInfo)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTHER_INFO");
            builder.Property(e => e.Spflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SPFLAG");
            builder.Property(e => e.StrPoints)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STR_POINTS");
            builder.Property(e => e.Type)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPE");
            builder.Property(e => e.Vdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("VDATE");
            builder.Property(e => e.Weborder)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("WEBORDER");

        }
    }
}