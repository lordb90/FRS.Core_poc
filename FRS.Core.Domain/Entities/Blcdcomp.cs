using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Blcdcomp
{
    public string Billcode { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public decimal Price { get; set; }

    public decimal MaxCrim { get; set; }

    public decimal MaxCvl { get; set; }

    public decimal MaxFed { get; set; }

    public decimal MaxOth { get; set; }

    public decimal MaxAka { get; set; }

    public decimal AkaChgTy { get; set; }

    public decimal AkaFlatrt { get; set; }

    public decimal MaxMvr { get; set; }

    public decimal MaxWkcmp { get; set; }

    public decimal MaxEduc { get; set; }

    public decimal MaxEmpl { get; set; }

    public decimal MaxPlic { get; set; }

    public decimal MaxMlost { get; set; }

    public bool InteducCk { get; set; }

    public decimal InteducPr { get; set; }

    public bool IntemplCk { get; set; }

    public decimal IntemplPr { get; set; }

    public bool SetOrder { get; set; }

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

    public string Defmlost1 { get; set; } = null!;

    public string Defmlost2 { get; set; } = null!;

    public string Defmlost3 { get; set; } = null!;

    public string Defmlost4 { get; set; } = null!;

    public string Defmlost5 { get; set; } = null!;

    public string Incstinpkg { get; set; } = null!;

    public decimal PstCtyasn { get; set; }

    public decimal PstCtynbr { get; set; }

    public decimal PstCtyyrs { get; set; }

    public bool PstSwAsn { get; set; }

    public bool PstInccty { get; set; }

    public bool PstAcAsn { get; set; }

    public bool PstCurasn { get; set; }

    public decimal PstFedasn { get; set; }

    public decimal PstFednbr { get; set; }

    public decimal PstFedyrs { get; set; }

    public bool PstCtyNa { get; set; }

    public decimal PstCtysrc { get; set; }

    public bool Pstshowsum { get; set; }

    public string PstYrsrch { get; set; } = null!;

    public string PstFysrch { get; set; } = null!;

    public bool PstUsepkg { get; set; }

    public bool CreditOop { get; set; }

    public bool SsnverOop { get; set; }

    public bool PstCurfed { get; set; }

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

    public bool PstCivupp { get; set; }

    public bool PstCivlow { get; set; }

    public bool PstFulsta { get; set; }

    public decimal MaxSw { get; set; }

    public string Inactive { get; set; } = null!;

    public decimal PstMaxSw { get; set; }

    public bool PstOrdSw { get; set; }

    public string PstSupSw { get; set; } = null!;

    public bool PstCtytoo { get; set; }

    public int Id { get; set; }
}
