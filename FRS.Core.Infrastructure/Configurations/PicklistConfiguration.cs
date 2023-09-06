//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class PicklistConfiguration : IEntityTypeConfiguration<Picklist>
//    {
//        public void Configure(EntityTypeBuilder<Picklist> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("PICKLISTS");

//            builder.Property(e => e.ArrayName)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ARRAY_NAME");
//            builder.Property(e => e.Descript)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("DESCRIPT");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.ItemId).HasColumnName("ITEM_ID");
//            builder.Property(e => e.ItemValue)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("ITEM_VALUE");

//        }
//    }
//}