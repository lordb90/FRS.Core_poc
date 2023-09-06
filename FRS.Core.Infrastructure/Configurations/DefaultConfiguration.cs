using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class DefaultConfiguration : IEntityTypeConfiguration<Default>
    {
        public void Configure(EntityTypeBuilder<Default> builder)
        {
            builder
                .HasNoKey()
                .ToTable("DEFAULTS");

            builder.Property(e => e.CmcvFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CMCV_FLAG");
            builder.Property(e => e.Cntyoptflg)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("CNTYOPTFLG");
            builder.Property(e => e.ConfirmOn).HasColumnName("CONFIRM_ON");
            builder.Property(e => e.CrimOnly).HasColumnName("CRIM_ONLY");
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
            builder.Property(e => e.NextField)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("NEXT_FIELD");
            builder.Property(e => e.OthDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OTH_DESC");
            builder.Property(e => e.Rush).HasColumnName("RUSH");
            builder.Property(e => e.SrchFed).HasColumnName("SRCH_FED");
            builder.Property(e => e.SrchFel).HasColumnName("SRCH_FEL");
            builder.Property(e => e.SrchLc).HasColumnName("SRCH_LC");
            builder.Property(e => e.SrchMisd).HasColumnName("SRCH_MISD");
            builder.Property(e => e.SrchOth).HasColumnName("SRCH_OTH");
            builder.Property(e => e.SrchSw).HasColumnName("SRCH_SW");
            builder.Property(e => e.SrchUc).HasColumnName("SRCH_UC");
            builder.Property(e => e.Yesrectype)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("YESRECTYPE");

        }
    }
}