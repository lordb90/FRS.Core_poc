using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;


namespace FRS.Core.Infrastructure.Configurations
{
    public class BkCrimConfiguration : IEntityTypeConfiguration<BkCrim>
    {
        public void Configure(EntityTypeBuilder<BkCrim> builder)
        {
            builder
                .HasNoKey()
                .ToTable("BK_CRIM");

            builder.Property(e => e.ArrDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("ARR_DATE");
            builder.Property(e => e.Case)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CASE");
            builder.Property(e => e.Charge)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CHARGE");
            builder.Property(e => e.CmcvFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CMCV_FLAG");
            builder.Property(e => e.CountData)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNT_DATA");
            builder.Property(e => e.County)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNTY");
            builder.Property(e => e.Court)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COURT");
            builder.Property(e => e.Crstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRSTATE");
            builder.Property(e => e.Crstatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRSTATUS");
            builder.Property(e => e.Disp)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DISP");
            builder.Property(e => e.DispDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DISP_DATE");
            builder.Property(e => e.FileDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("FILE_DATE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.IntNotes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_NOTES");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.MatchDesc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MATCH_DESC");
            builder.Property(e => e.Notes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NOTES");
            builder.Property(e => e.Orgcase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ORGCASE");
            builder.Property(e => e.OthDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTH_DESC");
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
            builder.Property(e => e.Shortname)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SHORTNAME");
            builder.Property(e => e.SrchCrit)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRCH_CRIT");
            builder.Property(e => e.SrchFed).HasColumnName("SRCH_FED");
            builder.Property(e => e.SrchFel).HasColumnName("SRCH_FEL");
            builder.Property(e => e.SrchLc).HasColumnName("SRCH_LC");
            builder.Property(e => e.SrchMisd).HasColumnName("SRCH_MISD");
            builder.Property(e => e.SrchOth).HasColumnName("SRCH_OTH");
            builder.Property(e => e.SrchUc).HasColumnName("SRCH_UC");
            builder.Property(e => e.Yesrectype)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("YESRECTYPE");
        }
    }
}
