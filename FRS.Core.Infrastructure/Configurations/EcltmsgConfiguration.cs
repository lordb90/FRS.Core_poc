using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class EcltmsgConfiguration : IEntityTypeConfiguration<Ecltmsg>
    {
        public void Configure(EntityTypeBuilder<Ecltmsg> builder)
        {
            builder
                .HasNoKey()
                .ToTable("ECLTMSG");

            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Created)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("CREATED");
            builder.Property(e => e.Dtsent)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DTSENT");
            builder.Property(e => e.From)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FROM");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Important)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("IMPORTANT");
            builder.Property(e => e.Message)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MESSAGE");
            builder.Property(e => e.MsgKey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("MSG_KEY");
            builder.Property(e => e.Reply)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REPLY");
            builder.Property(e => e.Sent2web).HasColumnName("SENT2WEB");
            builder.Property(e => e.Subject)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBJECT");
            builder.Property(e => e.Viewed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VIEWED");
        }
    }
}