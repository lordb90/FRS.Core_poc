//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class CustflgConfiguration : IEntityTypeConfiguration<Custflg>
//    {
//        public void Configure(EntityTypeBuilder<Custflg> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("CUSTFLGS");

//            builder.Property(e => e.Action)
//                .HasMaxLength(15)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ACTION");
//            builder.Property(e => e.Active).HasColumnName("ACTIVE");
//            builder.Property(e => e.Descript)
//                .HasMaxLength(25)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("DESCRIPT");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.SiteId)
//                .HasMaxLength(3)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SITE_ID");
//            builder.Property(e => e.Xcode)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("XCODE");
//        }
//    }
//}