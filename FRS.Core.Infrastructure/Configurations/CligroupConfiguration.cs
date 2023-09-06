using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations;

public class CligroupConfiguration : IEntityTypeConfiguration<Cligroup>
{
    public void Configure(EntityTypeBuilder<Cligroup> builder)
    {
        builder
            .HasNoKey()
            .ToTable("CLIGROUPS");

        builder.Property(e => e.CompCode)
            .HasMaxLength(6)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("COMP_CODE");
        builder.Property(e => e.GroupName)
            .HasMaxLength(20)
            .IsUnicode(false)
            .HasDefaultValueSql("('')")
            .HasColumnName("GROUP_NAME");
        builder.Property(e => e.Id)
            .ValueGeneratedOnAdd()
            .HasColumnName("ID");
    }
}