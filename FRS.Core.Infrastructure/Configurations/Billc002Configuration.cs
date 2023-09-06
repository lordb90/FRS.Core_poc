//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations;

//public class Billc002Configuration : IEntityTypeConfiguration<Billc002>
//{
//    public void Configure(EntityTypeBuilder<Billc002> builder)
//    {
//        builder
//            .HasNoKey()
//            .ToTable("BILLC002");

//        builder.Property(e => e.Desc)
//            .HasMaxLength(31)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("DESC");
//        builder.Property(e => e.Id)
//            .ValueGeneratedOnAdd()
//            .HasColumnName("ID");
//        builder.Property(e => e.Itemtype)
//            .HasMaxLength(1)
//            .IsUnicode(false)
//            .HasDefaultValueSql("('')")
//            .HasColumnName("ITEMTYPE");
//        builder.Property(e => e.Price)
//            .HasColumnType("numeric(6, 2)")
//            .HasColumnName("PRICE");    }
//}