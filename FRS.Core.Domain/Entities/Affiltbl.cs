using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;


public partial class Affiltbl
{
    public string AffCode { get; set; } = null!;

    public string AffName { get; set; } = null!;

    public string Attention { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string Address3 { get; set; } = null!;

    public string FaxNumber { get; set; } = null!;

    public string VoicePhon { get; set; } = null!;

    public string Aemail { get; set; } = null!;

    public decimal Billtype { get; set; }

    public string Notes { get; set; } = null!;

    public string Logo { get; set; } = null!;

    public string StiUserid { get; set; } = null!;

    public string StiUsercd { get; set; } = null!;

    public string StiPasswd { get; set; } = null!;

    public string Stica2ndpw { get; set; } = null!;

    public DateTime Stica2date { get; set; }

    public string Altfromeml { get; set; } = null!;

    public DateTime Stipasdate { get; set; }

    public string MvrCAcct { get; set; } = null!;

    public string MvrCUser { get; set; } = null!;

    public string MvrCPass { get; set; } = null!;

    public DateTime MvrCDate { get; set; }

    public string StiPacode { get; set; } = null!;

    public int Id { get; set; }
}
