using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Blcdjur
{
    public string Billcode { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public string Crstate { get; set; } = null!;

    public string County { get; set; } = null!;

    public string CmcvFlag { get; set; } = null!;

    public bool SrchFel { get; set; }

    public bool SrchMisd { get; set; }

    public bool SrchFed { get; set; }

    public bool SrchUc { get; set; }

    public bool SrchLc { get; set; }

    public bool SrchOth { get; set; }

    public string OthDesc { get; set; } = null!;

    public string SrchCrit { get; set; } = null!;

    public string Court { get; set; } = null!;

    public bool Noaddst { get; set; }

    public int Id { get; set; }
}
