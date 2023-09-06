//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class PrPendgConfiguration : IEntityTypeConfiguration<PrPendg>
//    {
//        public void Configure(EntityTypeBuilder<PrPendg> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("PR_PENDG");

//            builder.Property(e => e.CrimCnt)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("CRIM_CNT");
//            builder.Property(e => e.DlnxCnt)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("DLNX_CNT");
//            builder.Property(e => e.EducCnt)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("EDUC_CNT");
//            builder.Property(e => e.EmplCnt)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("EMPL_CNT");
//            builder.Property(e => e.FrpstCnt)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("FRPST_CNT");
//            builder.Property(e => e.IcrimCnt)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("ICRIM_CNT");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.Lastupdate)
//                .HasDefaultValueSql("('')")
//                .HasColumnType("datetime")
//                .HasColumnName("LASTUPDATE");
//            builder.Property(e => e.MlostCnt)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("MLOST_CNT");
//            builder.Property(e => e.MvrCnt)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("MVR_CNT");
//            builder.Property(e => e.PlicCnt)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("PLIC_CNT");
//            builder.Property(e => e.WcmpCnt)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("WCMP_CNT");

//        }
//    }
//}