using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class OthstypeConfiguration : IEntityTypeConfiguration<Othstype>
    {
        public void Configure(EntityTypeBuilder<Othstype> builder)
        {
            builder
                .HasNoKey()
                .ToTable("OTHSTYPE");

            builder.Property(e => e.Allowautop).HasColumnName("ALLOWAUTOP");
            builder.Property(e => e.County)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNTY");
            builder.Property(e => e.Desc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESC");
            builder.Property(e => e.DlinxA7y)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_A7Y");
            builder.Property(e => e.DlinxA7yn)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_A7YN");
            builder.Property(e => e.DlinxA7ys)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_A7YS");
            builder.Property(e => e.DlinxAka).HasColumnName("DLINX_AKA");
            builder.Property(e => e.DlinxAscd)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINX_ASCD");
            builder.Property(e => e.DlinxCode)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINX_CODE");
            builder.Property(e => e.DlinxDob)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_DOB");
            builder.Property(e => e.DlinxE7y)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_E7Y");
            builder.Property(e => e.DlinxNmtc)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_NMTC");
            builder.Property(e => e.DlinxProb)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINX_PROB");
            builder.Property(e => e.DlinxPw)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINX_PW");
            builder.Property(e => e.DlinxSpec)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_SPEC");
            builder.Property(e => e.DlinxUser)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINX_USER");
            builder.Property(e => e.DlinxXtr2)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTR2");
            builder.Property(e => e.DlinxXtr3)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTR3");
            builder.Property(e => e.DlinxXtr4)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTR4");
            builder.Property(e => e.DlinxXtra)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("DLINX_XTRA");
            builder.Property(e => e.Dlinxovral).HasColumnName("DLINXOVRAL");
            builder.Property(e => e.Dlinxstate)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DLINXSTATE");
            builder.Property(e => e.Dlxbillaka).HasColumnName("DLXBILLAKA");
            builder.Property(e => e.Dlxblakait).HasColumnName("DLXBLAKAIT");
            builder.Property(e => e.EclCrit)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ECL_CRIT");
            builder.Property(e => e.ExtraCost)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("EXTRA_COST");
            builder.Property(e => e.ExtraDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXTRA_DESC");
            builder.Property(e => e.Formatweb).HasColumnName("FORMATWEB");
            builder.Property(e => e.HelpNbr)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("HELP_NBR");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.InstrSet)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("INSTR_SET");
            builder.Property(e => e.MlOrCl)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ML_OR_CL");
            builder.Property(e => e.OstCd)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OST_CD");
            builder.Property(e => e.Settings)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SETTINGS");
            builder.Property(e => e.StCSetup).HasColumnName("ST_C_SETUP");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.StdForm)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STD_FORM");
            builder.Property(e => e.SupprRes)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("SUPPR_RES");
            builder.Property(e => e.WebOrder)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("WEB_ORDER");
            builder.Property(e => e.WebReq)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WEB_REQ");
            builder.Property(e => e.WebSkip).HasColumnName("WEB_SKIP");
        }
    }
}