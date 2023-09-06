//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class IcMatchConfiguration : IEntityTypeConfiguration<IcMatch>
//    {
//        public void Configure(EntityTypeBuilder<IcMatch> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("IC_MATCH");

//            builder.Property(e => e.FrsCty)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FRS_CTY");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.State)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE");
//            builder.Property(e => e.UserCty)
//                .HasMaxLength(26)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("USER_CTY");

//        }
//    }
//}