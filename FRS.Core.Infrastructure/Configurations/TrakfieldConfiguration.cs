using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class TrakfieldConfiguration : IEntityTypeConfiguration<Trakfield>
    {
        public void Configure(EntityTypeBuilder<Trakfield> builder)
        {
            builder
                .HasNoKey()
                .ToTable("TRAKFIELDS");

            builder.Property(e => e.AdminOnly).HasColumnName("ADMIN_ONLY");
            builder.Property(e => e.CntlName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CNTL_NAME");
            builder.Property(e => e.Descript)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DESCRIPT");
            builder.Property(e => e.Excluded).HasColumnName("EXCLUDED");
            builder.Property(e => e.FieldDec)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("FIELD_DEC");
            builder.Property(e => e.FieldLen)
                .HasColumnType("numeric(3, 0)")
                .HasColumnName("FIELD_LEN");
            builder.Property(e => e.FieldName)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FIELD_NAME");
            builder.Property(e => e.FieldType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FIELD_TYPE");
            builder.Property(e => e.Firstelem0).HasColumnName("FIRSTELEM0");
            builder.Property(e => e.FormName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FORM_NAME");
            builder.Property(e => e.FormName2)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FORM_NAME2");
            builder.Property(e => e.FormName3)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FORM_NAME3");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Override).HasColumnName("OVERRIDE");
            builder.Property(e => e.Settngtype)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SETTNGTYPE");
            builder.Property(e => e.Subrecord)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBRECORD");
            builder.Property(e => e.TabNum)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TAB_NUM");
            builder.Property(e => e.TableName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("TABLE_NAME");
        }
    }
}