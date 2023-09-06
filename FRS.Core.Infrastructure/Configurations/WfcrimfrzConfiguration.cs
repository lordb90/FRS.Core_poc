//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class WfcrimfrzConfiguration : IEntityTypeConfiguration<Wfcrimfrz>
//    {
//        public void Configure(EntityTypeBuilder<Wfcrimfrz> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("WFCRIMFRZ");

//            builder.Property(e => e.CompCode)
//                .HasMaxLength(6)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COMP_CODE");
//            builder.Property(e => e.FrzstCty)
//                .HasMaxLength(150)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FRZST_CTY");
//            builder.Property(e => e.FrzstStw)
//                .HasMaxLength(150)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FRZST_STW");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");

//        }
//    }
//}