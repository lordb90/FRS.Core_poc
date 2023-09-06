using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Invoice
{
    public string Invnum { get; set; } = null!;

    public decimal Invamt { get; set; }

    public DateTime Datepaid { get; set; }

    public string Workdates { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public decimal InvimgNbr { get; set; }

    public DateTime DueDate { get; set; }

    public DateTime GenDate { get; set; }

    public decimal NbrSearch { get; set; }

    public string DelMeth { get; set; } = null!;

    public decimal Pmtkeyid { get; set; }

    public decimal Amtpaid { get; set; }

    public decimal Invnum2 { get; set; }

    public decimal BldtBasis { get; set; }

    public string Exportname { get; set; } = null!;

    public decimal SuppCost { get; set; }

    public decimal Salestax { get; set; }

    public decimal Pmtprocamt { get; set; }

    public string CompName { get; set; } = null!;

    public int Id { get; set; }
}
