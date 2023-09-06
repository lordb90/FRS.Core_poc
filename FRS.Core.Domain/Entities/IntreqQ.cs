using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class IntreqQ
{
    public decimal JobKey { get; set; }

    public string Payload { get; set; } = null!;

    public string Sourcetype { get; set; } = null!;

    public string Subtype { get; set; } = null!;

    public DateTime Received { get; set; }

    public DateTime Routed { get; set; }

    public DateTime Completed { get; set; }

    public DateTime Rejected { get; set; }

    public string Returnload { get; set; } = null!;

    public DateTime Returned { get; set; }

    public DateTime AddedFrs { get; set; }

    public DateTime AddedEcl { get; set; }

    public DateTime AddedAmc { get; set; }

    public DateTime Piireceive { get; set; }

    public string Jobtype { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public string Mname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public decimal SubjKey { get; set; }

    public string PresAddr1 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Ssn { get; set; } = null!;

    public decimal Ssno { get; set; }

    public string Resultinfo { get; set; } = null!;

    public string Converted { get; set; } = null!;

    public string Processed { get; set; } = null!;

    public string Stored { get; set; } = null!;

    public string SubjName { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public string Document1 { get; set; } = null!;

    public string Doc1name { get; set; } = null!;

    public string Doc1type { get; set; } = null!;

    public string Document2 { get; set; } = null!;

    public string Doc2name { get; set; } = null!;

    public string Doc2type { get; set; } = null!;

    public string Document3 { get; set; } = null!;

    public string Doc3name { get; set; } = null!;

    public string Doc3type { get; set; } = null!;

    public string Document4 { get; set; } = null!;

    public string Doc4name { get; set; } = null!;

    public string Doc4type { get; set; } = null!;

    public string Document5 { get; set; } = null!;

    public string Doc5name { get; set; } = null!;

    public string Doc5type { get; set; } = null!;

    public string OstDesc { get; set; } = null!;

    public string UnqOrder { get; set; } = null!;

    public string Fullresult { get; set; } = null!;

    public int Id { get; set; }
}
