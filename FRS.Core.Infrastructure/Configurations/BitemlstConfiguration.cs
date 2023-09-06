//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations;

//public class BitemlstConfiguration : IEntityTypeConfiguration<Bitemlst>
//{
//    public void Configure(EntityTypeBuilder<Bitemlst> builder)
//    {
//        builder
//            .HasNoKey()
//            .ToTable("BITEMLST");

//        builder.Property(e => e.Billactive).HasColumnName("BILLACTIVE");
//        builder.Property(e => e.Desc)
//            .HasMaxLength(33)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("DESC");
//        builder.Property(e => e.Filename)
//            .HasMaxLength(12)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("FILENAME");
//        builder.Property(e => e.Id)
//            .ValueGeneratedOnAdd()
//            .HasColumnName("ID");
//        builder.Property(e => e.Short)
//            .HasMaxLength(14)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("SHORT");
//    }
//}