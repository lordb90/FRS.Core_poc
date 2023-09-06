//using FRS.Core.Domain.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;

//namespace FRS.Enterprise.Infrastructure.Data.Configurations
//{
//    public class SftpConfigConfiguration : IEntityTypeConfiguration<SftpConfig>
//    {
//        public void Configure(EntityTypeBuilder<SftpConfig> builder)
//        {
//            builder.HasNoKey()
//                .ToTable("SFTP_CONFIG");

//            builder.Property(e => e.Clientid)
//                .HasMaxLength(6)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("CLIENTID");
//            builder.Property(e => e.Fhostname)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FHOSTNAME");
//            builder.Property(e => e.Ftprcvpath)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FTPRCVPATH");
//            builder.Property(e => e.Ftpsndpath)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("FTPSNDPATH");
//            builder.Property(e => e.Id)
//                .ValueGeneratedOnAdd()
//                .HasColumnName("ID");
//            builder.Property(e => e.Passwrd)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("PASSWRD");
//            builder.Property(e => e.Pgppasswrd)
//                .HasMaxLength(50)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("PGPPASSWRD");
//            builder.Property(e => e.Pgpprvkey)
//                .HasMaxLength(254)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("PGPPRVKEY");
//            builder.Property(e => e.Pgppubkey)
//                .HasMaxLength(254)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("PGPPUBKEY");
//            builder.Property(e => e.Pgpuserid)
//                .HasMaxLength(100)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("PGPUSERID");
//            builder.Property(e => e.Port)
//                .HasColumnType("numeric(5, 0)")
//                .HasColumnName("PORT");
//            builder.Property(e => e.Username)
//                .HasMaxLength(20)
//                .IsUnicode(false)
//                .HasDefaultValueSql("('')")
//                .HasColumnName("USERNAME");

//        }
//    }
//}