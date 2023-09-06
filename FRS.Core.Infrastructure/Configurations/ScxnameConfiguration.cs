//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class ScxnameConfiguration : IEntityTypeConfiguration<Scxname>
//    {
//        public void Configure(EntityTypeBuilder<Scxname> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("SCXNAMES");

//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.Scxname1)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SCXNAME");

//        }
//    }
//}