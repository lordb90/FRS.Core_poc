using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Othstype
{
    public string Desc { get; set; } = null!;

    public string OstCd { get; set; } = null!;

    public bool StCSetup { get; set; }

    public string State { get; set; } = null!;

    public string County { get; set; } = null!;

    public string MlOrCl { get; set; } = null!;

    public string StdForm { get; set; } = null!;

    public decimal SupprRes { get; set; }

    public string WebReq { get; set; } = null!;

    public string InstrSet { get; set; } = null!;

    public decimal WebOrder { get; set; }

    public bool WebSkip { get; set; }

    public string DlinxCode { get; set; } = null!;

    public string DlinxUser { get; set; } = null!;

    public string DlinxPw { get; set; } = null!;

    public string DlinxAscd { get; set; } = null!;

    public decimal DlinxSpec { get; set; }

    public decimal DlinxDob { get; set; }

    public bool DlinxAka { get; set; }

    public bool Dlxbillaka { get; set; }

    public decimal DlinxXtra { get; set; }

    public bool Dlinxovral { get; set; }

    public bool Formatweb { get; set; }

    public decimal HelpNbr { get; set; }

    public string EclCrit { get; set; } = null!;

    public decimal DlinxXtr2 { get; set; }

    public decimal DlinxXtr3 { get; set; }

    public bool Dlxblakait { get; set; }

    public string Dlinxstate { get; set; } = null!;

    public decimal ExtraCost { get; set; }

    public string ExtraDesc { get; set; } = null!;

    public string DlinxProb { get; set; } = null!;

    public decimal DlinxNmtc { get; set; }

    public decimal DlinxXtr4 { get; set; }

    public decimal DlinxA7y { get; set; }

    public decimal DlinxA7ys { get; set; }

    public decimal DlinxA7yn { get; set; }

    public decimal DlinxE7y { get; set; }

    public bool Allowautop { get; set; }

    public string Settings { get; set; } = null!;

    public int Id { get; set; }
}
