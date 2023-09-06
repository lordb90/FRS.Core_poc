using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WrgreadyConfiguration : IEntityTypeConfiguration<Wrgready>
    {
        public void Configure(EntityTypeBuilder<Wrgready> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WRGREADY");

            builder.Property(e => e.BkupTries)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("BKUP_TRIES");
            builder.Property(e => e.EmailId)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("EMAIL_ID");
            builder.Property(e => e.GenDaily).HasColumnName("GEN_DAILY");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.LinxmlId)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LINXML_ID");
            builder.Property(e => e.Lockbyuser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LOCKBYUSER");
            builder.Property(e => e.Lockdate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("LOCKDATE");
            builder.Property(e => e.Lpbackup).HasColumnName("LPBACKUP");
            builder.Property(e => e.PrCred).HasColumnName("PR_CRED");
            builder.Property(e => e.PrCrim).HasColumnName("PR_CRIM");
            builder.Property(e => e.PrDisc).HasColumnName("PR_DISC");
            builder.Property(e => e.PrDmv).HasColumnName("PR_DMV");
            builder.Property(e => e.PrEduc).HasColumnName("PR_EDUC");
            builder.Property(e => e.PrEmpl).HasColumnName("PR_EMPL");
            builder.Property(e => e.PrExec).HasColumnName("PR_EXEC");
            builder.Property(e => e.PrMlos).HasColumnName("PR_MLOS");
            builder.Property(e => e.PrPlic).HasColumnName("PR_PLIC");
            builder.Property(e => e.PrSsn).HasColumnName("PR_SSN");
            builder.Property(e => e.PrSuppl).HasColumnName("PR_SUPPL");
            builder.Property(e => e.PrWcmp).HasColumnName("PR_WCMP");
            builder.Property(e => e.RrType)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("RR_TYPE");
            builder.Property(e => e.Whichres)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("WHICHRES");
            builder.Property(e => e.WrgDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WRG_DATE");
            builder.Property(e => e.WrgTime)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WRG_TIME");

        }
    }
}