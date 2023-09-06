//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class IcGlobConfiguration : IEntityTypeConfiguration<IcGlob>
//    {
//        public void Configure(EntityTypeBuilder<IcGlob> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("IC_GLOB");

//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.Sripiklist)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("SRIPIKLIST");

//        }
//    }
//}