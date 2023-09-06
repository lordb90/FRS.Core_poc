using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FRS.Core.Infrastructure.Configurations
{
    public class BkWkcmpConfiguration : IEntityTypeConfiguration<BkWkcmp>
    {
        public void Configure(EntityTypeBuilder<BkWkcmp> builder)
        {
            builder
                .HasNoKey()
                .ToTable("BK_WKCMP");

            builder.Property(e => e.Fromdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("FROMDATE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Todate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("TODATE");
            builder.Property(e => e.Wcstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WCSTATE");
        }
    }
}
