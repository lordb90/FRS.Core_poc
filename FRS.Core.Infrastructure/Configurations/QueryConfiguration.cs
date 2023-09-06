//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class QueryConfiguration : IEntityTypeConfiguration<Query>
//    {
//        public void Configure(EntityTypeBuilder<Query> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("QUERY");

//            builder.Property(e => e.Cost)
//                .HasColumnType("numeric(16, 2)")
//                .HasColumnName("COST");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.Price)
//                .HasColumnType("numeric(16, 2)")
//                .HasColumnName("PRICE");
//            builder.Property(e => e.YearMth)
//                .HasMaxLength(7)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("YEAR_MTH");

//        }
//    }
//}