//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations;

//public class ConrempfConfiguration : IEntityTypeConfiguration<Conrempf>
//{
//    public void Configure(EntityTypeBuilder<Conrempf> builder)
//    {
//        builder.HasNoKey()
//            .ToTable("CONREMPF");

//        builder.Property(e => e.AddlFlags)
//            .HasMaxLength(30)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("ADDL_FLAGS");
//        builder.Property(e => e.Blogo)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("BLOGO");
//        builder.Property(e => e.BmpFile)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("BMP_FILE");
//        builder.Property(e => e.CsRetry)
//            .HasColumnType("numeric(3, 0)")
//            .HasColumnName("CS_RETRY");
//        builder.Property(e => e.DiscCb1).HasColumnName("DISC_CB_1");
//        builder.Property(e => e.DiscFhead)
//            .HasMaxLength(70)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("DISC_FHEAD");
//        builder.Property(e => e.DiscfFnt)
//            .HasColumnType("numeric(1, 0)")
//            .HasColumnName("DISCF_FNT");
//        builder.Property(e => e.DiscfhFnt)
//            .HasColumnType("numeric(1, 0)")
//            .HasColumnName("DISCFH_FNT");
//        builder.Property(e => e.DisclFull)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("DISCL_FULL");
//        builder.Property(e => e.FmBrkout).HasColumnName("FM_BRKOUT");
//        builder.Property(e => e.Id)
//            .ValueGeneratedOnAdd()
//            .HasColumnName("ID");
//        builder.Property(e => e.InclExsum).HasColumnName("INCL_EXSUM");
//        builder.Property(e => e.KeyToRef).HasColumnName("KEY_TO_REF");
//        builder.Property(e => e.Logo).HasColumnName("LOGO");
//        builder.Property(e => e.Mlogo)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("MLOGO");
//        builder.Property(e => e.PfAka).HasColumnName("PF_AKA");
//        builder.Property(e => e.PfFCredi).HasColumnName("PF_F_CREDI");
//        builder.Property(e => e.PfFCrim).HasColumnName("PF_F_CRIM");
//        builder.Property(e => e.PfFDmv).HasColumnName("PF_F_DMV");
//        builder.Property(e => e.PfFEduca).HasColumnName("PF_F_EDUCA");
//        builder.Property(e => e.PfFEmplo).HasColumnName("PF_F_EMPLO");
//        builder.Property(e => e.PfFExecu).HasColumnName("PF_F_EXECU");
//        builder.Property(e => e.PfFMlost).HasColumnName("PF_F_MLOST");
//        builder.Property(e => e.PfFPlic).HasColumnName("PF_F_PLIC");
//        builder.Property(e => e.PfFSsnve).HasColumnName("PF_F_SSNVE");
//        builder.Property(e => e.PfFWkcom).HasColumnName("PF_F_WKCOM");
//        builder.Property(e => e.PfFed).HasColumnName("PF_FED");
//        builder.Property(e => e.PfFel).HasColumnName("PF_FEL");
//        builder.Property(e => e.PfLc).HasColumnName("PF_LC");
//        builder.Property(e => e.PfMisd).HasColumnName("PF_MISD");
//        builder.Property(e => e.PfOth).HasColumnName("PF_OTH");
//        builder.Property(e => e.PfREx).HasColumnName("PF_R_EX");
//        builder.Property(e => e.PfRelease).HasColumnName("PF_RELEASE");
//        builder.Property(e => e.PfRush).HasColumnName("PF_RUSH");
//        builder.Property(e => e.PfRushDe)
//            .HasMaxLength(60)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("PF_RUSH_DE");
//        builder.Property(e => e.PfUc).HasColumnName("PF_UC");
//        builder.Property(e => e.Pw)
//            .HasMaxLength(10)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("PW");
//        builder.Property(e => e.Ref2Labl)
//            .HasMaxLength(13)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("REF_2_LABL");
//        builder.Property(e => e.RemPartia).HasColumnName("REM_PARTIA");
//    }
//}