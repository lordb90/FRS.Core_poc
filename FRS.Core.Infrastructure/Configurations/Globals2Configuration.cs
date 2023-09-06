using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class Globals2Configuration : IEntityTypeConfiguration<Globals2>
    {
        public void Configure(EntityTypeBuilder<Globals2> builder)
        {
            builder
                .HasNoKey()
                .ToTable("GLOBALS2");

            builder.Property(e => e.Alt15name)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ALT15NAME");
            builder.Property(e => e.Blmloreord).HasColumnName("BLMLOREORD");
            builder.Property(e => e.Cltemlbody)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CLTEMLBODY");
            builder.Property(e => e.Cltemlsubj)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CLTEMLSUBJ");
            builder.Property(e => e.Disablerpd).HasColumnName("DISABLERPD");
            builder.Property(e => e.EmlRaVer)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EML_RA_VER");
            builder.Property(e => e.Emlnewcli)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EMLNEWCLI");
            builder.Property(e => e.FrzI3scrn).HasColumnName("FRZ_I3SCRN");
            builder.Property(e => e.FrzRpdref).HasColumnName("FRZ_RPDREF");
            builder.Property(e => e.I3scrnost)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("I3SCRNOST");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Lockbyuser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCKBYUSER");
            builder.Property(e => e.Lockdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LOCKDATE");
            builder.Property(e => e.Ltr613F1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LTR613_F1");
            builder.Property(e => e.Ltr613adr1)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LTR613ADR1");
            builder.Property(e => e.Ltr613adr2)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LTR613ADR2");
            builder.Property(e => e.Ltr613adr3)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LTR613ADR3");
            builder.Property(e => e.Ltr613adr4)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LTR613ADR4");
            builder.Property(e => e.Ltr613esub)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LTR613ESUB");
            builder.Property(e => e.Ltr613logo)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LTR613LOGO");
            builder.Property(e => e.Ltr613nme)
                .HasMaxLength(35)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LTR613NME");
            builder.Property(e => e.Ltr613ost)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LTR613OST");
            builder.Property(e => e.Maskssnrep).HasColumnName("MASKSSNREP");
            builder.Property(e => e.MvrCAcct)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVR_C_ACCT");
            builder.Property(e => e.MvrCDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("MVR_C_DATE");
            builder.Property(e => e.MvrCPass)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVR_C_PASS");
            builder.Property(e => e.MvrCUrl)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVR_C_URL");
            builder.Property(e => e.MvrCUser)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MVR_C_USER");
            builder.Property(e => e.Piidopurge).HasColumnName("PIIDOPURGE");
            builder.Property(e => e.Piipurgeis)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PIIPURGEIS");
            builder.Property(e => e.Premiumdlx).HasColumnName("PREMIUMDLX");
            builder.Property(e => e.Prevdisput).HasColumnName("PREVDISPUT");
            builder.Property(e => e.Prntfrndly).HasColumnName("PRNTFRNDLY");
            builder.Property(e => e.Rpdcmpyid)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RPDCMPYID");
            builder.Property(e => e.Rpdrefost)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RPDREFOST");
            builder.Property(e => e.Settings)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SETTINGS");
            builder.Property(e => e.Sti2016)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STI2016");
            builder.Property(e => e.Stipasdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("STIPASDATE");
            builder.Property(e => e.Stipasword)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STIPASWORD");
            builder.Property(e => e.Suprdobedu).HasColumnName("SUPRDOBEDU");
            builder.Property(e => e.Suprdobemp).HasColumnName("SUPRDOBEMP");
            builder.Property(e => e.Suprdobpli).HasColumnName("SUPRDOBPLI");
        }
    }
}