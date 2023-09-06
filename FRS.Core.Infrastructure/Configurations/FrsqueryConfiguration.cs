using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class FrsqueryConfiguration : IEntityTypeConfiguration<Frsquery>
    {
        public void Configure(EntityTypeBuilder<Frsquery> builder)
        {
            builder
                .HasNoKey()
                .ToTable("FRSQUERY");

            builder.Property(e => e.Active).HasColumnName("ACTIVE");
            builder.Property(e => e.Datatiers)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("DATATIERS");
            builder.Property(e => e.Defagraph)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("DEFAGRAPH");
            builder.Property(e => e.EdReposit).HasColumnName("ED_REPOSIT");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Interval)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INTERVAL");
            builder.Property(e => e.LastRun)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LAST_RUN");
            builder.Property(e => e.Legend1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LEGEND1");
            builder.Property(e => e.Legend2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LEGEND2");
            builder.Property(e => e.Legend3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LEGEND3");
            builder.Property(e => e.Legend4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LEGEND4");
            builder.Property(e => e.Postcode)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("POSTCODE");
            builder.Property(e => e.Queryid)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QUERYID");
            builder.Property(e => e.Queryname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QUERYNAME");
            builder.Property(e => e.Querytype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QUERYTYPE");
            builder.Property(e => e.Sethrend)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SETHREND");
            builder.Property(e => e.Sethrstart)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SETHRSTART");
            builder.Property(e => e.Setminute)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SETMINUTE");
            builder.Property(e => e.Setsecond)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SETSECOND");
            builder.Property(e => e.Sqlcode)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQLCODE");
            builder.Property(e => e.Xcaption)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("XCAPTION");
            builder.Property(e => e.Ycaption)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("YCAPTION");

        }
    }
}