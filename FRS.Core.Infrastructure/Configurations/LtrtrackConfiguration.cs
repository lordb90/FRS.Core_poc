using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class LtrtrackConfiguration : IEntityTypeConfiguration<Ltrtrack>
    {
        public void Configure(EntityTypeBuilder<Ltrtrack> builder)
        {
            builder
                .HasNoKey()
                .ToTable("LTRTRACK");

            builder.Property(e => e.AttchList)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATTCH_LIST");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.DelivMeth)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DELIV_METH");
            builder.Property(e => e.Delivaddr)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DELIVADDR");
            builder.Property(e => e.Delivemail)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DELIVEMAIL");
            builder.Property(e => e.GenDtm)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("GEN_DTM");
            builder.Property(e => e.GenUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("GEN_USER");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Lettertype)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LETTERTYPE");
            builder.Property(e => e.ReqDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("REQ_DATE");
            builder.Property(e => e.SubjKey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("SUBJ_KEY");
            builder.Property(e => e.SubjName)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBJ_NAME");

        }
    }
}