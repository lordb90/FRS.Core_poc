//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class WebreqstConfiguration : IEntityTypeConfiguration<Webreqst>
//    {
//        public void Configure(EntityTypeBuilder<Webreqst> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("WEBREQST");

//            builder.Property(e => e.Aka1)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("AKA1");
//            builder.Property(e => e.Aka2)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("AKA2");
//            builder.Property(e => e.Aka3)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("AKA3");
//            builder.Property(e => e.Billcode)
//                .HasMaxLength(10)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("BILLCODE");
//            builder.Property(e => e.Birthdate)
//                .HasDefaultValueSql("('')")
//                .HasColumnType("datetime")
//                .HasColumnName("BIRTHDATE");
//            builder.Property(e => e.Caaccompl)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAACCOMPL");
//            builder.Property(e => e.Caaccompl2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAACCOMPL2");
//            builder.Property(e => e.Cacredits)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CACREDITS");
//            builder.Property(e => e.Cacredits2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CACREDITS2");
//            builder.Property(e => e.CadateAt2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CADATE_AT2");
//            builder.Property(e => e.CadateAtt)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CADATE_ATT");
//            builder.Property(e => e.CadateEm2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CADATE_EM2");
//            builder.Property(e => e.CadateEm3)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CADATE_EM3");
//            builder.Property(e => e.CadateEm4)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CADATE_EM4");
//            builder.Property(e => e.CadateEm5)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CADATE_EM5");
//            builder.Property(e => e.CadateEmp)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CADATE_EMP");
//            builder.Property(e => e.Caddrecv)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CADDRECV");
//            builder.Property(e => e.Caddrecv2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CADDRECV2");
//            builder.Property(e => e.Cadegree)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CADEGREE");
//            builder.Property(e => e.Cadegree2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CADEGREE2");
//            builder.Property(e => e.Caendduty)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDDUTY");
//            builder.Property(e => e.Caendduty2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDDUTY2");
//            builder.Property(e => e.Caendduty3)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDDUTY3");
//            builder.Property(e => e.Caendduty4)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDDUTY4");
//            builder.Property(e => e.Caendduty5)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDDUTY5");
//            builder.Property(e => e.Caendpay)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDPAY");
//            builder.Property(e => e.Caendpay2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDPAY2");
//            builder.Property(e => e.Caendpay3)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDPAY3");
//            builder.Property(e => e.Caendpay4)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDPAY4");
//            builder.Property(e => e.Caendpay5)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDPAY5");
//            builder.Property(e => e.Caendtitl2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDTITL2");
//            builder.Property(e => e.Caendtitl3)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDTITL3");
//            builder.Property(e => e.Caendtitl4)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDTITL4");
//            builder.Property(e => e.Caendtitl5)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDTITL5");
//            builder.Property(e => e.Caendtitle)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAENDTITLE");
//            builder.Property(e => e.Cagrades)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAGRADES");
//            builder.Property(e => e.Cagrades2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAGRADES2");
//            builder.Property(e => e.Camajor)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAMAJOR");
//            builder.Property(e => e.Camajor2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAMAJOR2");
//            builder.Property(e => e.CareasLv)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAREAS_LV");
//            builder.Property(e => e.CareasLv2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAREAS_LV2");
//            builder.Property(e => e.CareasLv3)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAREAS_LV3");
//            builder.Property(e => e.CareasLv4)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAREAS_LV4");
//            builder.Property(e => e.CareasLv5)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAREAS_LV5");
//            builder.Property(e => e.CastDuty)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_DUTY");
//            builder.Property(e => e.CastDuty2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_DUTY2");
//            builder.Property(e => e.CastDuty3)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_DUTY3");
//            builder.Property(e => e.CastDuty4)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_DUTY4");
//            builder.Property(e => e.CastDuty5)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_DUTY5");
//            builder.Property(e => e.CastPay)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_PAY");
//            builder.Property(e => e.CastPay2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_PAY2");
//            builder.Property(e => e.CastPay3)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_PAY3");
//            builder.Property(e => e.CastPay4)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_PAY4");
//            builder.Property(e => e.CastPay5)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_PAY5");
//            builder.Property(e => e.CastTitl2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_TITL2");
//            builder.Property(e => e.CastTitl3)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_TITL3");
//            builder.Property(e => e.CastTitl4)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_TITL4");
//            builder.Property(e => e.CastTitl5)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_TITL5");
//            builder.Property(e => e.CastTitle)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CAST_TITLE");
//            builder.Property(e => e.City)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CITY");
//            builder.Property(e => e.Clocation)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CLOCATION");
//            builder.Property(e => e.Clocation2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CLOCATION2");
//            builder.Property(e => e.Comments)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COMMENTS");
//            builder.Property(e => e.CompCode)
//                .HasMaxLength(6)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COMP_CODE");
//            builder.Property(e => e.ConLtr)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CON_LTR");
//            builder.Property(e => e.County1)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COUNTY1");
//            builder.Property(e => e.County10)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COUNTY10");
//            builder.Property(e => e.County2)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COUNTY2");
//            builder.Property(e => e.County3)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COUNTY3");
//            builder.Property(e => e.County4)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COUNTY4");
//            builder.Property(e => e.County5)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COUNTY5");
//            builder.Property(e => e.County6)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COUNTY6");
//            builder.Property(e => e.County7)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COUNTY7");
//            builder.Property(e => e.County8)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COUNTY8");
//            builder.Property(e => e.County9)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COUNTY9");
//            builder.Property(e => e.CrJoint)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CR_JOINT");
//            builder.Property(e => e.Dlnum)
//                .HasMaxLength(25)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("DLNUM");
//            builder.Property(e => e.Dlstate)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("DLSTATE");
//            builder.Property(e => e.EFax)
//                .HasMaxLength(14)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("E_FAX");
//            builder.Property(e => e.EFax2)
//                .HasMaxLength(14)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("E_FAX2");
//            builder.Property(e => e.EFax3)
//                .HasMaxLength(14)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("E_FAX3");
//            builder.Property(e => e.EFax4)
//                .HasMaxLength(14)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("E_FAX4");
//            builder.Property(e => e.EFax5)
//                .HasMaxLength(14)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("E_FAX5");
//            builder.Property(e => e.EPhone)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("E_PHONE");
//            builder.Property(e => e.EPhone2)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("E_PHONE2");
//            builder.Property(e => e.EPhone3)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("E_PHONE3");
//            builder.Property(e => e.EPhone4)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("E_PHONE4");
//            builder.Property(e => e.EPhone5)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("E_PHONE5");
//            builder.Property(e => e.Elocation)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ELOCATION");
//            builder.Property(e => e.Elocation2)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ELOCATION2");
//            builder.Property(e => e.Elocation3)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ELOCATION3");
//            builder.Property(e => e.Elocation4)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ELOCATION4");
//            builder.Property(e => e.Elocation5)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ELOCATION5");
//            builder.Property(e => e.Employer)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EMPLOYER");
//            builder.Property(e => e.Employer2)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EMPLOYER2");
//            builder.Property(e => e.Employer3)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EMPLOYER3");
//            builder.Property(e => e.Employer4)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EMPLOYER4");
//            builder.Property(e => e.Employer5)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EMPLOYER5");
//            builder.Property(e => e.Eposition)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EPOSITION");
//            builder.Property(e => e.Eposition2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EPOSITION2");
//            builder.Property(e => e.Eposition3)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EPOSITION3");
//            builder.Property(e => e.Eposition4)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EPOSITION4");
//            builder.Property(e => e.Eposition5)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EPOSITION5");
//            builder.Property(e => e.FCredit)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("F_CREDIT");
//            builder.Property(e => e.FCrim)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("F_CRIM");
//            builder.Property(e => e.FDmv)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("F_DMV");
//            builder.Property(e => e.FEducat)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("F_EDUCAT");
//            builder.Property(e => e.FEmploy)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("F_EMPLOY");
//            builder.Property(e => e.FPlic)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("F_PLIC");
//            builder.Property(e => e.FSsnver)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("F_SSNVER");
//            builder.Property(e => e.FWkcomp)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("F_WKCOMP");
//            builder.Property(e => e.Fname)
//                .HasMaxLength(15)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FNAME");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.Institute)
//                .HasMaxLength(60)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("INSTITUTE");
//            builder.Property(e => e.Institute2)
//                .HasMaxLength(60)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("INSTITUTE2");
//            builder.Property(e => e.IssueDate)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ISSUE_DATE");
//            builder.Property(e => e.LicNbr)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("LIC_NBR");
//            builder.Property(e => e.LicState)
//                .HasMaxLength(15)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("LIC_STATE");
//            builder.Property(e => e.LicType)
//                .HasMaxLength(40)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("LIC_TYPE");
//            builder.Property(e => e.Lname)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("LNAME");
//            builder.Property(e => e.Mname)
//                .HasMaxLength(12)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("MNAME");
//            builder.Property(e => e.Ostcrit1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT1");
//            builder.Property(e => e.Ostcrit10)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT10");
//            builder.Property(e => e.Ostcrit11)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT11");
//            builder.Property(e => e.Ostcrit12)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT12");
//            builder.Property(e => e.Ostcrit13)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT13");
//            builder.Property(e => e.Ostcrit14)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT14");
//            builder.Property(e => e.Ostcrit15)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT15");
//            builder.Property(e => e.Ostcrit16)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT16");
//            builder.Property(e => e.Ostcrit2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT2");
//            builder.Property(e => e.Ostcrit3)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT3");
//            builder.Property(e => e.Ostcrit4)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT4");
//            builder.Property(e => e.Ostcrit5)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT5");
//            builder.Property(e => e.Ostcrit6)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT6");
//            builder.Property(e => e.Ostcrit7)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT7");
//            builder.Property(e => e.Ostcrit8)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT8");
//            builder.Property(e => e.Ostcrit9)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTCRIT9");
//            builder.Property(e => e.Ostdesc1)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC1");
//            builder.Property(e => e.Ostdesc10)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC10");
//            builder.Property(e => e.Ostdesc11)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC11");
//            builder.Property(e => e.Ostdesc12)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC12");
//            builder.Property(e => e.Ostdesc13)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC13");
//            builder.Property(e => e.Ostdesc14)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC14");
//            builder.Property(e => e.Ostdesc15)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC15");
//            builder.Property(e => e.Ostdesc16)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC16");
//            builder.Property(e => e.Ostdesc2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC2");
//            builder.Property(e => e.Ostdesc3)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC3");
//            builder.Property(e => e.Ostdesc4)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC4");
//            builder.Property(e => e.Ostdesc5)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC5");
//            builder.Property(e => e.Ostdesc6)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC6");
//            builder.Property(e => e.Ostdesc7)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC7");
//            builder.Property(e => e.Ostdesc8)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC8");
//            builder.Property(e => e.Ostdesc9)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("OSTDESC9");
//            builder.Property(e => e.PresAddr1)
//                .HasMaxLength(40)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("PRES_ADDR1");
//            builder.Property(e => e.RecDate)
//                .HasDefaultValueSql("('')")
//                .HasColumnType("datetime")
//                .HasColumnName("REC_DATE");
//            builder.Property(e => e.RecTime)
//                .HasMaxLength(8)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("REC_TIME");
//            builder.Property(e => e.Ref2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("REF2");
//            builder.Property(e => e.Reference)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("REFERENCE");
//            builder.Property(e => e.Requestor)
//                .HasMaxLength(25)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("REQUESTOR");
//            builder.Property(e => e.Rush)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("RUSH");
//            builder.Property(e => e.Sexrace)
//                .HasMaxLength(10)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SEXRACE");
//            builder.Property(e => e.SpFname)
//                .HasMaxLength(15)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SP_FNAME");
//            builder.Property(e => e.SpLname)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SP_LNAME");
//            builder.Property(e => e.SpMname)
//                .HasMaxLength(12)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SP_MNAME");
//            builder.Property(e => e.SpSsno)
//                .HasMaxLength(11)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SP_SSNO");
//            builder.Property(e => e.SrchInstr)
//                .HasMaxLength(150)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SRCH_INSTR");
//            builder.Property(e => e.Srchtype1)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SRCHTYPE1");
//            builder.Property(e => e.Srchtype10)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SRCHTYPE10");
//            builder.Property(e => e.Srchtype2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SRCHTYPE2");
//            builder.Property(e => e.Srchtype3)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SRCHTYPE3");
//            builder.Property(e => e.Srchtype4)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SRCHTYPE4");
//            builder.Property(e => e.Srchtype5)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SRCHTYPE5");
//            builder.Property(e => e.Srchtype6)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SRCHTYPE6");
//            builder.Property(e => e.Srchtype7)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SRCHTYPE7");
//            builder.Property(e => e.Srchtype8)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SRCHTYPE8");
//            builder.Property(e => e.Srchtype9)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SRCHTYPE9");
//            builder.Property(e => e.Ssn)
//                .HasMaxLength(11)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SSN");
//            builder.Property(e => e.State)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE");
//            builder.Property(e => e.State1)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE1");
//            builder.Property(e => e.State10)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE10");
//            builder.Property(e => e.State2)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE2");
//            builder.Property(e => e.State3)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE3");
//            builder.Property(e => e.State4)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE4");
//            builder.Property(e => e.State5)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE5");
//            builder.Property(e => e.State6)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE6");
//            builder.Property(e => e.State7)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE7");
//            builder.Property(e => e.State8)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE8");
//            builder.Property(e => e.State9)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE9");
//            builder.Property(e => e.Superviso2)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SUPERVISO2");
//            builder.Property(e => e.Superviso3)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SUPERVISO3");
//            builder.Property(e => e.Superviso4)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SUPERVISO4");
//            builder.Property(e => e.Superviso5)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SUPERVISO5");
//            builder.Property(e => e.Supervisor)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SUPERVISOR");
//            builder.Property(e => e.Wcstate1)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("WCSTATE1");
//            builder.Property(e => e.Wcstate2)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("WCSTATE2");
//            builder.Property(e => e.Wcstate3)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("WCSTATE3");
//            builder.Property(e => e.Zip)
//                .HasMaxLength(5)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ZIP");

//        }
//    }
//}