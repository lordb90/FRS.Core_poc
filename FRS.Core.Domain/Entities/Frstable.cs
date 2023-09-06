using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Frstable
{
    public string Tablename { get; set; } = null!;

    public string Descriptn { get; set; } = null!;

    public string Indxtag { get; set; } = null!;

    public string Indxtype { get; set; } = null!;

    public string Indxkey { get; set; } = null!;

    public string Indxfilter { get; set; } = null!;

    public string Indxorder { get; set; } = null!;

    public string Indxcolate { get; set; } = null!;

    public bool Checkifc { get; set; }

    public bool Fptexists { get; set; }

    public bool Cnt4thermo { get; set; }

    public bool Opt4bkup { get; set; }

    public int Id { get; set; }
}
