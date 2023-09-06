using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class PfCrimConfiguration : IEntityTypeConfiguration<PfCrim>
    {
        public void Configure(EntityTypeBuilder<PfCrim> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PF_CRIM");

            builder.Property(e => e.Akaconfirm).HasColumnName("AKACONFIRM");
            builder.Property(e => e.ArrDate)
                .HasColumnType("datetime")
                .HasColumnName("ARR_DATE");
            builder.Property(e => e.Case)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("CASE");
            builder.Property(e => e.Charge)
                .IsUnicode(false)
                .HasColumnName("CHARGE");
            builder.Property(e => e.CmcvFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CMCV_FLAG");
            builder.Property(e => e.CountData)
                .IsUnicode(false)
                .HasColumnName("COUNT_DATA");
            builder.Property(e => e.County)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("COUNTY");
            builder.Property(e => e.Court)
                .IsUnicode(false)
                .HasColumnName("COURT");
            builder.Property(e => e.Crstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CRSTATE");
            builder.Property(e => e.Crstatus)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CRSTATUS");
            builder.Property(e => e.Csrchinstr)
                .IsUnicode(false)
                .HasColumnName("CSRCHINSTR");
            builder.Property(e => e.Disp)
                .IsUnicode(false)
                .HasColumnName("DISP");
            builder.Property(e => e.DispDate)
                .HasColumnType("datetime")
                .HasColumnName("DISP_DATE");
            builder.Property(e => e.Eorder)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("EORDER");
            builder.Property(e => e.Eta)
                .HasColumnType("datetime")
                .HasColumnName("ETA");
            builder.Property(e => e.Faxhithere).HasColumnName("FAXHITHERE");
            builder.Property(e => e.FileDate)
                .HasColumnType("datetime")
                .HasColumnName("FILE_DATE");
            builder.Property(e => e.IcSkip).HasColumnName("IC_SKIP");
            builder.Property(e => e.IntNotes)
                .IsUnicode(false)
                .HasColumnName("INT_NOTES");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.MatchDesc)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("MATCH_DESC");
            builder.Property(e => e.NoPay).HasColumnName("NO_PAY");
            builder.Property(e => e.NoPayreas)
                .IsUnicode(false)
                .HasColumnName("NO_PAYREAS");
            builder.Property(e => e.Notes)
                .IsUnicode(false)
                .HasColumnName("NOTES");
            builder.Property(e => e.Numcount)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("NUMCOUNT");
            builder.Property(e => e.Orgcase)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ORGCASE");
            builder.Property(e => e.OthDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("OTH_DESC");
            builder.Property(e => e.PfKey)
                .ValueGeneratedOnAdd()
                .HasColumnName("PF_KEY");
            builder.Property(e => e.RecReview).HasColumnName("REC_REVIEW");
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
            builder.Property(e => e.Shortname)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("SHORTNAME");
            builder.Property(e => e.SrchCrit)
                .IsUnicode(false)
                .HasColumnName("SRCH_CRIT");
            builder.Property(e => e.SrchFed).HasColumnName("SRCH_FED");
            builder.Property(e => e.SrchFel).HasColumnName("SRCH_FEL");
            builder.Property(e => e.SrchLc).HasColumnName("SRCH_LC");
            builder.Property(e => e.SrchMisd).HasColumnName("SRCH_MISD");
            builder.Property(e => e.SrchOth).HasColumnName("SRCH_OTH");
            builder.Property(e => e.SrchUc).HasColumnName("SRCH_UC");
            builder.Property(e => e.Sriconfirm).HasColumnName("SRICONFIRM");
            builder.Property(e => e.Yesrectype)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("YESRECTYPE");
        }
    }
}