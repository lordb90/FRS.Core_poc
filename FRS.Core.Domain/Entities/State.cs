using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class State
{
    public string State1 { get; set; } = null!;

    public string Longname { get; set; } = null!;

    public string StSw { get; set; } = null!;

    public string StWc { get; set; } = null!;

    public string StDmv { get; set; } = null!;

    public string StAka { get; set; } = null!;

    public string StAkaSw { get; set; } = null!;

    public string Swspecinst { get; set; } = null!;

    public decimal MvrFee { get; set; }

    public string WcEnduser { get; set; } = null!;

    public string WebCty { get; set; } = null!;

    public string WebSw { get; set; } = null!;

    public decimal WebFirst { get; set; }

    public decimal MvrFee2 { get; set; }

    public decimal MvrfeeCnt { get; set; }

    public decimal NbrCtys { get; set; }

    public string Compliance { get; set; } = null!;

    public string Complialrt { get; set; } = null!;

    public string OrderOst { get; set; } = null!;

    public string Mvrvendor { get; set; } = null!;

    public bool SambaOnly { get; set; }

    public bool CompOnly { get; set; }

    public int Id { get; set; }
}
