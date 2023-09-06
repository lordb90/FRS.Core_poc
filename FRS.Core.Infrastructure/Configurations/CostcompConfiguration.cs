//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations;

//public class CostcompConfiguration : IEntityTypeConfiguration<Costcomp>
//{
//    public void Configure(EntityTypeBuilder<Costcomp> builder)
//    {
//        builder.HasNoKey()
//            .ToTable("COSTCOMP");

//        builder.Property(e => e.CbIndic).HasColumnName("CB_INDIC");
//        builder.Property(e => e.CcCredit)
//            .HasColumnType("numeric(6, 2)")
//            .HasColumnName("CC_CREDIT");
//        builder.Property(e => e.CcCrim)
//            .HasColumnType("numeric(6, 2)")
//            .HasColumnName("CC_CRIM");
//        builder.Property(e => e.CcEduc)
//            .HasColumnType("numeric(6, 2)")
//            .HasColumnName("CC_EDUC");
//        builder.Property(e => e.CcEmpl)
//            .HasColumnType("numeric(6, 2)")
//            .HasColumnName("CC_EMPL");
//        builder.Property(e => e.CcMlost)
//            .HasColumnType("numeric(6, 2)")
//            .HasColumnName("CC_MLOST");
//        builder.Property(e => e.CcMvr)
//            .HasColumnType("numeric(6, 2)")
//            .HasColumnName("CC_MVR");
//        builder.Property(e => e.CcPlic)
//            .HasColumnType("numeric(6, 2)")
//            .HasColumnName("CC_PLIC");
//        builder.Property(e => e.CcStrace)
//            .HasColumnType("numeric(6, 2)")
//            .HasColumnName("CC_STRACE");
//        builder.Property(e => e.CcWkcmp)
//            .HasColumnType("numeric(6, 2)")
//            .HasColumnName("CC_WKCMP");
//        builder.Property(e => e.Id)
//            .ValueGeneratedOnAdd()
//            .HasColumnName("ID");
//    }
//}