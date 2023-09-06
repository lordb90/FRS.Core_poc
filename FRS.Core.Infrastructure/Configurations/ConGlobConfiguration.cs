//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class ConGlobConfiguration : IEntityTypeConfiguration<ConGlob>
//    {
//        public void Configure(EntityTypeBuilder<ConGlob> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("CON_GLOB");

//            builder.Property(e => e.Al1Perpg).HasColumnName("AL_1_PERPG");
//            builder.Property(e => e.AlDups).HasColumnName("AL_DUPS");
//            builder.Property(e => e.AlResload).HasColumnName("AL_RESLOAD");
//            builder.Property(e => e.AlSubject).HasColumnName("AL_SUBJECT");
//            builder.Property(e => e.ContNbr)
//                .HasMaxLength(15)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CONT_NBR");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.ModemNbr)
//                .HasMaxLength(15)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("MODEM_NBR");
//            builder.Property(e => e.Nngroup)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("NNGROUP");
//            builder.Property(e => e.Nnnotify)
//                .HasColumnType("numeric(1, 0)")
//                .HasColumnName("NNNOTIFY");
//        }
//    }
//}