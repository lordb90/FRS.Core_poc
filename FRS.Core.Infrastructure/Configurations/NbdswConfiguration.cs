//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class NbdswConfiguration : IEntityTypeConfiguration<Nbdsw>
//    {
//        public void Configure(EntityTypeBuilder<Nbdsw> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("NBDSW");

//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.State)
//                .HasMaxLength(2)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("STATE");

//        }
//    }
//}