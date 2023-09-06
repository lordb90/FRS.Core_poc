//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class LxlGlobConfiguration : IEntityTypeConfiguration<LxlGlob>
//    {
//        public void Configure(EntityTypeBuilder<LxlGlob> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("LXL_GLOB");

//            builder.Property(e => e.AP)
//                .HasMaxLength(10)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("A_P");
//            builder.Property(e => e.AU)
//                .HasMaxLength(10)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("A_U");
//            builder.Property(e => e.Al1Perpg).HasColumnName("AL_1_PERPG");
//            builder.Property(e => e.AlxCounty).HasColumnName("ALX_COUNTY");
//            builder.Property(e => e.AlxDriver).HasColumnName("ALX_DRIVER");
//            builder.Property(e => e.AlxDups).HasColumnName("ALX_DUPS");
//            builder.Property(e => e.AlxRes).HasColumnName("ALX_RES");
//            builder.Property(e => e.AlxSubj).HasColumnName("ALX_SUBJ");
//            builder.Property(e => e.AutoAdd).HasColumnName("AUTO_ADD");
//            builder.Property(e => e.AutoMlost).HasColumnName("AUTO_MLOST");
//            builder.Property(e => e.EmlSubj)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EML_SUBJ");
//            builder.Property(e => e.Exactkeywd).HasColumnName("EXACTKEYWD");
//            builder.Property(e => e.ExtraSsc)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EXTRA_SSC");
//            builder.Property(e => e.ExtraSsr)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("EXTRA_SSR");
//            builder.Property(e => e.HumExReq).HasColumnName("HUM_EX_REQ");
//            builder.Property(e => e.HumExRes).HasColumnName("HUM_EX_RES");
//            builder.Property(e => e.HumImReq).HasColumnName("HUM_IM_REQ");
//            builder.Property(e => e.HumImRes).HasColumnName("HUM_IM_RES");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.LinxValid).HasColumnName("LINX_VALID");
//            builder.Property(e => e.Linxfrzsri).HasColumnName("LINXFRZSRI");
//            builder.Property(e => e.LxVersion)
//                .HasMaxLength(5)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("LX_VERSION");
//            builder.Property(e => e.Nextbatch)
//                .HasColumnType("numeric(8, 0)")
//                .HasColumnName("NEXTBATCH");
//            builder.Property(e => e.Nofrzkeywd)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("NOFRZKEYWD");
//            builder.Property(e => e.WsPw)
//                .HasMaxLength(10)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("WS_PW");
//            builder.Property(e => e.WsUserid)
//                .HasMaxLength(10)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("WS_USERID");

//        }
//    }
//}