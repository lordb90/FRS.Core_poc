using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WupdflagConfiguration : IEntityTypeConfiguration<Wupdflag>
    {
        public void Configure(EntityTypeBuilder<Wupdflag> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WUPDFLAG");

            builder.Property(e => e.CcNeeded)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("CC_NEEDED");
            builder.Property(e => e.CcUpdated)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("CC_UPDATED");
            builder.Property(e => e.CcUser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CC_USER");
            builder.Property(e => e.CcardTran).HasColumnName("CCARD_TRAN");
            builder.Property(e => e.Ccdriver).HasColumnName("CCDRIVER");
            builder.Property(e => e.CtNeeded)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("CT_NEEDED");
            builder.Property(e => e.CtUpdated)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("CT_UPDATED");
            builder.Property(e => e.CtUser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CT_USER");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.WcNeeded)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WC_NEEDED");
            builder.Property(e => e.WcUpdated)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WC_UPDATED");
            builder.Property(e => e.WcUser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WC_USER");
            builder.Property(e => e.WebPkg).HasColumnName("WEB_PKG");
            builder.Property(e => e.Webcounty).HasColumnName("WEBCOUNTY");
            builder.Property(e => e.Webhelp).HasColumnName("WEBHELP");
            builder.Property(e => e.Webinfo).HasColumnName("WEBINFO");
            builder.Property(e => e.Webost).HasColumnName("WEBOST");
            builder.Property(e => e.WhNeeded)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WH_NEEDED");
            builder.Property(e => e.WhUpdated)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WH_UPDATED");
            builder.Property(e => e.WhUser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WH_USER");
            builder.Property(e => e.WiNeeded)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WI_NEEDED");
            builder.Property(e => e.WiUpdated)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WI_UPDATED");
            builder.Property(e => e.WiUser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WI_USER");
            builder.Property(e => e.WoNeeded)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WO_NEEDED");
            builder.Property(e => e.WoUpdated)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WO_UPDATED");
            builder.Property(e => e.WoUser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WO_USER");
            builder.Property(e => e.WpNeeded)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WP_NEEDED");
            builder.Property(e => e.WpUpdated)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("WP_UPDATED");
            builder.Property(e => e.WpUser)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WP_USER");
        }
    }
}