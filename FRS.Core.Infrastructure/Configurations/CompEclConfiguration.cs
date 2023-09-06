using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class CompEclConfiguration : IEntityTypeConfiguration<CompEcl>
{
    public void Configure(EntityTypeBuilder<CompEcl> builder)
    {
        builder
            .HasNoKey()
            .ToTable("COMP_ECL");

        builder.Property(e => e.Accomplreq).HasColumnName("ACCOMPLREQ");
        builder.Property(e => e.Adverseact)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("ADVERSEACT");
        builder.Property(e => e.Atendnmreq).HasColumnName("ATENDNMREQ");
        builder.Property(e => e.CompCode)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COMP_CODE");
        builder.Property(e => e.Creditsreq).HasColumnName("CREDITSREQ");
        builder.Property(e => e.Degredtreq).HasColumnName("DEGREDTREQ");
        builder.Property(e => e.Degreereq).HasColumnName("DEGREEREQ");
        builder.Property(e => e.EducAccom).HasColumnName("EDUC_ACCOM");
        builder.Property(e => e.EducCred).HasColumnName("EDUC_CRED");
        builder.Property(e => e.EducDates).HasColumnName("EDUC_DATES");
        builder.Property(e => e.EducDegdt).HasColumnName("EDUC_DEGDT");
        builder.Property(e => e.EducDegr).HasColumnName("EDUC_DEGR");
        builder.Property(e => e.EducGrade).HasColumnName("EDUC_GRADE");
        builder.Property(e => e.EducMajor).HasColumnName("EDUC_MAJOR");
        builder.Property(e => e.EducOther).HasColumnName("EDUC_OTHER");
        builder.Property(e => e.Educdatreq).HasColumnName("EDUCDATREQ");
        builder.Property(e => e.EmplDates).HasColumnName("EMPL_DATES");
        builder.Property(e => e.EmplDuty).HasColumnName("EMPL_DUTY");
        builder.Property(e => e.EmplFax).HasColumnName("EMPL_FAX");
        builder.Property(e => e.EmplOther).HasColumnName("EMPL_OTHER");
        builder.Property(e => e.EmplPay).HasColumnName("EMPL_PAY");
        builder.Property(e => e.EmplReas).HasColumnName("EMPL_REAS");
        builder.Property(e => e.EmplSupos).HasColumnName("EMPL_SUPOS");
        builder.Property(e => e.EmplTitle).HasColumnName("EMPL_TITLE");
        builder.Property(e => e.Empldatreq).HasColumnName("EMPLDATREQ");
        builder.Property(e => e.Emplfaxreq).HasColumnName("EMPLFAXREQ");
        builder.Property(e => e.Emplwebreq).HasColumnName("EMPLWEBREQ");
        builder.Property(e => e.ExMlost1)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST1");
        builder.Property(e => e.ExMlost10)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST10");
        builder.Property(e => e.ExMlost11)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST11");
        builder.Property(e => e.ExMlost12)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST12");
        builder.Property(e => e.ExMlost13)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST13");
        builder.Property(e => e.ExMlost14)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST14");
        builder.Property(e => e.ExMlost15)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST15");
        builder.Property(e => e.ExMlost16)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST16");
        builder.Property(e => e.ExMlost17)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST17");
        builder.Property(e => e.ExMlost18)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST18");
        builder.Property(e => e.ExMlost19)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST19");
        builder.Property(e => e.ExMlost2)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST2");
        builder.Property(e => e.ExMlost20)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST20");
        builder.Property(e => e.ExMlost21)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST21");
        builder.Property(e => e.ExMlost22)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST22");
        builder.Property(e => e.ExMlost23)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST23");
        builder.Property(e => e.ExMlost24)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST24");
        builder.Property(e => e.ExMlost25)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST25");
        builder.Property(e => e.ExMlost26)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST26");
        builder.Property(e => e.ExMlost27)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST27");
        builder.Property(e => e.ExMlost28)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST28");
        builder.Property(e => e.ExMlost29)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST29");
        builder.Property(e => e.ExMlost3)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST3");
        builder.Property(e => e.ExMlost30)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST30");
        builder.Property(e => e.ExMlost31)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST31");
        builder.Property(e => e.ExMlost32)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST32");
        builder.Property(e => e.ExMlost33)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST33");
        builder.Property(e => e.ExMlost34)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST34");
        builder.Property(e => e.ExMlost35)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST35");
        builder.Property(e => e.ExMlost36)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST36");
        builder.Property(e => e.ExMlost37)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST37");
        builder.Property(e => e.ExMlost38)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST38");
        builder.Property(e => e.ExMlost39)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST39");
        builder.Property(e => e.ExMlost4)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST4");
        builder.Property(e => e.ExMlost40)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST40");
        builder.Property(e => e.ExMlost41)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST41");
        builder.Property(e => e.ExMlost42)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST42");
        builder.Property(e => e.ExMlost43)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST43");
        builder.Property(e => e.ExMlost44)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST44");
        builder.Property(e => e.ExMlost45)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST45");
        builder.Property(e => e.ExMlost46)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST46");
        builder.Property(e => e.ExMlost47)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST47");
        builder.Property(e => e.ExMlost48)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST48");
        builder.Property(e => e.ExMlost5)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST5");
        builder.Property(e => e.ExMlost6)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST6");
        builder.Property(e => e.ExMlost7)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST7");
        builder.Property(e => e.ExMlost8)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST8");
        builder.Property(e => e.ExMlost9)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("EX_MLOST9");
        builder.Property(e => e.Gradesreq).HasColumnName("GRADESREQ");
        builder.Property(e => e.Hcsexpress)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("HCSEXPRESS");
        builder.Property(e => e.Hlsexpress)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("HLSEXPRESS");
        builder.Property(e => e.I9compId)
            .HasMaxLength(16)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("I9COMP_ID");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.InitCrims)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("INIT_CRIMS");
        builder.Property(e => e.InitEmpl)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("INIT_EMPL");
        builder.Property(e => e.Jobdutyreq).HasColumnName("JOBDUTYREQ");
        builder.Property(e => e.Jobpayreq).HasColumnName("JOBPAYREQ");
        builder.Property(e => e.Jobtitlreq).HasColumnName("JOBTITLREQ");
        builder.Property(e => e.Majorreq).HasColumnName("MAJORREQ");
        builder.Property(e => e.MaxCrims)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_CRIMS");
        builder.Property(e => e.MaxEmpl)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_EMPL");
        builder.Property(e => e.Nwexpress)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("NWEXPRESS");
        builder.Property(e => e.PasstHist)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("PASST_HIST");
        builder.Property(e => e.PrefStr)
            .HasMaxLength(250)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PREF_STR");
        builder.Property(e => e.Rsnleavreq).HasColumnName("RSNLEAVREQ");
        builder.Property(e => e.Sorexpress)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SOREXPRESS");
        builder.Property(e => e.SpecVal)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("SPEC_VAL");
        builder.Property(e => e.Suprvsrreq).HasColumnName("SUPRVSRREQ");
    }
}