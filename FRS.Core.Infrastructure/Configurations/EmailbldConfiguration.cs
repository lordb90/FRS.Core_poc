using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class EmailbldConfiguration : IEntityTypeConfiguration<Emailbld>
    {
        public void Configure(EntityTypeBuilder<Emailbld> builder)
        {
            builder
                .HasNoKey()
                .ToTable("EMAILBLD");

            builder.Property(e => e.EmailId)
                .HasColumnType("numeric(7, 0)")
                .HasColumnName("EMAIL_ID");
            builder.Property(e => e.ExtraNum)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("EXTRA_NUM");
            builder.Property(e => e.Extrainfo1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXTRAINFO1");
            builder.Property(e => e.Extrainfo2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXTRAINFO2");
            builder.Property(e => e.Extrainfo3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXTRAINFO3");
            builder.Property(e => e.Extrainfo4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("EXTRAINFO4");
            builder.Property(e => e.Format)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("FORMAT");
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
            builder.Property(e => e.ResNotes)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RES_NOTES");
            builder.Property(e => e.Subtype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBTYPE");
            builder.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TYPE");

        }
    }
}