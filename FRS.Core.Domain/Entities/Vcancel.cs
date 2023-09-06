using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Vcancel
{
    public DateTime Vdate { get; set; }

    public decimal Weborder { get; set; }

    public string Type { get; set; } = null!;

    public decimal Key { get; set; }

    public string Empkey { get; set; } = null!;

    public string LongType { get; set; } = null!;

    public string Spflag { get; set; } = null!;

    public string OtherInfo { get; set; } = null!;

    public string Jurisdict { get; set; } = null!;

    public string StrPoints { get; set; } = null!;

    public bool Done { get; set; }

    public int Id { get; set; }
}
