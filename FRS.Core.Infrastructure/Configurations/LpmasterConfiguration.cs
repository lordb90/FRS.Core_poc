using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class LpmasterConfiguration : IEntityTypeConfiguration<Lpmaster>
    {
        public void Configure(EntityTypeBuilder<Lpmaster> builder)
        {
            builder
                .HasNoKey()
                .ToTable("LPMASTER");

            builder.Property(e => e.AaDispute).HasColumnName("AA_DISPUTE");
            builder.Property(e => e.AcctMgr)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ACCT_MGR");
            builder.Property(e => e.Adjucoment)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADJUCOMENT");
            builder.Property(e => e.Adjuemail)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADJUEMAIL");
            builder.Property(e => e.Adjureason)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADJUREASON");
            builder.Property(e => e.Adjustatus)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("ADJUSTATUS");
            builder.Property(e => e.AgeNum)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("AGE_NUM");
            builder.Property(e => e.Aka)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AKA");
            builder.Property(e => e.AkaSpec).HasColumnName("AKA_SPEC");
            builder.Property(e => e.AppEmail)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("APP_EMAIL");
            builder.Property(e => e.AppPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("APP_PHONE");
            builder.Property(e => e.Attach2eml).HasColumnName("ATTACH2EML");
            builder.Property(e => e.AttachDoc)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATTACH_DOC");
            builder.Property(e => e.Attachdttm)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("ATTACHDTTM");
            builder.Property(e => e.Attachorig)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATTACHORIG");
            builder.Property(e => e.Attachuser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATTACHUSER");
            builder.Property(e => e.Attchaudit)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ATTCHAUDIT");
            builder.Property(e => e.Autofreeze).HasColumnName("AUTOFREEZE");
            builder.Property(e => e.BillDtl)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BILL_DTL");
            builder.Property(e => e.Billcode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BILLCODE");
            builder.Property(e => e.Billed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BILLED");
            builder.Property(e => e.Birthdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("BIRTHDATE");
            builder.Property(e => e.Bkgnorechk).HasColumnName("BKGNORECHK");
            builder.Property(e => e.City)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CITY");
            builder.Property(e => e.ComCredit).HasColumnName("COM_CREDIT");
            builder.Property(e => e.ComCrim).HasColumnName("COM_CRIM");
            builder.Property(e => e.ComDmv).HasColumnName("COM_DMV");
            builder.Property(e => e.ComEducat).HasColumnName("COM_EDUCAT");
            builder.Property(e => e.ComEmploy).HasColumnName("COM_EMPLOY");
            builder.Property(e => e.ComMlost).HasColumnName("COM_MLOST");
            builder.Property(e => e.ComPlic).HasColumnName("COM_PLIC");
            builder.Property(e => e.ComSsnver).HasColumnName("COM_SSNVER");
            builder.Property(e => e.ComWkcomp).HasColumnName("COM_WKCOMP");
            builder.Property(e => e.Comments)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMMENTS");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.CompDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("COMP_DATE");
            builder.Property(e => e.CompId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_ID");
            builder.Property(e => e.CompTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_TIME");
            builder.Property(e => e.County1)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNTY_1");
            builder.Property(e => e.CrJoint).HasColumnName("CR_JOINT");
            builder.Property(e => e.CredPflag)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("CRED_PFLAG");
            builder.Property(e => e.CredRes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRED_RES");
            builder.Property(e => e.CredRsumm)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CRED_RSUMM");
            builder.Property(e => e.Customized)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CUSTOMIZED");
            builder.Property(e => e.DailyStat)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DAILY_STAT");
            builder.Property(e => e.DateSent)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DATE_SENT");
            builder.Property(e => e.Delaydeliv)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DELAYDELIV");
            builder.Property(e => e.Deluxefile)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DELUXEFILE");
            builder.Property(e => e.DiscrCred).HasColumnName("DISCR_CRED");
            builder.Property(e => e.DiscrCrim).HasColumnName("DISCR_CRIM");
            builder.Property(e => e.DiscrDmv).HasColumnName("DISCR_DMV");
            builder.Property(e => e.DiscrEduc).HasColumnName("DISCR_EDUC");
            builder.Property(e => e.DiscrEmpl).HasColumnName("DISCR_EMPL");
            builder.Property(e => e.DiscrMlos).HasColumnName("DISCR_MLOS");
            builder.Property(e => e.DiscrNote)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DISCR_NOTE");
            builder.Property(e => e.DiscrOver).HasColumnName("DISCR_OVER");
            builder.Property(e => e.DiscrPlic).HasColumnName("DISCR_PLIC");
            builder.Property(e => e.DiscrSsn).HasColumnName("DISCR_SSN");
            builder.Property(e => e.DiscrWcmp).HasColumnName("DISCR_WCMP");
            builder.Property(e => e.Dispute613).HasColumnName("DISPUTE613");
            builder.Property(e => e.Docmgaudit)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOCMGAUDIT");
            builder.Property(e => e.Dontdelay).HasColumnName("DONTDELAY");
            builder.Property(e => e.ElectSig)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ELECT_SIG");
            builder.Property(e => e.EmailAdj).HasColumnName("EMAIL_ADJ");
            builder.Property(e => e.EmailReq)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMAIL_REQ");
            builder.Property(e => e.EmailThis).HasColumnName("EMAIL_THIS");
            builder.Property(e => e.Everonhold).HasColumnName("EVERONHOLD");
            builder.Property(e => e.ExtraCost)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("EXTRA_COST");
            builder.Property(e => e.ExtraDesc)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXTRA_DESC");
            builder.Property(e => e.ExtraId)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXTRA_ID");
            builder.Property(e => e.ExtraInfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXTRA_INFO");
            builder.Property(e => e.FConlPrt).HasColumnName("F_CONL_PRT");
            builder.Property(e => e.FConltr).HasColumnName("F_CONLTR");
            builder.Property(e => e.FConprtdt)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("F_CONPRTDT");
            builder.Property(e => e.FCredPrt).HasColumnName("F_CRED_PRT");
            builder.Property(e => e.FCredit).HasColumnName("F_CREDIT");
            builder.Property(e => e.FCrim).HasColumnName("F_CRIM");
            builder.Property(e => e.FDmv).HasColumnName("F_DMV");
            builder.Property(e => e.FDmvPrt).HasColumnName("F_DMV_PRT");
            builder.Property(e => e.FEducat).HasColumnName("F_EDUCAT");
            builder.Property(e => e.FEmploy).HasColumnName("F_EMPLOY");
            builder.Property(e => e.FExecut).HasColumnName("F_EXECUT");
            builder.Property(e => e.FMlost).HasColumnName("F_MLOST");
            builder.Property(e => e.FMlostprt).HasColumnName("F_MLOSTPRT");
            builder.Property(e => e.FMlostres).HasColumnName("F_MLOSTRES");
            builder.Property(e => e.FPlic).HasColumnName("F_PLIC");
            builder.Property(e => e.FSsnPrt).HasColumnName("F_SSN_PRT");
            builder.Property(e => e.FSsnver).HasColumnName("F_SSNVER");
            builder.Property(e => e.FWcmpPrt).HasColumnName("F_WCMP_PRT");
            builder.Property(e => e.FWkcomp).HasColumnName("F_WKCOMP");
            builder.Property(e => e.Fname)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FNAME");
            builder.Property(e => e.Freeze)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FREEZE");
            builder.Property(e => e.FullyComp).HasColumnName("FULLY_COMP");
            builder.Property(e => e.HomeKey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("HOME_KEY");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Indicator)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INDICATOR");
            builder.Property(e => e.IntId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_ID");
            builder.Property(e => e.IntTrk1)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_1");
            builder.Property(e => e.IntTrk2)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_2");
            builder.Property(e => e.IntTrk3)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_3");
            builder.Property(e => e.IntTrk4)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_4");
            builder.Property(e => e.IntTrk5)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INT_TRK_5");
            builder.Property(e => e.Internat)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INTERNAT");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.KeySrc)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("KEY_SRC");
            builder.Property(e => e.Linkwebadd)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LINKWEBADD");
            builder.Property(e => e.Lname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LNAME");
            builder.Property(e => e.Lockbyuser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCKBYUSER");
            builder.Property(e => e.Lockdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LOCKDATE");
            builder.Property(e => e.Mname)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MNAME");
            builder.Property(e => e.MstrInv)
                .HasColumnType("numeric(5, 0)")
                .HasColumnName("MSTR_INV");
            builder.Property(e => e.MultDeliv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MULT_DELIV");
            builder.Property(e => e.NopasstSt)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NOPASST_ST");
            builder.Property(e => e.NumStCty)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("NUM_ST_CTY");
            builder.Property(e => e.OnHold).HasColumnName("ON_HOLD");
            builder.Property(e => e.Overall)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OVERALL");
            builder.Property(e => e.PartComp).HasColumnName("PART_COMP");
            builder.Property(e => e.Passfail)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PASSFAIL");
            builder.Property(e => e.PasstAkas)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PASST_AKAS");
            builder.Property(e => e.Position)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("POSITION");
            builder.Property(e => e.Post2web).HasColumnName("POST2WEB");
            builder.Property(e => e.Posted2web).HasColumnName("POSTED2WEB");
            builder.Property(e => e.Posteddttm)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("POSTEDDTTM");
            builder.Property(e => e.PresAddr1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PRES_ADDR1");
            builder.Property(e => e.Price)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("PRICE");
            builder.Property(e => e.Printed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PRINTED");
            builder.Property(e => e.Proof).HasColumnName("PROOF");
            builder.Property(e => e.ProofRstr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROOF_RSTR");
            builder.Property(e => e.ProofWhen)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROOF_WHEN");
            builder.Property(e => e.Quickstat)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("QUICKSTAT");
            builder.Property(e => e.RecDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("REC_DATE");
            builder.Property(e => e.RecFound)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REC_FOUND");
            builder.Property(e => e.RecTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REC_TIME");
            builder.Property(e => e.Reference)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REFERENCE");
            builder.Property(e => e.Reqstrtype)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQSTRTYPE");
            builder.Property(e => e.Reqstrusid)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQSTRUSID");
            builder.Property(e => e.Requestor)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQUESTOR");
            builder.Property(e => e.RetSsnver).HasColumnName("RET_SSNVER");
            builder.Property(e => e.RetresFmt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RETRES_FMT");
            builder.Property(e => e.Rextracost)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("REXTRACOST");
            builder.Property(e => e.Rextradesc)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REXTRADESC");
            builder.Property(e => e.Rush).HasColumnName("RUSH");
            builder.Property(e => e.Salarykey)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SALARYKEY");
            builder.Property(e => e.SentVia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SENT_VIA");
            builder.Property(e => e.Settings)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SETTINGS");
            builder.Property(e => e.Sexrace)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SEXRACE");
            builder.Property(e => e.SksCid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SKS_CID");
            builder.Property(e => e.SpFname)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SP_FNAME");
            builder.Property(e => e.SpLname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SP_LNAME");
            builder.Property(e => e.SpMname)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SP_MNAME");
            builder.Property(e => e.SpSsno)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("SP_SSNO");
            builder.Property(e => e.SpecFilt).HasColumnName("SPEC_FILT");
            builder.Property(e => e.SpecFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SPEC_FLAG");
            builder.Property(e => e.SpecfrsId)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SPECFRS_ID");
            builder.Property(e => e.SrchInstr)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRCH_INSTR");
            builder.Property(e => e.SrchSw).HasColumnName("SRCH_SW");
            builder.Property(e => e.SsnPflag)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("SSN_PFLAG");
            builder.Property(e => e.SsnRes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN_RES");
            builder.Property(e => e.SsnRsumm)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN_RSUMM");
            builder.Property(e => e.Ssno)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("SSNO");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.State1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE_1");
            builder.Property(e => e.SumCredit)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUM_CREDIT");
            builder.Property(e => e.SumCrim)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUM_CRIM");
            builder.Property(e => e.SumDmv)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUM_DMV");
            builder.Property(e => e.SumEducat)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUM_EDUCAT");
            builder.Property(e => e.SumEmploy)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUM_EMPLOY");
            builder.Property(e => e.SumMlost)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUM_MLOST");
            builder.Property(e => e.SumPlic)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUM_PLIC");
            builder.Property(e => e.SumSsnver)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUM_SSNVER");
            builder.Property(e => e.SumWkcomp)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUM_WKCOMP");
            builder.Property(e => e.SuppDoc)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUPP_DOC");
            builder.Property(e => e.SuppDoccl).HasColumnName("SUPP_DOCCL");
            builder.Property(e => e.SuppDocsd).HasColumnName("SUPP_DOCSD");
            builder.Property(e => e.TempPrt)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TEMP_PRT");
            builder.Property(e => e.Tenantinfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TENANTINFO");
            builder.Property(e => e.TimeSent)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TIME_SENT");
            builder.Property(e => e.UnqOrder)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("UNQ_ORDER");
            builder.Property(e => e.WebProof)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEB_PROOF");
            builder.Property(e => e.Wkcmpsum)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WKCMPSUM");
            builder.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ZIP");
        }
    }
}