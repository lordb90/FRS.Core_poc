using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class PfEducConfiguration : IEntityTypeConfiguration<PfEduc>
    {
        public void Configure(EntityTypeBuilder<PfEduc> builder)
        {
            builder
                .HasNoKey()
                .ToTable("PF_EDUC");

            builder.Property(e => e.AddInfo)
                .IsUnicode(false)
                .HasColumnName("ADD_INFO");
            builder.Property(e => e.Caaccompl)
                .IsUnicode(false)
                .HasColumnName("CAACCOMPL");
            builder.Property(e => e.Cacredits)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CACREDITS");
            builder.Property(e => e.CadateAtt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CADATE_ATT");
            builder.Property(e => e.Caddrecv)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CADDRECV");
            builder.Property(e => e.Cadegree)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CADEGREE");
            builder.Property(e => e.Cagrades)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CAGRADES");
            builder.Property(e => e.Camajor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CAMAJOR");
            builder.Property(e => e.Clearhouse)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("CLEARHOUSE");
            builder.Property(e => e.CompFlag).HasColumnName("COMP_FLAG");
            builder.Property(e => e.Complete).HasColumnName("COMPLETE");
            builder.Property(e => e.Confirmby)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("CONFIRMBY");
            builder.Property(e => e.Discrep).HasColumnName("DISCREP");
            builder.Property(e => e.DotRegula).HasColumnName("DOT_REGULA");
            builder.Property(e => e.Eduemail)
                .HasMaxLength(70)
                .IsUnicode(false)
                .HasColumnName("EDUEMAIL");
            builder.Property(e => e.Eorder)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("EORDER");
            builder.Property(e => e.Fnameatend)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("FNAMEATEND");
            builder.Property(e => e.Highstdgre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("HIGHSTDGRE");
            builder.Property(e => e.IFax)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("I_FAX");
            builder.Property(e => e.IPhone)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("I_PHONE");
            builder.Property(e => e.Icomments)
                .IsUnicode(false)
                .HasColumnName("ICOMMENTS");
            builder.Property(e => e.InsqlDic).HasColumnName("INSQL_DIC");
            builder.Property(e => e.Institute)
                .HasMaxLength(60)
                .IsUnicode(false)
                .HasColumnName("INSTITUTE");
            builder.Property(e => e.IntNotes)
                .IsUnicode(false)
                .HasColumnName("INT_NOTES");
            builder.Property(e => e.InterData)
                .IsUnicode(false)
                .HasColumnName("INTER_DATA");
            builder.Property(e => e.InternFlg).HasColumnName("INTERN_FLG");
            builder.Property(e => e.Key)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("KEY");
            builder.Property(e => e.Lastmodify)
                .HasColumnType("datetime")
                .HasColumnName("LASTMODIFY");
            builder.Property(e => e.Lnameatend)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LNAMEATEND");
            builder.Property(e => e.Location)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LOCATION");
            builder.Property(e => e.Mnameatend)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("MNAMEATEND");
            builder.Property(e => e.NoCharge).HasColumnName("NO_CHARGE");
            builder.Property(e => e.PfKey)
                .ValueGeneratedOnAdd()
                .HasColumnName("PF_KEY");
            builder.Property(e => e.Rcomments)
                .IsUnicode(false)
                .HasColumnName("RCOMMENTS");
            builder.Property(e => e.RecReview).HasColumnName("REC_REVIEW");
            builder.Property(e => e.RecalLast)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("RECAL_LAST");
            builder.Property(e => e.RecallCnt)
                .HasColumnType("numeric(2, 0)")
                .HasColumnName("RECALL_CNT");
            builder.Property(e => e.RecallDt)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("RECALL_DT");
            builder.Property(e => e.ResDate)
                .HasColumnType("datetime")
                .HasColumnName("RES_DATE");
            builder.Property(e => e.ResName)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("RES_NAME");
            builder.Property(e => e.ResReturn)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("RES_RETURN");
            builder.Property(e => e.ResStat)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("RES_STAT");
            builder.Property(e => e.ResWhen)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("RES_WHEN");
            builder.Property(e => e.Rvaccompl)
                .IsUnicode(false)
                .HasColumnName("RVACCOMPL");
            builder.Property(e => e.Rvcredits)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RVCREDITS");
            builder.Property(e => e.RvdateAtt)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RVDATE_ATT");
            builder.Property(e => e.Rvddrecv)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RVDDRECV");
            builder.Property(e => e.Rvdegree)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RVDEGREE");
            builder.Property(e => e.Rvgrades)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RVGRADES");
            builder.Property(e => e.Rvmajor)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("RVMAJOR");
            builder.Property(e => e.SchCode)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("SCH_CODE");
            builder.Property(e => e.Title)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("TITLE");
            builder.Property(e => e.Unabl2vrfy).HasColumnName("UNABL2VRFY");
            builder.Property(e => e.Validated)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("VALIDATED");
        }
    }
}