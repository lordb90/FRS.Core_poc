using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class IhrMworkConfiguration : IEntityTypeConfiguration<IhrMwork>
    {
        public void Configure(EntityTypeBuilder<IhrMwork> builder)
        {
            builder
                .HasNoKey()
                .ToTable("IHR_MWORK");

            builder.Property(e => e.Akas)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("AKAS");
            builder.Property(e => e.County)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COUNTY");
            builder.Property(e => e.Details)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DETAILS");
            builder.Property(e => e.Dob)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOB");
            builder.Property(e => e.Frsproduct)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FRSPRODUCT");
            builder.Property(e => e.Fullname)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FULLNAME");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Jurisdictn)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("JURISDICTN");
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
            builder.Property(e => e.PfmlKey).HasColumnName("PFML_KEY");
            builder.Property(e => e.Select).HasColumnName("SELECT");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");

        }
    }
}