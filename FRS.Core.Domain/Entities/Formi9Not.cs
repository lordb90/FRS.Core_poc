using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Formi9Not
{
    public string Resultid { get; set; } = null!;

    public string Requestid { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Lastname { get; set; } = null!;

    public string Mi { get; set; } = null!;

    public string Ssn { get; set; } = null!;

    public string Dob { get; set; } = null!;

    public string Alipartid { get; set; } = null!;

    public string Service { get; set; } = null!;

    public string Serviceres { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Casenumber { get; set; } = null!;

    public string Invoiceamt { get; set; } = null!;

    public string Resultxml { get; set; } = null!;

    public string Versionnbr { get; set; } = null!;

    public decimal Fi9key { get; set; }

    public DateTime Postdate { get; set; }

    public string Posttime { get; set; } = null!;

    public string Errorcode { get; set; } = null!;

    public string Errormsg { get; set; } = null!;

    public bool Processed { get; set; }

    public DateTime ProcDate { get; set; }

    public string ProcTime { get; set; } = null!;

    public string ProcTrack { get; set; } = null!;

    public int Id { get; set; }
}
