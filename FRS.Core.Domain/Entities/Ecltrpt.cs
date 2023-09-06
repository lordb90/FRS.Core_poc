using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Ecltrpt
{
    public string CompCode { get; set; } = null!;

    public string Group { get; set; } = null!;

    public string Mstrgroup { get; set; } = null!;

    public string Rdesc { get; set; } = null!;

    public DateTime Rdate { get; set; }

    public string Rdetails { get; set; } = null!;

    public string Viewed { get; set; } = null!;

    public string Link { get; set; } = null!;

    public string Attach { get; set; } = null!;

    public string AttView { get; set; } = null!;

    public bool Sent2web { get; set; }

    public DateTime Dtsent { get; set; }

    public bool ToRemove { get; set; }

    public string Remfromweb { get; set; } = null!;

    public string Remusrname { get; set; } = null!;

    public DateTime Remdttime { get; set; }

    public int Id { get; set; }
}
