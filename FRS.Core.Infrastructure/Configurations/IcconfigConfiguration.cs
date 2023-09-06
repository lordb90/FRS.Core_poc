//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class IcconfigConfiguration : IEntityTypeConfiguration<Icconfig>
//    {
//        public void Configure(EntityTypeBuilder<Icconfig> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("ICCONFIG");

//            builder.Property(e => e.CtyArrFd).HasColumnName("CTY_ARR_FD");
//            builder.Property(e => e.CtyDelay)
//                .HasColumnType("numeric(2, 0)")
//                .HasColumnName("CTY_DELAY");
//            builder.Property(e => e.CtyDobpm)
//                .HasColumnType("numeric(2, 0)")
//                .HasColumnName("CTY_DOBPM");
//            builder.Property(e => e.CtyDobval)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("CTY_DOBVAL");
//            builder.Property(e => e.CtyFreeze).HasColumnName("CTY_FREEZE");
//            builder.Property(e => e.CtyMiddle)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("CTY_MIDDLE");
//            builder.Property(e => e.CtyNchars)
//                .HasColumnType("numeric(2, 0)")
//                .HasColumnName("CTY_NCHARS");
//            builder.Property(e => e.CtyNmatch)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("CTY_NMATCH");
//            builder.Property(e => e.CtyWkend).HasColumnName("CTY_WKEND");
//            builder.Property(e => e.CtyYrsret)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("CTY_YRSRET");
//            builder.Property(e => e.IcCliId)
//                .HasMaxLength(25)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("IC_CLI_ID");
//            builder.Property(e => e.IcPw)
//                .HasMaxLength(25)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("IC_PW");
//            builder.Property(e => e.IcUser)
//                .HasMaxLength(70)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("IC_USER");
//            builder.Property(e => e.Id)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ID");
//            builder.Property(e => e.RubberSt).HasColumnName("RUBBER_ST");
//            builder.Property(e => e.Settings)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SETTINGS");
//            builder.Property(e => e.SuprAdd).HasColumnName("SUPR_ADD");
//            builder.Property(e => e.SuprAge).HasColumnName("SUPR_AGE");
//            builder.Property(e => e.SuprAlias).HasColumnName("SUPR_ALIAS");
//            builder.Property(e => e.SuprChrg).HasColumnName("SUPR_CHRG");
//            builder.Property(e => e.SuprDisp).HasColumnName("SUPR_DISP");
//            builder.Property(e => e.SuprDl).HasColumnName("SUPR_DL");
//            builder.Property(e => e.SuprEyes).HasColumnName("SUPR_EYES");
//            builder.Property(e => e.SuprGend).HasColumnName("SUPR_GEND");
//            builder.Property(e => e.SuprHair).HasColumnName("SUPR_HAIR");
//            builder.Property(e => e.SuprHt).HasColumnName("SUPR_HT");
//            builder.Property(e => e.SuprPob).HasColumnName("SUPR_POB");
//            builder.Property(e => e.SuprRace).HasColumnName("SUPR_RACE");
//            builder.Property(e => e.SuprSent).HasColumnName("SUPR_SENT");
//            builder.Property(e => e.SuprSs).HasColumnName("SUPR_SS");
//            builder.Property(e => e.SuprWt).HasColumnName("SUPR_WT");
//            builder.Property(e => e.SwArrFd).HasColumnName("SW_ARR_FD");
//            builder.Property(e => e.SwDelay)
//                .HasColumnType("numeric(2, 0)")
//                .HasColumnName("SW_DELAY");
//            builder.Property(e => e.SwDobpm)
//                .HasColumnType("numeric(2, 0)")
//                .HasColumnName("SW_DOBPM");
//            builder.Property(e => e.SwDobval)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("SW_DOBVAL");
//            builder.Property(e => e.SwFreeze).HasColumnName("SW_FREEZE");
//            builder.Property(e => e.SwMiddle)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("SW_MIDDLE");
//            builder.Property(e => e.SwNchars)
//                .HasColumnType("numeric(2, 0)")
//                .HasColumnName("SW_NCHARS");
//            builder.Property(e => e.SwNmatch)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("SW_NMATCH");
//            builder.Property(e => e.SwWkend).HasColumnName("SW_WKEND");
//            builder.Property(e => e.SwYrsret)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("SW_YRSRET");

//        }
//    }
//}