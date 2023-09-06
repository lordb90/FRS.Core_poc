//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations;

//public class AutoSetConfiguration : IEntityTypeConfiguration<AutoSet>
//{
//    public void Configure(EntityTypeBuilder<AutoSet> builder)
//    {
//            builder
//                .HasNoKey()
//                .ToTable("AUTO_SET");

//            builder.Property(e => e.AsCadd).HasColumnName("AS_CADD");
//            builder.Property(e => e.AsCredit).HasColumnName("AS_CREDIT");
//            builder.Property(e => e.AsEmlcomp).HasColumnName("AS_EMLCOMP");
//            builder.Property(e => e.AsFaxcomp).HasColumnName("AS_FAXCOMP");
//            builder.Property(e => e.AsRebuild).HasColumnName("AS_REBUILD");
//            builder.Property(e => e.AsStrace).HasColumnName("AS_STRACE");
//            builder.Property(e => e.AsWebDs).HasColumnName("AS_WEB_DS");
//            builder.Property(e => e.AsWebcomp).HasColumnName("AS_WEBCOMP");
//            builder.Property(e => e.AsWebpart).HasColumnName("AS_WEBPART");
//            builder.Property(e => e.AsWebrpt).HasColumnName("AS_WEBRPT");
//            builder.Property(e => e.Batcmvrhrs)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("BATCMVRHRS");
//            builder.Property(e => e.Continuous).HasColumnName("CONTINUOUS");
//            builder.Property(e => e.DelInterv)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("DEL_INTERV");
//            builder.Property(e => e.DlxMaxper)
//                .HasColumnType("numeric(3, 0)")
//                .HasColumnName("DLX_MAXPER");
//            builder.Property(e => e.DsDo2)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("DS_DO_2");
//            builder.Property(e => e.Emlmaxcnt)
//                .HasColumnType("numeric(3, 0)")
//                .HasColumnName("EMLMAXCNT");
//            builder.Property(e => e.Emlmaxmb)
//                .HasColumnType("numeric(3, 0)")
//                .HasColumnName("EMLMAXMB");
//            builder.Property(e => e.Fbaud)
//                .HasColumnType("numeric(6, 0)")
//                .HasColumnName("FBAUD");
//            builder.Property(e => e.Fport)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("FPORT");
//            builder.Property(e => e.IaBatch)
//                .HasColumnType("numeric(3, 0)")
//                .HasColumnName("IA_BATCH");
//            builder.Property(e => e.IcmMaxper)
//                .HasColumnType("numeric(3, 0)")
//                .HasColumnName("ICM_MAXPER");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.Instmvrnbr)
//                .HasColumnType("numeric(3, 0)")
//                .HasColumnName("INSTMVRNBR");
//            builder.Property(e => e.Lastrbdate)
//                .HasDefaultValueSql("('')")
//                .HasColumnType("datetime")
//                .HasColumnName("LASTRBDATE");
//            builder.Property(e => e.Lastrbskip)
//                .HasDefaultValueSql("('')")
//                .HasColumnType("datetime")
//                .HasColumnName("LASTRBSKIP");
//            builder.Property(e => e.Lastrbtime)
//                .HasMaxLength(5)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("LASTRBTIME");
//            builder.Property(e => e.Lastrbtype)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("LASTRBTYPE");
//            builder.Property(e => e.LxmlForce).HasColumnName("LXML_FORCE");
//            builder.Property(e => e.LxmlNight).HasColumnName("LXML_NIGHT");
//            builder.Property(e => e.LxmlWkend).HasColumnName("LXML_WKEND");
//            builder.Property(e => e.Modemshare).HasColumnName("MODEMSHARE");
//            builder.Property(e => e.MvrIval)
//                .HasColumnType("numeric(2, 0)")
//                .HasColumnName("MVR_IVAL");
//            builder.Property(e => e.PartNight).HasColumnName("PART_NIGHT");
//            builder.Property(e => e.PartWkend).HasColumnName("PART_WKEND");
//            builder.Property(e => e.Pauscontin)
//                .HasColumnType("numeric(3, 0)")
//                .HasColumnName("PAUSCONTIN");
//            builder.Property(e => e.PstMaxper)
//                .HasColumnType("numeric(3, 0)")
//                .HasColumnName("PST_MAXPER");
//            builder.Property(e => e.Rbldshutdn)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("RBLDSHUTDN");
//            builder.Property(e => e.RebldTime)
//                .HasMaxLength(5)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("REBLD_TIME");
//            builder.Property(e => e.Skipfacis).HasColumnName("SKIPFACIS");
//            builder.Property(e => e.TempstiIp)
//                .HasMaxLength(100)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("TEMPSTI_IP");    }
//}