using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class PfEmplConfiguration : IEntityTypeConfiguration<PfEmpl>
    {
        public void Configure(EntityTypeBuilder<PfEmpl> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PF_EMPL");

            builder.Property(e => e.AddInfo)
                .IsUnicode(false)
                .HasColumnName("ADD_INFO");
            builder.Property(e => e.AltContac)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ALT_CONTAC");
            builder.Property(e => e.AltEmpl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ALT_EMPL");
            builder.Property(e => e.AltLoc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("ALT_LOC");
            builder.Property(e => e.AltPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ALT_PHONE");
            builder.Property(e => e.CadateAtt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CADATE_ATT");
            builder.Property(e => e.Caendduty)
                .IsUnicode(false)
                .HasColumnName("CAENDDUTY");
            builder.Property(e => e.Caendpay)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CAENDPAY");
            builder.Property(e => e.Caendtitle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CAENDTITLE");
            builder.Property(e => e.CareasLv)
                .IsUnicode(false)
                .HasColumnName("CAREAS_LV");
            builder.Property(e => e.CastDuty)
                .IsUnicode(false)
                .HasColumnName("CAST_DUTY");
            builder.Property(e => e.CastPay)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CAST_PAY");
            builder.Property(e => e.CastTitle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CAST_TITLE");
            builder.Property(e => e.Clearhouse)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CLEARHOUSE");
            builder.Property(e => e.CompFlag).HasColumnName("COMP_FLAG");
            builder.Property(e => e.Complete).HasColumnName("COMPLETE");
            builder.Property(e => e.Discrep).HasColumnName("DISCREP");
            builder.Property(e => e.Dontreport).HasColumnName("DONTREPORT");
            builder.Property(e => e.DotRegula).HasColumnName("DOT_REGULA");
            builder.Property(e => e.EFax)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("E_FAX");
            builder.Property(e => e.EPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("E_PHONE");
            builder.Property(e => e.Ecomments)
                .IsUnicode(false)
                .HasColumnName("ECOMMENTS");
            builder.Property(e => e.EmpCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMP_CODE");
            builder.Property(e => e.Empemail)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("EMPEMAIL");
            builder.Property(e => e.Empkey)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("EMPKEY");
            builder.Property(e => e.EmplPrint).HasColumnName("EMPL_PRINT");
            builder.Property(e => e.Employer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("EMPLOYER");
            builder.Property(e => e.Eorder)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("EORDER");
            builder.Property(e => e.Eposition)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("EPOSITION");
            builder.Property(e => e.Fnameempl)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FNAMEEMPL");
            builder.Property(e => e.IntNotes)
                .IsUnicode(false)
                .HasColumnName("INT_NOTES");
            builder.Property(e => e.InterData)
                .IsUnicode(false)
                .HasColumnName("INTER_DATA");
            builder.Property(e => e.InternFlg).HasColumnName("INTERN_FLG");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Lastmodify)
                .HasColumnType("datetime")
                .HasColumnName("LASTMODIFY");
            builder.Property(e => e.Lnameempl)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LNAMEEMPL");
            builder.Property(e => e.Location)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            builder.Property(e => e.Mnameempl)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("MNAMEEMPL");
            builder.Property(e => e.NoCharge).HasColumnName("NO_CHARGE");
            builder.Property(e => e.PfKey)
                .ValueGeneratedOnAdd()
                .HasColumnName("PF_KEY");
            builder.Property(e => e.QuesSet)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("QUES_SET");
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
            builder.Property(e => e.Rheligible)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RHELIGIBLE");
            builder.Property(e => e.Rmemo)
                .IsUnicode(false)
                .HasColumnName("RMEMO");
            builder.Property(e => e.RpDotFlg).HasColumnName("RP_DOT_FLG");
            builder.Property(e => e.RvdateAtt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RVDATE_ATT");
            builder.Property(e => e.Rvendduty)
                .IsUnicode(false)
                .HasColumnName("RVENDDUTY");
            builder.Property(e => e.Rvendpay)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RVENDPAY");
            builder.Property(e => e.Rvendtitle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RVENDTITLE");
            builder.Property(e => e.RvreasLv)
                .IsUnicode(false)
                .HasColumnName("RVREAS_LV");
            builder.Property(e => e.RvstDuty)
                .IsUnicode(false)
                .HasColumnName("RVST_DUTY");
            builder.Property(e => e.RvstPay)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RVST_PAY");
            builder.Property(e => e.RvstTitle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RVST_TITLE");
            builder.Property(e => e.Skipwknord)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("SKIPWKNORD");
            builder.Property(e => e.SpecQues)
                .IsUnicode(false)
                .HasColumnName("SPEC_QUES");
            builder.Property(e => e.StrPoints)
                .IsUnicode(false)
                .HasColumnName("STR_POINTS");
            builder.Property(e => e.Supervisor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("SUPERVISOR");
            builder.Property(e => e.Unabl2vrfy).HasColumnName("UNABL2VRFY");
            builder.Property(e => e.WebSpques).HasColumnName("WEB_SPQUES");
            builder.Property(e => e.WkPoints)
                .IsUnicode(false)
                .HasColumnName("WK_POINTS");
        }
    }
}