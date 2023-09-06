using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Pinst
{
    public string Ost { get; set; } = null!;

    public string DlinxCode { get; set; } = null!;

    public string DlinxUser { get; set; } = null!;

    public string DlinxPw { get; set; } = null!;

    public string DlinxAscd { get; set; } = null!;

    public decimal DlinxSpec { get; set; }

    public decimal DlinxDob { get; set; }

    public bool DlinxAka { get; set; }

    public decimal DlinxXtra { get; set; }

    public string DlxNorec { get; set; } = null!;

    public string DlxYesrec { get; set; } = null!;

    public decimal DlinxXtr2 { get; set; }

    public decimal DlinxXtr3 { get; set; }

    public string Dlinxstate { get; set; } = null!;

    public string DlinxProb { get; set; } = null!;

    public decimal DlinxNmtc { get; set; }

    public decimal DlinxXtr4 { get; set; }

    public decimal DlinxA7y { get; set; }

    public decimal DlinxA7ys { get; set; }

    public decimal DlinxA7yn { get; set; }

    public decimal DlinxE7y { get; set; }

    public string Settings { get; set; } = null!;

    public int Id { get; set; }
}
