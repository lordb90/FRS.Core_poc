using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class NscreqQ
{
    public decimal Key { get; set; }

    public string Resultid { get; set; } = null!;

    public string Requestid { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public decimal Ssno { get; set; }

    public DateTime Birthdate { get; set; }

    public string Product { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public DateTime Rdate { get; set; }

    public string Rtime { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Casenumber { get; set; } = null!;

    public decimal Invoiceamt { get; set; }

    public DateTime SubjAdded { get; set; }

    public string Mname { get; set; } = null!;

    public string Institute { get; set; } = null!;

    public string SchCode { get; set; } = null!;

    public string Cadegree { get; set; } = null!;

    public string Caddrecv { get; set; } = null!;

    public string Stored { get; set; } = null!;

    public string Processed { get; set; } = null!;

    public string Nsctransid { get; set; } = null!;

    public string Request { get; set; } = null!;

    public string Response { get; set; } = null!;

    public DateTime Postdate { get; set; }

    public DateTime Retrydate { get; set; }

    public string Dvconfirm { get; set; } = null!;

    public int Id { get; set; }
}
