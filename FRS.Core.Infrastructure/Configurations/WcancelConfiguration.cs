//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class WcancelConfiguration : IEntityTypeConfiguration<Wcancel>
//    {
//        public void Configure(EntityTypeBuilder<Wcancel> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("WCANCEL");

//            builder.Property(e => e.Done).HasColumnName("DONE");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.Key)
//                .HasColumnType("numeric(8, 0)")
//                .HasColumnName("KEY");
//            builder.Property(e => e.Wdate)
//                .HasDefaultValueSql("('')")
//                .HasColumnType("datetime")
//                .HasColumnName("WDATE");

//        }
//    }
//}