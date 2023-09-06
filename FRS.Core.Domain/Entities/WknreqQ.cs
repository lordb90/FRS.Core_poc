using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class WknreqQ
{
    public decimal Key { get; set; }

    public string Resultid { get; set; } = null!;

    public string Requestid { get; set; } = null!;

    public decimal Ssno { get; set; }

    public string CompCode { get; set; } = null!;

    public DateTime Rdate { get; set; }

    public string Rtime { get; set; } = null!;

    public string Status { get; set; } = null!;

    public decimal Invoiceamt { get; set; }

    public DateTime SubjAdded { get; set; }

    public string EmpName { get; set; } = null!;

    public string EmpCode { get; set; } = null!;

    public string Stored { get; set; } = null!;

    public string Processed { get; set; } = null!;

    public string Nsctransid { get; set; } = null!;

    public string Request { get; set; } = null!;

    public string Response { get; set; } = null!;

    public DateTime Postdate { get; set; }

    public DateTime Retrydate { get; set; }

    public string SubjName { get; set; } = null!;

    public bool Noincdoemp { get; set; }

    public int Id { get; set; }
}
