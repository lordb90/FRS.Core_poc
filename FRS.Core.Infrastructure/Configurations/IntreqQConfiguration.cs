using FRS.Core.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FRS.Enterprise.Infrastructure.Data.Configurations
{
    public class IntreqQConfiguration : IEntityTypeConfiguration<IntreqQ>
    {
        public void Configure(EntityTypeBuilder<IntreqQ> builder)
        {
            builder
                .HasNoKey()
                .ToTable("INTREQ_Q");

            builder.Property(e => e.AddedAmc)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("ADDED_AMC");
            builder.Property(e => e.AddedEcl)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("ADDED_ECL");
            builder.Property(e => e.AddedFrs)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("ADDED_FRS");
            builder.Property(e => e.City)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CITY");
            builder.Property(e => e.CompCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("COMP_CODE");
            builder.Property(e => e.Completed)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("COMPLETED");
            builder.Property(e => e.Converted)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("CONVERTED");
            builder.Property(e => e.Doc1name)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOC1NAME");
            builder.Property(e => e.Doc1type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOC1TYPE");
            builder.Property(e => e.Doc2name)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOC2NAME");
            builder.Property(e => e.Doc2type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOC2TYPE");
            builder.Property(e => e.Doc3name)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOC3NAME");
            builder.Property(e => e.Doc3type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOC3TYPE");
            builder.Property(e => e.Doc4name)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOC4NAME");
            builder.Property(e => e.Doc4type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOC4TYPE");
            builder.Property(e => e.Doc5name)
                .HasMaxLength(75)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOC5NAME");
            builder.Property(e => e.Doc5type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOC5TYPE");
            builder.Property(e => e.Document1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOCUMENT1");
            builder.Property(e => e.Document2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOCUMENT2");
            builder.Property(e => e.Document3)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOCUMENT3");
            builder.Property(e => e.Document4)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOCUMENT4");
            builder.Property(e => e.Document5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("DOCUMENT5");
            builder.Property(e => e.Fname)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FNAME");
            builder.Property(e => e.Fullresult)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("FULLRESULT");
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            builder.Property(e => e.JobKey)
                .HasColumnType("numeric(15, 0)")
                .HasColumnName("JOB_KEY");
            builder.Property(e => e.Jobtype)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("JOBTYPE");
            builder.Property(e => e.Lname)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("LNAME");
            builder.Property(e => e.Mname)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("MNAME");
            builder.Property(e => e.OstDesc)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("OST_DESC");
            builder.Property(e => e.Payload)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PAYLOAD");
            builder.Property(e => e.Piireceive)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("PIIRECEIVE");
            builder.Property(e => e.PresAddr1)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PRES_ADDR1");
            builder.Property(e => e.Processed)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("PROCESSED");
            builder.Property(e => e.Received)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("RECEIVED");
            builder.Property(e => e.Rejected)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("REJECTED");
            builder.Property(e => e.Resultinfo)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RESULTINFO");
            builder.Property(e => e.Returned)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("RETURNED");
            builder.Property(e => e.Returnload)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("RETURNLOAD");
            builder.Property(e => e.Routed)
                .HasDefaultValueSql("('')")
                .HasColumnType("datetime")
                .HasColumnName("ROUTED");
            builder.Property(e => e.Sourcetype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SOURCETYPE");
            builder.Property(e => e.Ssn)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SSN");
            builder.Property(e => e.Ssno)
                .HasColumnType("numeric(9, 0)")
                .HasColumnName("SSNO");
            builder.Property(e => e.State)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STATE");
            builder.Property(e => e.Stored)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("STORED");
            builder.Property(e => e.SubjKey)
                .HasColumnType("numeric(8, 0)")
                .HasColumnName("SUBJ_KEY");
            builder.Property(e => e.SubjName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBJ_NAME");
            builder.Property(e => e.Subtype)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("SUBTYPE");
            builder.Property(e => e.UnqOrder)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("UNQ_ORDER");
            builder.Property(e => e.Zip)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValueSql("('')")
                .HasColumnName("ZIP");
        }
    }
}