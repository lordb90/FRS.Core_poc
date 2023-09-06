using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class BlcdcompConfiguration : IEntityTypeConfiguration<Blcdcomp>
{
    public void Configure(EntityTypeBuilder<Blcdcomp> builder)
    {
        builder
            .HasNoKey()
            .ToTable("BLCDCOMP");

        builder.Property(e => e.AkaChgTy)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("AKA_CHG_TY");
        builder.Property(e => e.AkaFlatrt)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("AKA_FLATRT");
        builder.Property(e => e.Billcode)
            .HasMaxLength(10)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("BILLCODE");
        builder.Property(e => e.CompCode)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COMP_CODE");
        builder.Property(e => e.CreditOop).HasColumnName("CREDIT_OOP");
        builder.Property(e => e.Defmlost1)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST1");
        builder.Property(e => e.Defmlost10)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST10");
        builder.Property(e => e.Defmlost11)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST11");
        builder.Property(e => e.Defmlost12)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST12");
        builder.Property(e => e.Defmlost13)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST13");
        builder.Property(e => e.Defmlost14)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST14");
        builder.Property(e => e.Defmlost15)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST15");
        builder.Property(e => e.Defmlost16)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST16");
        builder.Property(e => e.Defmlost17)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST17");
        builder.Property(e => e.Defmlost18)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST18");
        builder.Property(e => e.Defmlost19)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST19");
        builder.Property(e => e.Defmlost2)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST2");
        builder.Property(e => e.Defmlost20)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST20");
        builder.Property(e => e.Defmlost3)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST3");
        builder.Property(e => e.Defmlost4)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST4");
        builder.Property(e => e.Defmlost5)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST5");
        builder.Property(e => e.Defmlost6)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST6");
        builder.Property(e => e.Defmlost7)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST7");
        builder.Property(e => e.Defmlost8)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST8");
        builder.Property(e => e.Defmlost9)
            .HasMaxLength(30)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("DEFMLOST9");
        builder.Property(e => e.FCredit).HasColumnName("F_CREDIT");
        builder.Property(e => e.FCrim).HasColumnName("F_CRIM");
        builder.Property(e => e.FDmv).HasColumnName("F_DMV");
        builder.Property(e => e.FEducat).HasColumnName("F_EDUCAT");
        builder.Property(e => e.FEmploy).HasColumnName("F_EMPLOY");
        builder.Property(e => e.FExecut).HasColumnName("F_EXECUT");
        builder.Property(e => e.FMlost).HasColumnName("F_MLOST");
        builder.Property(e => e.FPlic).HasColumnName("F_PLIC");
        builder.Property(e => e.FSsnver).HasColumnName("F_SSNVER");
        builder.Property(e => e.FWkcomp).HasColumnName("F_WKCOMP");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
        builder.Property(e => e.Inactive)
            .HasMaxLength(1)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("INACTIVE");
        builder.Property(e => e.Incstinpkg)
            .HasMaxLength(150)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("INCSTINPKG");
        builder.Property(e => e.InteducCk).HasColumnName("INTEDUC_CK");
        builder.Property(e => e.InteducPr)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("INTEDUC_PR");
        builder.Property(e => e.IntemplCk).HasColumnName("INTEMPL_CK");
        builder.Property(e => e.IntemplPr)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("INTEMPL_PR");
        builder.Property(e => e.MaxAka)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_AKA");
        builder.Property(e => e.MaxCrim)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_CRIM");
        builder.Property(e => e.MaxCvl)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_CVL");
        builder.Property(e => e.MaxEduc)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_EDUC");
        builder.Property(e => e.MaxEmpl)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_EMPL");
        builder.Property(e => e.MaxFed)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_FED");
        builder.Property(e => e.MaxMlost)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_MLOST");
        builder.Property(e => e.MaxMvr)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_MVR");
        builder.Property(e => e.MaxOth)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_OTH");
        builder.Property(e => e.MaxPlic)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_PLIC");
        builder.Property(e => e.MaxSw)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_SW");
        builder.Property(e => e.MaxWkcmp)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("MAX_WKCMP");
        builder.Property(e => e.Price)
            .HasColumnType("numeric(8, 2)")
            .HasColumnName("PRICE");
        builder.Property(e => e.PstAcAsn).HasColumnName("PST_AC_ASN");
        builder.Property(e => e.PstCivlow).HasColumnName("PST_CIVLOW");
        builder.Property(e => e.PstCivupp).HasColumnName("PST_CIVUPP");
        builder.Property(e => e.PstCtyNa).HasColumnName("PST_CTY_NA");
        builder.Property(e => e.PstCtyasn)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("PST_CTYASN");
        builder.Property(e => e.PstCtynbr)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("PST_CTYNBR");
        builder.Property(e => e.PstCtysrc)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("PST_CTYSRC");
        builder.Property(e => e.PstCtytoo).HasColumnName("PST_CTYTOO");
        builder.Property(e => e.PstCtyyrs)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("PST_CTYYRS");
        builder.Property(e => e.PstCurasn).HasColumnName("PST_CURASN");
        builder.Property(e => e.PstCurfed).HasColumnName("PST_CURFED");
        builder.Property(e => e.PstFedasn)
            .HasColumnType("numeric(1, 0)")
            .HasColumnName("PST_FEDASN");
        builder.Property(e => e.PstFednbr)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("PST_FEDNBR");
        builder.Property(e => e.PstFedyrs)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("PST_FEDYRS");
        builder.Property(e => e.PstFulsta).HasColumnName("PST_FULSTA");
        builder.Property(e => e.PstFysrch)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PST_FYSRCH");
        builder.Property(e => e.PstInccty).HasColumnName("PST_INCCTY");
        builder.Property(e => e.PstMaxSw)
            .HasColumnType("numeric(2, 0)")
            .HasColumnName("PST_MAX_SW");
        builder.Property(e => e.PstOrdSw).HasColumnName("PST_ORD_SW");
        builder.Property(e => e.PstSupSw)
            .HasMaxLength(175)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PST_SUP_SW");
        builder.Property(e => e.PstSwAsn).HasColumnName("PST_SW_ASN");
        builder.Property(e => e.PstUsepkg).HasColumnName("PST_USEPKG");
        builder.Property(e => e.PstYrsrch)
            .HasMaxLength(35)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("PST_YRSRCH");
        builder.Property(e => e.Pstshowsum).HasColumnName("PSTSHOWSUM");
        builder.Property(e => e.SetOrder).HasColumnName("SET_ORDER");
        builder.Property(e => e.SsnverOop).HasColumnName("SSNVER_OOP");
    }
}