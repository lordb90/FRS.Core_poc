using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class WebccsetConfiguration : IEntityTypeConfiguration<Webccset>
    {
        public void Configure(EntityTypeBuilder<Webccset> builder)
        {
            builder
                .HasNoKey()
                .ToTable("WEBCCSET");

            builder.Property(e => e.Canada).HasColumnName("CANADA");
            builder.Property(e => e.FedAll).HasColumnName("FED_ALL");
            builder.Property(e => e.FedFirst)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("FED_FIRST");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.Internat).HasColumnName("INTERNAT");
            builder.Property(e => e.Past7).HasColumnName("PAST7");
            builder.Property(e => e.PrCty).HasColumnName("PR_CTY");
            builder.Property(e => e.PrFed).HasColumnName("PR_FED");
            builder.Property(e => e.PrFirst)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("PR_FIRST");
            builder.Property(e => e.PrSw).HasColumnName("PR_SW");
            builder.Property(e => e.VordCan)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VORD_CAN");
            builder.Property(e => e.VordCrim)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VORD_CRIM");
            builder.Property(e => e.VordFed)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VORD_FED");
            builder.Property(e => e.VordInt)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VORD_INT");
            builder.Property(e => e.VordOst)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VORD_OST");
            builder.Property(e => e.VordP7)
                .HasColumnType("numeric(1, 0)")
                .HasColumnName("VORD_P7");

        }
    }
}