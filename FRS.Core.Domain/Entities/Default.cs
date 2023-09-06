using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Default
{
    public bool FCrim { get; set; }

    public bool FDmv { get; set; }

    public bool FWkcomp { get; set; }

    public bool FCredit { get; set; }

    public bool FSsnver { get; set; }

    public bool FEducat { get; set; }

    public bool FEmploy { get; set; }

    public bool FPlic { get; set; }

    public bool FMlost { get; set; }

    public bool FExecut { get; set; }

    public bool CrimOnly { get; set; }

    public bool Rush { get; set; }

    public bool SrchFel { get; set; }

    public bool SrchMisd { get; set; }

    public bool SrchFed { get; set; }

    public bool SrchLc { get; set; }

    public bool SrchUc { get; set; }

    public bool SrchOth { get; set; }

    public string OthDesc { get; set; } = null!;

    public string CmcvFlag { get; set; } = null!;

    public decimal Yesrectype { get; set; }

    public bool ConfirmOn { get; set; }

    public bool SrchSw { get; set; }

    public decimal Cntyoptflg { get; set; }

    public decimal NextField { get; set; }

    public string Defmlost1 { get; set; } = null!;

    public string Defmlost2 { get; set; } = null!;

    public string Defmlost3 { get; set; } = null!;

    public string Defmlost4 { get; set; } = null!;

    public string Defmlost5 { get; set; } = null!;

    public string Defmlost6 { get; set; } = null!;

    public string Defmlost7 { get; set; } = null!;

    public string Defmlost8 { get; set; } = null!;

    public string Defmlost9 { get; set; } = null!;

    public string Defmlost10 { get; set; } = null!;

    public string Defmlost11 { get; set; } = null!;

    public string Defmlost12 { get; set; } = null!;

    public string Defmlost13 { get; set; } = null!;

    public string Defmlost14 { get; set; } = null!;

    public string Defmlost15 { get; set; } = null!;

    public string Defmlost16 { get; set; } = null!;

    public string Defmlost17 { get; set; } = null!;

    public string Defmlost18 { get; set; } = null!;

    public string Defmlost19 { get; set; } = null!;

    public string Defmlost20 { get; set; } = null!;

    public int Id { get; set; }
}
