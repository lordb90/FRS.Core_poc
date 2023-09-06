using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class VnorderConfiguration : IEntityTypeConfiguration<Vnorder>
    {
        public void Configure(EntityTypeBuilder<Vnorder> builder)
        {
            builder
                .HasNoKey()
                .ToTable("VNORDERS");

            builder.Property(e => e.AddInfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADD_INFO");
            builder.Property(e => e.Aka)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AKA");
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
            builder.Property(e => e.Cform)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CFORM");
            builder.Property(e => e.Court)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COURT");
            builder.Property(e => e.Dob)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DOB");
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
            builder.Property(e => e.Empkey)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMPKEY");
            builder.Property(e => e.Eposition)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EPOSITION");
            builder.Property(e => e.Extra)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXTRA");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Jurisdict)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("JURISDICT");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.LongType)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LONG_TYPE");
            builder.Property(e => e.Name)
                .HasMaxLength(42)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NAME");
            builder.Property(e => e.OtherInfo)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTHER_INFO");
            builder.Property(e => e.Rcomments)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RCOMMENTS");
            builder.Property(e => e.ReqDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("REQ_DATE");
            builder.Property(e => e.ReqTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQ_TIME");
            builder.Property(e => e.Rheligible)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RHELIGIBLE");
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
            builder.Property(e => e.Sdesc)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SDESC");
            builder.Property(e => e.Spflag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SPFLAG");
            builder.Property(e => e.Sq1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ1");
            builder.Property(e => e.Sq10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ10");
            builder.Property(e => e.Sq11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ11");
            builder.Property(e => e.Sq12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ12");
            builder.Property(e => e.Sq13)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ13");
            builder.Property(e => e.Sq14)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ14");
            builder.Property(e => e.Sq15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ15");
            builder.Property(e => e.Sq2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ2");
            builder.Property(e => e.Sq3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ3");
            builder.Property(e => e.Sq4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ4");
            builder.Property(e => e.Sq5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ5");
            builder.Property(e => e.Sq6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ6");
            builder.Property(e => e.Sq7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ7");
            builder.Property(e => e.Sq8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ8");
            builder.Property(e => e.Sq9)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SQ9");
            builder.Property(e => e.SrchCrit)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRCH_CRIT");
            builder.Property(e => e.SrchInstr)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRCH_INSTR");
            builder.Property(e => e.Ssn)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN");
            builder.Property(e => e.StrPoints)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STR_POINTS");
            builder.Property(e => e.Supervisor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUPERVISOR");
            builder.Property(e => e.Type)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPE");
            builder.Property(e => e.Vrcd)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VRCD");
            builder.Property(e => e.WcompDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WCOMP_DATE");
            builder.Property(e => e.WcompTime)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WCOMP_TIME");
            builder.Property(e => e.WebDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WEB_DATE");
            builder.Property(e => e.WebStat)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEB_STAT");
            builder.Property(e => e.WebTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEB_TIME");
            builder.Property(e => e.Weborder)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("WEBORDER");
            builder.Property(e => e.WkPoints)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WK_POINTS");
            builder.Property(e => e.Wresults)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WRESULTS");
        }
    }
}