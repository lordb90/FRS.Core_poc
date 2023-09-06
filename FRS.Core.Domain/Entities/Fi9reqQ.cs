using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Fi9reqQ
{
    public decimal Key { get; set; }

    public string Resultid { get; set; } = null!;

    public string Requestid { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string Fname { get; set; } = null!;

    public string Ssn { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string Product { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public DateTime Rdate { get; set; }

    public string Rtime { get; set; } = null!;

    public DateTime UpdDate { get; set; }

    public string UpdTime { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string Casenumber { get; set; } = null!;

    public decimal Invoiceamt { get; set; }

    public DateTime SubjAdded { get; set; }

    public int Id { get; set; }
}
