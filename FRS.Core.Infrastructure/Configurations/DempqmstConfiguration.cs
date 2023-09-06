using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class DempqmstConfiguration : IEntityTypeConfiguration<Dempqmst>
    {
        public void Configure(EntityTypeBuilder<Dempqmst> builder)
        {
            builder.HasNoKey()
                .ToTable("DEMPQMST");

            builder.Property(e => e.AddDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("ADD_DATE");
            builder.Property(e => e.Default)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DEFAULT");
            builder.Property(e => e.EditDate)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("EDIT_DATE");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.LongDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LONG_DESC");
            builder.Property(e => e.NumQuest)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("NUM_QUEST");
            builder.Property(e => e.ShortDesc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SHORT_DESC");
        }
    }
}