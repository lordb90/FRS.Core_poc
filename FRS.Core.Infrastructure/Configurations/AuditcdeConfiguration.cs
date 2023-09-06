//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations;

//public class AuditcdeConfiguration : IEntityTypeConfiguration<Auditcde>
//{
//    public void Configure(EntityTypeBuilder<Auditcde> builder)
//    {
//        builder
//            .HasNoKey()
//            .ToTable("AUDITCDE");

//        builder.Property(e => e.Aucode)
//            .HasMaxLength(2)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("AUCODE");
//        builder.Property(e => e.Audesc)
//            .HasMaxLength(50)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("AUDESC");
//        builder.Property(e => e.Id)
//            .ValueGeneratedOnAdd()
//            .HasColumnName("ID");
//        builder.Property(e => e.IncType)
//            .HasMaxLength(2)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("INC_TYPE");
//    }
//}