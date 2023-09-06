using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder
                .HasNoKey()
                .ToTable("USERS");

            builder.Property(e => e.ABilling).HasColumnName("A_BILLING");
            builder.Property(e => e.AExprtcli).HasColumnName("A_EXPRTCLI");
            builder.Property(e => e.AFrsusers).HasColumnName("A_FRSUSERS");
            builder.Property(e => e.AMreports).HasColumnName("A_MREPORTS");
            builder.Property(e => e.APurge).HasColumnName("A_PURGE");
            builder.Property(e => e.AWeblogin).HasColumnName("A_WEBLOGIN");
            builder.Property(e => e.AcctMgr)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ACCT_MGR");
            builder.Property(e => e.AddedBy)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDED_BY");
            builder.Property(e => e.AffCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AFF_CODE");
            builder.Property(e => e.Affiliate).HasColumnName("AFFILIATE");
            builder.Property(e => e.Afflbltype)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AFFLBLTYPE");
            builder.Property(e => e.Bocompcode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("BOCOMPCODE");
            builder.Property(e => e.ConNotify).HasColumnName("CON_NOTIFY");
            builder.Property(e => e.DateAdd)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("DATE_ADD");
            builder.Property(e => e.Filter1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER1");
            builder.Property(e => e.Filter10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER10");
            builder.Property(e => e.Filter11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER11");
            builder.Property(e => e.Filter12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER12");
            builder.Property(e => e.Filter13)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER13");
            builder.Property(e => e.Filter14)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER14");
            builder.Property(e => e.Filter15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER15");
            builder.Property(e => e.Filter16)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER16");
            builder.Property(e => e.Filter17)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER17");
            builder.Property(e => e.Filter18)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER18");
            builder.Property(e => e.Filter19)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER19");
            builder.Property(e => e.Filter2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER2");
            builder.Property(e => e.Filter20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER20");
            builder.Property(e => e.Filter3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER3");
            builder.Property(e => e.Filter4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER4");
            builder.Property(e => e.Filter5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER5");
            builder.Property(e => e.Filter6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER6");
            builder.Property(e => e.Filter7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER7");
            builder.Property(e => e.Filter8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER8");
            builder.Property(e => e.Filter9)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTER9");
            builder.Property(e => e.Filtname1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME1");
            builder.Property(e => e.Filtname10)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME10");
            builder.Property(e => e.Filtname11)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME11");
            builder.Property(e => e.Filtname12)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME12");
            builder.Property(e => e.Filtname13)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME13");
            builder.Property(e => e.Filtname14)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME14");
            builder.Property(e => e.Filtname15)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME15");
            builder.Property(e => e.Filtname16)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME16");
            builder.Property(e => e.Filtname17)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME17");
            builder.Property(e => e.Filtname18)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME18");
            builder.Property(e => e.Filtname19)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME19");
            builder.Property(e => e.Filtname2)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME2");
            builder.Property(e => e.Filtname20)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME20");
            builder.Property(e => e.Filtname3)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME3");
            builder.Property(e => e.Filtname4)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME4");
            builder.Property(e => e.Filtname5)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME5");
            builder.Property(e => e.Filtname6)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME6");
            builder.Property(e => e.Filtname7)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME7");
            builder.Property(e => e.Filtname8)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME8");
            builder.Property(e => e.Filtname9)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FILTNAME9");
            builder.Property(e => e.Fullname)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FULLNAME");
            builder.Property(e => e.HiSec).HasColumnName("HI_SEC");
            builder.Property(e => e.History)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("HISTORY");
            builder.Property(e => e.Initials)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INITIALS");
            builder.Property(e => e.Lastpwdt)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LASTPWDT");
            builder.Property(e => e.Loginfails)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("LOGINFAILS");
            builder.Property(e => e.Nuclear).HasColumnName("NUCLEAR");
            builder.Property(e => e.Onhold).HasColumnName("ONHOLD");
            builder.Property(e => e.ProcIhits).HasColumnName("PROC_IHITS");
            builder.Property(e => e.ProcMngmt).HasColumnName("PROC_MNGMT");
            builder.Property(e => e.ProcProfs).HasColumnName("PROC_PROFS");
            builder.Property(e => e.ProcSubjs).HasColumnName("PROC_SUBJS");
            builder.Property(e => e.Processor).HasColumnName("PROCESSOR");
            builder.Property(e => e.Reminddate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("REMINDDATE");
            builder.Property(e => e.RstrctEdt).HasColumnName("RSTRCT_EDT");
            builder.Property(e => e.Rsvdclient).HasColumnName("RSVDCLIENT");
            builder.Property(e => e.Setapgrade).HasColumnName("SETAPGRADE");
            builder.Property(e => e.Showcharge).HasColumnName("SHOWCHARGE");
            builder.Property(e => e.Shownew).HasColumnName("SHOWNEW");
            builder.Property(e => e.UResCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("U_RES_CODE");
            builder.Property(e => e.UserEmail)
                .HasMaxLength(254)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USER_EMAIL");
            builder.Property(e => e.UserKey)
                .ValueGeneratedOnAdd()
                .HasColumnName("USER_KEY");
            builder.Property(e => e.Userid)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERID");
            builder.Property(e => e.Userpasswd)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERPASSWD");
            builder.Property(e => e.Userprefs)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("USERPREFS");
        }
    }
}