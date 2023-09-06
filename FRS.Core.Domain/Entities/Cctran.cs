using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Cctran
{
    public string Cctransid { get; set; } = null!;

    public string Frsid { get; set; } = null!;

    public DateTime Dateenterd { get; set; }

    public string CompCode { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Customerip { get; set; } = null!;

    public decimal Amount { get; set; }

    public string Maskedcard { get; set; } = null!;

    public string Tstrequest { get; set; } = null!;

    public string Descript { get; set; } = null!;

    public string LineItem { get; set; } = null!;

    public string PoNum { get; set; } = null!;

    public string CustId { get; set; } = null!;

    public bool Recurbill { get; set; }

    public string RCode { get; set; } = null!;

    public string RSubcode { get; set; } = null!;

    public string RReasoncd { get; set; } = null!;

    public string RReason { get; set; } = null!;

    public string RAuthcode { get; set; } = null!;

    public string RResponse { get; set; } = null!;

    public bool Processed { get; set; }

    public bool Invoiced { get; set; }

    public bool Synced { get; set; }

    public string Invnum { get; set; } = null!;

    public string Typeofchrg { get; set; } = null!;

    public string UnqOrder { get; set; } = null!;

    public bool CcCharged { get; set; }

    public DateTime CcChrgdt { get; set; }

    public decimal Subjkey { get; set; }

    public string Subjfirst { get; set; } = null!;

    public string Subjmid { get; set; } = null!;

    public string Subjlast { get; set; } = null!;

    public string Subjssnmsk { get; set; } = null!;

    public DateTime Datetochrg { get; set; }

    public bool Marked { get; set; }

    public string Custprofid { get; set; } = null!;

    public string Paymprofid { get; set; } = null!;

    public string Cctranguid { get; set; } = null!;

    public int Id { get; set; }
}
