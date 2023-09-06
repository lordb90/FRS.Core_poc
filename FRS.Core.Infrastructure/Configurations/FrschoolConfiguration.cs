using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class FrschoolConfiguration : IEntityTypeConfiguration<Frschool>
    {
        public void Configure(EntityTypeBuilder<Frschool> builder)
        {
            builder
                .HasNoKey()
                .ToTable("FRSCHOOL");

            builder.Property(e => e.Activation)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("ACTIVATION");
            builder.Property(e => e.Address)
                .HasMaxLength(55)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ADDRESS");
            builder.Property(e => e.Campus)
                .HasMaxLength(45)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CAMPUS");
            builder.Property(e => e.City)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CITY");
            builder.Property(e => e.ClNotes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CL_NOTES");
            builder.Property(e => e.Clearhouse)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CLEARHOUSE");
            builder.Property(e => e.FaxNumber)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FAX_NUMBER");
            builder.Property(e => e.Feescolleg)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("FEESCOLLEG");
            builder.Property(e => e.Feesretail)
                .HasColumnType("numeric(12, 2)")
                .HasColumnName("FEESRETAIL");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.SchCode)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SCH_CODE");
            builder.Property(e => e.School)
                .HasMaxLength(63)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SCHOOL");
            builder.Property(e => e.Source)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SOURCE");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TITLE");
            builder.Property(e => e.U)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')");
            builder.Property(e => e.VoicePhn)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("VOICE_PHN");
            builder.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ZIP");
        }
    }
}