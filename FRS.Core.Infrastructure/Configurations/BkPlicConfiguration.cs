using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Core.Infrastructure.Configurations
{
    public class BkPlicConfiguration : IEntityTypeConfiguration<BkPlic>
    {
        public void Configure(EntityTypeBuilder<BkPlic> builder)
        {
            builder
                .HasNoKey()
                .ToTable("BK_PLIC");

            builder.Property(e => e.AddInfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADD_INFO");
            builder.Property(e => e.BFax)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("B_FAX");
            builder.Property(e => e.BPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("B_PHONE");
            builder.Property(e => e.Bcomments)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BCOMMENTS");
            builder.Property(e => e.Complete).HasColumnName("COMPLETE");
            builder.Property(e => e.Confirmby)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CONFIRMBY");
            builder.Property(e => e.ContBoard)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CONT_BOARD");
            builder.Property(e => e.Discrep).HasColumnName("DISCREP");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.IntNotes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_NOTES");
            builder.Property(e => e.IssueDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ISSUE_DATE");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.LicDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LIC_DATE");
            builder.Property(e => e.LicExpire)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LIC_EXPIRE");
            builder.Property(e => e.LicName)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LIC_NAME");
            builder.Property(e => e.LicNbr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LIC_NBR");
            builder.Property(e => e.LicState)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LIC_STATE");
            builder.Property(e => e.LicType)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LIC_TYPE");
            builder.Property(e => e.Location)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCATION");
            builder.Property(e => e.Rcomments)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RCOMMENTS");
            builder.Property(e => e.RecalLast)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RECAL_LAST");
            builder.Property(e => e.RecallCnt)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("RECALL_CNT");
            builder.Property(e => e.RecallDt)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RECALL_DT");
            builder.Property(e => e.ResDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("RES_DATE");
            builder.Property(e => e.ResName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_NAME");
            builder.Property(e => e.ResReturn)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_RETURN");
            builder.Property(e => e.ResStat)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_STAT");
            builder.Property(e => e.ResWhen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_WHEN");
            builder.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TITLE");
            builder.Property(e => e.Unabl2vrfy).HasColumnName("UNABL2VRFY");
        }
    }
}
