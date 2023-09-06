using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Webattch
{
    public decimal Key { get; set; }

    public decimal Weborder { get; set; }

    public string Descriptn { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public string Location { get; set; } = null!;

    public DateTime Attachdttm { get; set; }

    public string Whoattach { get; set; } = null!;

    public bool Posted { get; set; }

    public DateTime Postdttm { get; set; }

    public bool Cc { get; set; }

    public bool Wk { get; set; }

    public bool Vr { get; set; }

    public bool Fx { get; set; }

    public bool O1 { get; set; }

    public bool O2 { get; set; }

    public bool O3 { get; set; }

    public bool O4 { get; set; }

    public bool O5 { get; set; }

    public string Zipfile { get; set; } = null!;

    public bool Archived { get; set; }

    public int Id { get; set; }
}
