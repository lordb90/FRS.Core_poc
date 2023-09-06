//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class RibnfavConfiguration : IEntityTypeConfiguration<Ribnfav>
//    {
//        public void Configure(EntityTypeBuilder<Ribnfav> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("RIBNFAVS");

//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.Menuaction)
//                .HasMaxLength(250)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("MENUACTION");
//            builder.Property(e => e.Menucode)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("MENUCODE");
//            builder.Property(e => e.Menudesc)
//                .HasMaxLength(250)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("MENUDESC");
//            builder.Property(e => e.Menuicon)
//                .HasMaxLength(40)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("MENUICON");
//            builder.Property(e => e.Menuitem)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("MENUITEM");
//            builder.Property(e => e.Menukey)
//                .HasMaxLength(3)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("MENUKEY");
//            builder.Property(e => e.Selectitem).HasColumnName("SELECTITEM");
//        }
//    }
//}