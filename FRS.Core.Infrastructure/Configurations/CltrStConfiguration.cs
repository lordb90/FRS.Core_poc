using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class CltrStConfiguration : IEntityTypeConfiguration<CltrSt>
    {
        public void Configure(EntityTypeBuilder<CltrSt> builder)
        {
            builder
                .HasNoKey()
                .ToTable("CLTR_ST");

            builder.Property(e => e.Clientflag).HasColumnName("CLIENTFLAG");
            builder.Property(e => e.CrhitFlag).HasColumnName("CRHIT_FLAG");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.SubjFlag).HasColumnName("SUBJ_FLAG");
        }
    }
}