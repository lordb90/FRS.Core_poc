using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class ResDistribute
{
    public decimal Key { get; set; }

    public string State { get; set; } = null!;

    public string County { get; set; } = null!;

    public string ResCode { get; set; } = null!;

    public string SrchType { get; set; } = null!;

    public string CmcvFlag { get; set; } = null!;

    public string Court { get; set; } = null!;

    public string SrchCrit { get; set; } = null!;

    public string Method { get; set; } = null!;

    public DateTime Submitted { get; set; }

    public DateTime Sent { get; set; }

    public string Processed { get; set; } = null!;

    public string SpecInstr { get; set; } = null!;

    public decimal Yesrectype { get; set; }

    public string ResRecip { get; set; } = null!;

    public string VoicePhon { get; set; } = null!;

    public int Id { get; set; }
}
