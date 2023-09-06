using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WebgroupConfiguration : IEntityTypeConfiguration<Webgroup>
    {
        public void Configure(EntityTypeBuilder<Webgroup> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WEBGROUP");

            builder.Property(e => e.AllowReqs).HasColumnName("ALLOW_REQS");
            builder.Property(e => e.ApGrading).HasColumnName("AP_GRADING");
            builder.Property(e => e.BpaGen).HasColumnName("BPA_GEN");
            builder.Property(e => e.ChangePf).HasColumnName("CHANGE_PF");
            builder.Property(e => e.Desc)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
            builder.Property(e => e.Emailaddr)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMAILADDR");
            builder.Property(e => e.GroupName)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("GROUP_NAME");
            builder.Property(e => e.I9compId)
                .HasMaxLength(240)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("I9COMP_ID");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Members)
                .HasColumnType("numeric(4, 0)")
                .HasColumnName("MEMBERS");
            builder.Property(e => e.MgrPhone)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MGR_PHONE");
            builder.Property(e => e.Mstrgroup)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MSTRGROUP");
            builder.Property(e => e.Password)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PASSWORD");
            builder.Property(e => e.PrefAccts).HasColumnName("PREF_ACCTS");
            builder.Property(e => e.PrefAdver).HasColumnName("PREF_ADVER");
            builder.Property(e => e.PrefAfail).HasColumnName("PREF_AFAIL");
            builder.Property(e => e.PrefAmc).HasColumnName("PREF_AMC");
            builder.Property(e => e.PrefAself).HasColumnName("PREF_ASELF");
            builder.Property(e => e.PrefBill).HasColumnName("PREF_BILL");
            builder.Property(e => e.PrefCdate).HasColumnName("PREF_CDATE");
            builder.Property(e => e.PrefDelrs).HasColumnName("PREF_DELRS");
            builder.Property(e => e.PrefDsprs).HasColumnName("PREF_DSPRS");
            builder.Property(e => e.PrefEmlrs).HasColumnName("PREF_EMLRS");
            builder.Property(e => e.PrefEvp).HasColumnName("PREF_EVP");
            builder.Property(e => e.PrefHtml).HasColumnName("PREF_HTML");
            builder.Property(e => e.PrefI9).HasColumnName("PREF_I9");
            builder.Property(e => e.PrefInter).HasColumnName("PREF_INTER");
            builder.Property(e => e.PrefMask).HasColumnName("PREF_MASK");
            builder.Property(e => e.PrefMfa).HasColumnName("PREF_MFA");
            builder.Property(e => e.PrefMovrs).HasColumnName("PREF_MOVRS");
            builder.Property(e => e.PrefNotes).HasColumnName("PREF_NOTES");
            builder.Property(e => e.PrefPrevw).HasColumnName("PREF_PREVW");
            builder.Property(e => e.PrefRpts).HasColumnName("PREF_RPTS");
            builder.Property(e => e.PrefStrpw).HasColumnName("PREF_STRPW");
            builder.Property(e => e.PrefSuper).HasColumnName("PREF_SUPER");
            builder.Property(e => e.PrefTrnhr).HasColumnName("PREF_TRNHR");
            builder.Property(e => e.PrefWord).HasColumnName("PREF_WORD");
            builder.Property(e => e.PrevRslts).HasColumnName("PREV_RSLTS");
            builder.Property(e => e.PrevTscrn).HasColumnName("PREV_TSCRN");
            builder.Property(e => e.PrevVtsal).HasColumnName("PREV_VTSAL");
            builder.Property(e => e.Requestor)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("REQUESTOR");
            builder.Property(e => e.Typpwcrypt)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPPWCRYPT");
            builder.Property(e => e.Useblueorg).HasColumnName("USEBLUEORG");
            builder.Property(e => e.ViewPf).HasColumnName("VIEW_PF");
            builder.Property(e => e.Welcomemsg)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WELCOMEMSG");
        }
    }
}