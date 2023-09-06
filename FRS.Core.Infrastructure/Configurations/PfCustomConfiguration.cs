//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class PfCustomConfiguration : IEntityTypeConfiguration<PfCustom>
//    {
//        public void Configure(EntityTypeBuilder<PfCustom> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("PF_CUSTOM");

//            builder.Property(e => e.Fieldname)
//                .HasMaxLength(10)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FIELDNAME");
//            builder.Property(e => e.Fieldvalue)
//                .HasMaxLength(254)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FIELDVALUE");
//            builder.Property(e => e.Key)
//                .HasColumnType("numeric(8, 0)")
//                .HasColumnName("KEY");
//            builder.Property(e => e.PfKey)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("PF_KEY");
//            builder.Property(e => e.SiteId)
//                .HasMaxLength(3)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SITE_ID");
//            builder.Property(e => e.Tablename)
//                .HasMaxLength(12)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TABLENAME");

//        }
//    }
//}