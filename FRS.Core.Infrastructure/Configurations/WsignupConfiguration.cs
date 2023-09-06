using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WsignupConfiguration : IEntityTypeConfiguration<Wsignup>
    {
        public void Configure(EntityTypeBuilder<Wsignup> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WSIGNUP");

            builder.Property(e => e.Address1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDRESS1");
            builder.Property(e => e.BcEmail)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BC_EMAIL");
            builder.Property(e => e.BcFax1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BC_FAX1");
            builder.Property(e => e.BcFax2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BC_FAX2");
            builder.Property(e => e.BcFax3)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BC_FAX3");
            builder.Property(e => e.BcName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BC_NAME");
            builder.Property(e => e.BcPhExt)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BC_PH_EXT");
            builder.Property(e => e.BcPhone1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BC_PHONE1");
            builder.Property(e => e.BcPhone2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BC_PHONE2");
            builder.Property(e => e.BcPhone3)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BC_PHONE3");
            builder.Property(e => e.BcTitle)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BC_TITLE");
            builder.Property(e => e.Bcaddress)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BCADDRESS");
            builder.Property(e => e.Bcity)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BCITY");
            builder.Property(e => e.Bstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BSTATE");
            builder.Property(e => e.BusType)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BUS_TYPE");
            builder.Property(e => e.Bzip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BZIP");
            builder.Property(e => e.City)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CITY");
            builder.Property(e => e.Comments)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMMENTS");
            builder.Property(e => e.CompName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_NAME");
            builder.Property(e => e.CompType)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_TYPE");
            builder.Property(e => e.CurrPerf)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CURR_PERF");
            builder.Property(e => e.DateForm)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DATE_FORM");
            builder.Property(e => e.DbNbr)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DB_NBR");
            builder.Property(e => e.HowHear)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HOW_HEAR");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.IntendUse)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INTEND_USE");
            builder.Property(e => e.LogEmail)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOG_EMAIL");
            builder.Property(e => e.LogName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOG_NAME");
            builder.Property(e => e.LogPw)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOG_PW");
            builder.Property(e => e.LogUname)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOG_UNAME");
            builder.Property(e => e.NbrEmpl)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NBR_EMPL");
            builder.Property(e => e.NbrLoc)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NBR_LOC");
            builder.Property(e => e.NewHires)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NEW_HIRES");
            builder.Property(e => e.NonProfit)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("NON_PROFIT");
            builder.Property(e => e.Otherinfo1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTHERINFO1");
            builder.Property(e => e.Otherinfo2)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTHERINFO2");
            builder.Property(e => e.Otherinfo3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTHERINFO3");
            builder.Property(e => e.Otherinfo4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTHERINFO4");
            builder.Property(e => e.Otherinfo5)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTHERINFO5");
            builder.Property(e => e.Otherinfo6)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTHERINFO6");
            builder.Property(e => e.Otherinfo7)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTHERINFO7");
            builder.Property(e => e.Otherinfo8)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTHERINFO8");
            builder.Property(e => e.Otherinfo9)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTHERINFO9");
            builder.Property(e => e.PcEmail)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PC_EMAIL");
            builder.Property(e => e.PcFax1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PC_FAX1");
            builder.Property(e => e.PcFax2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PC_FAX2");
            builder.Property(e => e.PcFax3)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PC_FAX3");
            builder.Property(e => e.PcName)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PC_NAME");
            builder.Property(e => e.PcPhExt)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PC_PH_EXT");
            builder.Property(e => e.PcPhone1)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PC_PHONE1");
            builder.Property(e => e.PcPhone2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PC_PHONE2");
            builder.Property(e => e.PcPhone3)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PC_PHONE3");
            builder.Property(e => e.PcTitle)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PC_TITLE");
            builder.Property(e => e.Pcbesttime)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PCBESTTIME");
            builder.Property(e => e.Pcdecisyn)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PCDECISYN");
            builder.Property(e => e.Pcdecmaker)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PCDECMAKER");
            builder.Property(e => e.ProcDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("PROC_DATE");
            builder.Property(e => e.Processed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROCESSED");
            builder.Property(e => e.ReasCost)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REAS_COST");
            builder.Property(e => e.ReasOth)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REAS_OTH");
            builder.Property(e => e.ReasServ)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REAS_SERV");
            builder.Property(e => e.ReasTa)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REAS_TA");
            builder.Property(e => e.RecvDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("RECV_DATE");
            builder.Property(e => e.ScreensYr)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SCREENS_YR");
            builder.Property(e => e.ServBgchk)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_BGCHK");
            builder.Property(e => e.ServCivil)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_CIVIL");
            builder.Property(e => e.ServCred)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_CRED");
            builder.Property(e => e.ServCrim)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_CRIM");
            builder.Property(e => e.ServDbase)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_DBASE");
            builder.Property(e => e.ServDrugs)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_DRUGS");
            builder.Property(e => e.ServEduc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_EDUC");
            builder.Property(e => e.ServEmpl)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_EMPL");
            builder.Property(e => e.ServFed)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_FED");
            builder.Property(e => e.ServFi9)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_FI9");
            builder.Property(e => e.ServMvr)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_MVR");
            builder.Property(e => e.ServOst1)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST1");
            builder.Property(e => e.ServOst10)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST10");
            builder.Property(e => e.ServOst11)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST11");
            builder.Property(e => e.ServOst12)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST12");
            builder.Property(e => e.ServOst13)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST13");
            builder.Property(e => e.ServOst14)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST14");
            builder.Property(e => e.ServOst15)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST15");
            builder.Property(e => e.ServOst16)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST16");
            builder.Property(e => e.ServOst17)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST17");
            builder.Property(e => e.ServOst18)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST18");
            builder.Property(e => e.ServOst19)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST19");
            builder.Property(e => e.ServOst2)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST2");
            builder.Property(e => e.ServOst20)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST20");
            builder.Property(e => e.ServOst21)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST21");
            builder.Property(e => e.ServOst22)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST22");
            builder.Property(e => e.ServOst23)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST23");
            builder.Property(e => e.ServOst24)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST24");
            builder.Property(e => e.ServOst25)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST25");
            builder.Property(e => e.ServOst26)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST26");
            builder.Property(e => e.ServOst27)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST27");
            builder.Property(e => e.ServOst28)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST28");
            builder.Property(e => e.ServOst29)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST29");
            builder.Property(e => e.ServOst3)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST3");
            builder.Property(e => e.ServOst30)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST30");
            builder.Property(e => e.ServOst31)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST31");
            builder.Property(e => e.ServOst32)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST32");
            builder.Property(e => e.ServOst4)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST4");
            builder.Property(e => e.ServOst5)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST5");
            builder.Property(e => e.ServOst6)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST6");
            builder.Property(e => e.ServOst7)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST7");
            builder.Property(e => e.ServOst8)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST8");
            builder.Property(e => e.ServOst9)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_OST9");
            builder.Property(e => e.ServPlic)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_PLIC");
            builder.Property(e => e.ServSsn)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_SSN");
            builder.Property(e => e.ServWkcmp)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SERV_WKCMP");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.StateForm)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE_FORM");
            builder.Property(e => e.StateId)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE_ID");
            builder.Property(e => e.TaxId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TAX_ID");
            builder.Property(e => e.Timeframe)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TIMEFRAME");
            builder.Property(e => e.Turnover)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TURNOVER");
            builder.Property(e => e.Website)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEBSITE");
            builder.Property(e => e.YrsInBus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("YRS_IN_BUS");
            builder.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ZIP");
        }
    }
}