//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class UseSubjConfiguration : IEntityTypeConfiguration<UseSubj>
//    {
//        public void Configure(EntityTypeBuilder<UseSubj> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("USE_SUBJ");

//            builder.Property(e => e.Fullname)
//                .HasMaxLength(35)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FULLNAME");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.Key)
//                .HasColumnType("numeric(8, 0)")
//                .HasColumnName("KEY");
//            builder.Property(e => e.Lockbyuser)
//                .HasMaxLength(6)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("LOCKBYUSER");
//            builder.Property(e => e.Lockdate)
//                .HasDefaultValueSql("('')")
//                .HasColumnType("datetime")
//                .HasColumnName("LOCKDATE");
//            builder.Property(e => e.Userid)
//                .HasMaxLength(6)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("USERID");

//        }
//    }
//}