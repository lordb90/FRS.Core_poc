//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class IcdriverConfiguration : IEntityTypeConfiguration<Icdriver>
//    {
//        public void Configure(EntityTypeBuilder<Icdriver> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("ICDRIVER");

//            builder.Property(e => e.County)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COUNTY");
//            builder.Property(e => e.Coverage)
//                .HasMaxLength(25)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COVERAGE");
//            builder.Property(e => e.CtyToSnd)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CTY_TO_SND");
//            builder.Property(e => e.HcIdent)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("HC_IDENT");
//            builder.Property(e => e.HitClear)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("HIT_CLEAR");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.MultiPass)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("MULTI_PASS");
//            builder.Property(e => e.Notes)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("NOTES");
//            builder.Property(e => e.Partial)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("PARTIAL");
//            builder.Property(e => e.ReqAcct)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("REQ_ACCT");
//            builder.Property(e => e.ReqCc)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("REQ_CC");
//            builder.Property(e => e.Source)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SOURCE");
//            builder.Property(e => e.State)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE");
//            builder.Property(e => e.Type)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TYPE");
//            builder.Property(e => e.VerNum)
//                .HasColumnType("numeric(6, 2)")
//                .HasColumnName("VER_NUM");

//        }
//    }
//}