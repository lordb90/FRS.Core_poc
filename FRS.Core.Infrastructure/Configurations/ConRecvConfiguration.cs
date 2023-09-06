using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class ConRecvConfiguration : IEntityTypeConfiguration<ConRecv>
{
    public void Configure(EntityTypeBuilder<ConRecv> builder)
    {
        builder
            .HasNoKey()
            .ToTable("CON_RECV");

        builder.Property(e => e.EmailAddr)
            .HasMaxLength(70)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EMAIL_ADDR");
        builder.Property(e => e.EmailCli).HasColumnName("EMAIL_CLI");
        builder.Property(e => e.EmailDate)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("EMAIL_DATE");
        builder.Property(e => e.EmailErr).HasColumnName("EMAIL_ERR");
        builder.Property(e => e.EmailFrs).HasColumnName("EMAIL_FRS");
        builder.Property(e => e.EmailPnt)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EMAIL_PNT");
        builder.Property(e => e.EmailSent).HasColumnName("EMAIL_SENT");
        builder.Property(e => e.EmailTime)
            .HasMaxLength(8)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EMAIL_TIME");
        builder.Property(e => e.FcId)
            .HasMaxLength(12)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("FC_ID");
        builder.Property(e => e.Filename)
            .HasMaxLength(12)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("FILENAME");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.LoadDate)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("LOAD_DATE");
        builder.Property(e => e.LoadId)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("LOAD_ID");
        builder.Property(e => e.LoadTime)
            .HasMaxLength(8)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("LOAD_TIME");
        builder.Property(e => e.NumReqIn)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("NUM_REQ_IN");
        builder.Property(e => e.NumResIn)
            .HasColumnType("numeric(3, 0)")
            .HasColumnName("NUM_RES_IN");
        builder.Property(e => e.Other)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("OTHER");
        builder.Property(e => e.Processed).HasColumnName("PROCESSED");
        builder.Property(e => e.RecvDate)
            .HasDefaultValueSql("('')")
            .HasColumnType("datetime")
            .HasColumnName("RECV_DATE");
        builder.Property(e => e.RecvTime)
            .HasMaxLength(8)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("RECV_TIME");
        builder.Property(e => e.ViewErr).HasColumnName("VIEW_ERR");
    }
}