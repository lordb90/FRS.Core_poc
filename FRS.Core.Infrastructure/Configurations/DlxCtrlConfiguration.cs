//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class DlxCtrlConfiguration : IEntityTypeConfiguration<DlxCtrl>
//    {
//        public void Configure(EntityTypeBuilder<DlxCtrl> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("DLX_CTRL");

//            builder.Property(e => e.Cleartogo)
//                .HasMaxLength(1)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CLEARTOGO");
//            builder.Property(e => e.DlxCtrl1).HasColumnName("DLX_CTRL");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.LastGo)
//                .HasDefaultValueSql("('')")
//                .HasColumnType("datetime")
//                .HasColumnName("LAST_GO");
//            builder.Property(e => e.LastSet)
//                .HasDefaultValueSql("('')")
//                .HasColumnType("datetime")
//                .HasColumnName("LAST_SET");
//        }
//    }
//}