using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class PfPlicConfiguration : IEntityTypeConfiguration<PfPlic>
    {
        public void Configure(EntityTypeBuilder<PfPlic> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PF_PLIC");

            builder.Property(e => e.AddInfo)
                .IsUnicode(false)
                .HasColumnName("ADD_INFO");
            builder.Property(e => e.BFax)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("B_FAX");
            builder.Property(e => e.BPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("B_PHONE");
            builder.Property(e => e.Bcomments)
                .IsUnicode(false)
                .HasColumnName("BCOMMENTS");
            builder.Property(e => e.Complete).HasColumnName("COMPLETE");
            builder.Property(e => e.Confirmby)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CONFIRMBY");
            builder.Property(e => e.ContBoard)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("CONT_BOARD");
            builder.Property(e => e.Discrep).HasColumnName("DISCREP");
            builder.Property(e => e.IntNotes)
                .IsUnicode(false)
                .HasColumnName("INT_NOTES");
            builder.Property(e => e.IssueDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ISSUE_DATE");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Lastmodify)
                .HasColumnType("datetime")
                .HasColumnName("LASTMODIFY");
            builder.Property(e => e.LicDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LIC_DATE");
            builder.Property(e => e.LicExpire)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LIC_EXPIRE");
            builder.Property(e => e.LicName)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("LIC_NAME");
            builder.Property(e => e.LicNbr)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LIC_NBR");
            builder.Property(e => e.LicState)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("LIC_STATE");
            builder.Property(e => e.LicType)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("LIC_TYPE");
            builder.Property(e => e.Location)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            builder.Property(e => e.PfKey)
                .ValueGeneratedOnAdd()
                .HasColumnName("PF_KEY");
            builder.Property(e => e.Rcomments)
                .IsUnicode(false)
                .HasColumnName("RCOMMENTS");
            builder.Property(e => e.RecReview).HasColumnName("REC_REVIEW");
            builder.Property(e => e.RecalLast)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("RECAL_LAST");
            builder.Property(e => e.RecallCnt)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("RECALL_CNT");
            builder.Property(e => e.RecallDt)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("RECALL_DT");
            builder.Property(e => e.ResDate)
                .HasColumnType("datetime")
                .HasColumnName("RES_DATE");
            builder.Property(e => e.ResName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RES_NAME");
            builder.Property(e => e.ResReturn)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("RES_RETURN");
            builder.Property(e => e.ResStat)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("RES_STAT");
            builder.Property(e => e.ResWhen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("RES_WHEN");
            builder.Property(e => e.Title)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            builder.Property(e => e.Unabl2vrfy).HasColumnName("UNABL2VRFY");
        }
    }
}