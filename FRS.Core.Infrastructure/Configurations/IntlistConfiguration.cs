//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class IntlistConfiguration : IEntityTypeConfiguration<Intlist>
//    {
//        public void Configure(EntityTypeBuilder<Intlist> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("INTLIST");

//            builder.Property(e => e.Assigned)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ASSIGNED");
//            builder.Property(e => e.FlagFile)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FLAG_FILE");
//            builder.Property(e => e.Hidden).HasColumnName("HIDDEN");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.IntFile)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("INT_FILE");
//            builder.Property(e => e.IntName)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("INT_NAME");
//            builder.Property(e => e.Keycode)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("KEYCODE");
//            builder.Property(e => e.Licensed).HasColumnName("LICENSED");
//            builder.Property(e => e.Needupdate).HasColumnName("NEEDUPDATE");
//            builder.Property(e => e.Postingurl)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("POSTINGURL");
//            builder.Property(e => e.Showcodes).HasColumnName("SHOWCODES");
//            builder.Property(e => e.Subcodes)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SUBCODES");
//            builder.Property(e => e.Vendorid)
//                .HasColumnType("numeric(2, 0)")
//                .HasColumnName("VENDORID");

//        }
//    }
//}