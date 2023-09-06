﻿using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class PinstConfiguration : IEntityTypeConfiguration<Pinst>
    {
        public void Configure(EntityTypeBuilder<Pinst> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PINST");

            builder.Property(e => e.DlinxA7y)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_A7Y");
            builder.Property(e => e.DlinxA7yn)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_A7YN");
            builder.Property(e => e.DlinxA7ys)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_A7YS");
            builder.Property(e => e.DlinxAka).HasColumnName("DLINX_AKA");
            builder.Property(e => e.DlinxAscd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINX_ASCD");
            builder.Property(e => e.DlinxCode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINX_CODE");
            builder.Property(e => e.DlinxDob)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_DOB");
            builder.Property(e => e.DlinxE7y)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_E7Y");
            builder.Property(e => e.DlinxNmtc)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_NMTC");
            builder.Property(e => e.DlinxProb)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINX_PROB");
            builder.Property(e => e.DlinxPw)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINX_PW");
            builder.Property(e => e.DlinxSpec)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_SPEC");
            builder.Property(e => e.DlinxUser)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINX_USER");
            builder.Property(e => e.DlinxXtr2)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTR2");
            builder.Property(e => e.DlinxXtr3)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTR3");
            builder.Property(e => e.DlinxXtr4)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTR4");
            builder.Property(e => e.DlinxXtra)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTRA");
            builder.Property(e => e.Dlinxstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINXSTATE");
            builder.Property(e => e.DlxNorec)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLX_NOREC");
            builder.Property(e => e.DlxYesrec)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLX_YESREC");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Ost)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OST");
            builder.Property(e => e.Settings)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SETTINGS");
        }
    }
}
