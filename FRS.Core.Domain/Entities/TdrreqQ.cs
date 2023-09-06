using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class TdrreqQ
{
    public int TdrreqKey { get; set; }

    public decimal Key { get; set; }

    public int PfmlosKey { get; set; }

    public int PfmvrKey { get; set; }

    public string Dlnum { get; set; } = null!;

    public string Dlstate { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public string Mname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string Gender { get; set; } = null!;

    public decimal Ssno { get; set; }

    public DateTime Birthdate { get; set; }

    public string ProdCode { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public decimal Statuscode { get; set; }

    public string Statustext { get; set; } = null!;

    public string Stored { get; set; } = null!;

    public string Processed { get; set; } = null!;

    public string Tdrtrackid { get; set; } = null!;

    public string Request { get; set; } = null!;

    public string Response { get; set; } = null!;

    public DateTime DateAdded { get; set; }

    public DateTime DatePost { get; set; }

    public DateTime Retrydate { get; set; }

    public string PresAddr1 { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public decimal Attempts { get; set; }
}
