using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class IhrWorkConfiguration : IEntityTypeConfiguration<IhrWork>
    {
        public void Configure(EntityTypeBuilder<IhrWork> builder)
        {
            builder
                .HasNoKey()
                .ToTable("IHR_WORK");

            builder.Property(e => e.AkaOnrec)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AKA_ONREC");
            builder.Property(e => e.Casenbr)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CASENBR");
            builder.Property(e => e.Court)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COURT");
            builder.Property(e => e.DateDiscr).HasColumnName("DATE_DISCR");
            builder.Property(e => e.Details)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DETAILS");
            builder.Property(e => e.Dob)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOB");
            builder.Property(e => e.Fullname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FULLNAME");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.OffDate)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OFF_DATE");
            builder.Property(e => e.OffType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OFF_TYPE");
            builder.Property(e => e.Offense)
                .HasMaxLength(90)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OFFENSE");
            builder.Property(e => e.Ptrec)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("PTREC");
            builder.Property(e => e.Select).HasColumnName("SELECT");
            builder.Property(e => e.Whattodo)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("WHATTODO");
            builder.Property(e => e.Yrsincdisp)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("YRSINCDISP");

        }
    }
}