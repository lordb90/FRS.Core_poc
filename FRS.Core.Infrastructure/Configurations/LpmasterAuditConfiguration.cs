using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class LpmasterAuditConfiguration : IEntityTypeConfiguration<LpmasterAudit>
    {
        public void Configure(EntityTypeBuilder<LpmasterAudit> builder)
        {
            builder
                .HasNoKey()
                .ToTable("LPMASTER_AUDIT");

            builder.Property(e => e.AaDispute).HasColumnName("AA_DISPUTE");
            builder.Property(e => e.AcctMgr)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ACCT_MGR");
            builder.Property(e => e.AgeNum)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("AGE_NUM");
            builder.Property(e => e.Aka)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AKA");
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
            builder.Property(e => e.City)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CITY");
            builder.Property(e => e.ComCredit).HasColumnName("COM_CREDIT");
            builder.Property(e => e.ComDmv).HasColumnName("COM_DMV");
            builder.Property(e => e.ComMlost).HasColumnName("COM_MLOST");
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
            builder.Property(e => e.DateSent)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DATE_SENT");
            builder.Property(e => e.DiscrOver).HasColumnName("DISCR_OVER");
            builder.Property(e => e.FConltr).HasColumnName("F_CONLTR");
            builder.Property(e => e.FConprtdt)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("F_CONPRTDT");
            builder.Property(e => e.FCredPrt).HasColumnName("F_CRED_PRT");
            builder.Property(e => e.FCredit).HasColumnName("F_CREDIT");
            builder.Property(e => e.FDmv).HasColumnName("F_DMV");
            builder.Property(e => e.FDmvPrt).HasColumnName("F_DMV_PRT");
            builder.Property(e => e.FMlost).HasColumnName("F_MLOST");
            builder.Property(e => e.FMlostprt).HasColumnName("F_MLOSTPRT");
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
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
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
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Lname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LNAME");
            builder.Property(e => e.Mname)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MNAME");
            builder.Property(e => e.MultDeliv)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MULT_DELIV");
            builder.Property(e => e.NumStCty)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("NUM_ST_CTY");
            builder.Property(e => e.OnHold).HasColumnName("ON_HOLD");
            builder.Property(e => e.Position)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("POSITION");
            builder.Property(e => e.PresAddr1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PRES_ADDR1");
            builder.Property(e => e.Printed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PRINTED");
            builder.Property(e => e.Proof).HasColumnName("PROOF");
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
            builder.Property(e => e.Requestor)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQUESTOR");
            builder.Property(e => e.SentVia)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SENT_VIA");
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
            builder.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ZIP");
        }
    }
}