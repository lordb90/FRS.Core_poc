using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Core.Infrastructure.Configurations
{
    public class PfEmplNoIdentityConfiguration : IEntityTypeConfiguration<PfEmplNoIdentity>
    {
        public void Configure(EntityTypeBuilder<PfEmplNoIdentity> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PF_EMPL_NO_IDENTITY");

            builder.Property(e => e.AddInfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADD_INFO");
            builder.Property(e => e.AltContac)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALT_CONTAC");
            builder.Property(e => e.AltEmpl)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALT_EMPL");
            builder.Property(e => e.AltLoc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALT_LOC");
            builder.Property(e => e.AltPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALT_PHONE");
            builder.Property(e => e.CadateAtt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CADATE_ATT");
            builder.Property(e => e.Caendduty)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CAENDDUTY");
            builder.Property(e => e.Caendpay)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CAENDPAY");
            builder.Property(e => e.Caendtitle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CAENDTITLE");
            builder.Property(e => e.CareasLv)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CAREAS_LV");
            builder.Property(e => e.CastDuty)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CAST_DUTY");
            builder.Property(e => e.CastPay)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CAST_PAY");
            builder.Property(e => e.CastTitle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CAST_TITLE");
            builder.Property(e => e.Clearhouse)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CLEARHOUSE");
            builder.Property(e => e.CompFlag).HasColumnName("COMP_FLAG");
            builder.Property(e => e.Complete).HasColumnName("COMPLETE");
            builder.Property(e => e.Discrep).HasColumnName("DISCREP");
            builder.Property(e => e.Dontreport).HasColumnName("DONTREPORT");
            builder.Property(e => e.DotRegula).HasColumnName("DOT_REGULA");
            builder.Property(e => e.EFax)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("E_FAX");
            builder.Property(e => e.EPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("E_PHONE");
            builder.Property(e => e.Ecomments)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ECOMMENTS");
            builder.Property(e => e.EmpCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMP_CODE");
            builder.Property(e => e.Empemail)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMPEMAIL");
            builder.Property(e => e.Empkey)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMPKEY");
            builder.Property(e => e.EmplPrint).HasColumnName("EMPL_PRINT");
            builder.Property(e => e.Employer)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMPLOYER");
            builder.Property(e => e.Eorder)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("EORDER");
            builder.Property(e => e.Eposition)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EPOSITION");
            builder.Property(e => e.Fnameempl)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FNAMEEMPL");
            builder.Property(e => e.IntNotes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_NOTES");
            builder.Property(e => e.InterData)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INTER_DATA");
            builder.Property(e => e.InternFlg).HasColumnName("INTERN_FLG");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Lastmodify)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LASTMODIFY");
            builder.Property(e => e.Lnameempl)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LNAMEEMPL");
            builder.Property(e => e.Location)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCATION");
            builder.Property(e => e.Mnameempl)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MNAMEEMPL");
            builder.Property(e => e.NoCharge).HasColumnName("NO_CHARGE");
            builder.Property(e => e.PfKey).HasColumnName("PF_KEY");
            builder.Property(e => e.QuesSet)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("QUES_SET");
            builder.Property(e => e.Rcomments)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RCOMMENTS");
            builder.Property(e => e.RecReview).HasColumnName("REC_REVIEW");
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
            builder.Property(e => e.Rheligible)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RHELIGIBLE");
            builder.Property(e => e.Rmemo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RMEMO");
            builder.Property(e => e.RpDotFlg).HasColumnName("RP_DOT_FLG");
            builder.Property(e => e.RvdateAtt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RVDATE_ATT");
            builder.Property(e => e.Rvendduty)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RVENDDUTY");
            builder.Property(e => e.Rvendpay)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RVENDPAY");
            builder.Property(e => e.Rvendtitle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RVENDTITLE");
            builder.Property(e => e.RvreasLv)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RVREAS_LV");
            builder.Property(e => e.RvstDuty)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RVST_DUTY");
            builder.Property(e => e.RvstPay)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RVST_PAY");
            builder.Property(e => e.RvstTitle)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RVST_TITLE");
            builder.Property(e => e.Skipwknord)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("SKIPWKNORD");
            builder.Property(e => e.SpecQues)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SPEC_QUES");
            builder.Property(e => e.StrPoints)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STR_POINTS");
            builder.Property(e => e.Supervisor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUPERVISOR");
            builder.Property(e => e.Unabl2vrfy).HasColumnName("UNABL2VRFY");
            builder.Property(e => e.WebSpques).HasColumnName("WEB_SPQUES");
            builder.Property(e => e.WkPoints)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WK_POINTS");
        }
    }
}
