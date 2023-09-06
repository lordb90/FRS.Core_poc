//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class MvrstateConfiguration : IEntityTypeConfiguration<Mvrstate>
//    {
//        public void Configure(EntityTypeBuilder<Mvrstate> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("MVRSTATES");

//            builder.Property(e => e.CompOnly).HasColumnName("COMP_ONLY");
//            builder.Property(e => e.Complialrt)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COMPLIALRT");
//            builder.Property(e => e.Compliance)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("COMPLIANCE");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.Longname)
//                .HasMaxLength(15)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("LONGNAME");
//            builder.Property(e => e.MvrFee)
//                .HasColumnType("numeric(6, 2)")
//                .HasColumnName("MVR_FEE");
//            builder.Property(e => e.MvrFee2)
//                .HasColumnType("numeric(6, 2)")
//                .HasColumnName("MVR_FEE2");
//            builder.Property(e => e.MvrfeeCnt)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("MVRFEE_CNT");
//            builder.Property(e => e.Mvrvendor)
//                .HasMaxLength(7)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("MVRVENDOR");
//            builder.Property(e => e.NbrCtys)
//                .HasColumnType("numeric(3, 0)")
//                .HasColumnName("NBR_CTYS");
//            builder.Property(e => e.OrderOst)
//                .HasMaxLength(30)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ORDER_OST");
//            builder.Property(e => e.SambaOnly).HasColumnName("SAMBA_ONLY");
//            builder.Property(e => e.StAka)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ST_AKA");
//            builder.Property(e => e.StAkaSw)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ST_AKA_SW");
//            builder.Property(e => e.StDmv)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ST_DMV");
//            builder.Property(e => e.StSw)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ST_SW");
//            builder.Property(e => e.StWc)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ST_WC");
//            builder.Property(e => e.State)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE");
//            builder.Property(e => e.Swspecinst)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SWSPECINST");
//            builder.Property(e => e.WcEnduser)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("WC_ENDUSER");
//            builder.Property(e => e.WebCty)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("WEB_CTY");
//            builder.Property(e => e.WebFirst)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("WEB_FIRST");
//            builder.Property(e => e.WebSw)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("WEB_SW");

//        }
//    }
//}