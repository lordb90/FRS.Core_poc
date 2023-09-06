using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class SpecinstConfiguration : IEntityTypeConfiguration<Specinst>
    {
        public void Configure(EntityTypeBuilder<Specinst> builder)
        {
            builder
                .HasNoKey()
                .ToTable("SPECINST");

            builder.Property(e => e.CourtFee)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("COURT_FEE");
            builder.Property(e => e.CvlFee)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("CVL_FEE");
            builder.Property(e => e.FedFee)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("FED_FEE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Message)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MESSAGE");
            builder.Property(e => e.OthFee)
                .HasColumnType("numeric(8, 2)")
                .HasColumnName("OTH_FEE");
            builder.Property(e => e.RTrace)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("R_TRACE_");
            builder.Property(e => e.SiCounty)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SI_COUNTY");
            builder.Property(e => e.SiState)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SI_STATE");
            builder.Property(e => e.SrchInstr)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SRCH_INSTR");
        }
    }
}