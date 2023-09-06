using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class TudrmonitrConfiguration : IEntityTypeConfiguration<Tudrmonitr>
    {
        public void Configure(EntityTypeBuilder<Tudrmonitr> builder)
        {
            builder
                .HasNoKey()
                .ToTable("TUDRMONITR");

            builder.Property(e => e.Birthdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDATE");
            builder.Property(e => e.City)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CITY");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Dlnum)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLNUM");
            builder.Property(e => e.Dlstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLSTATE");
            builder.Property(e => e.EmlRemind)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("EML_REMIND");
            builder.Property(e => e.Gender)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("GENDER");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.LastCheck)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LAST_CHECK");
            builder.Property(e => e.MntrEnd)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("MNTR_END");
            builder.Property(e => e.MntrStart)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("MNTR_START");
            builder.Property(e => e.PfKey).HasColumnName("PF_KEY");
            builder.Property(e => e.PresAddr1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PRES_ADDR1");
            builder.Property(e => e.Ssno)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("SSNO");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.SubjKey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("SUBJ_KEY");
            builder.Property(e => e.SubjName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBJ_NAME");
            builder.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ZIP");
        }
    }
}