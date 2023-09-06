using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class LpmasterAudit
{
    public decimal Key { get; set; }

    public string Fname { get; set; } = null!;

    public string Mname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public decimal Ssno { get; set; }

    public string CompCode { get; set; } = null!;

    public string Position { get; set; } = null!;

    public string Aka { get; set; } = null!;

    public string PresAddr1 { get; set; } = null!;

    public DateTime RecDate { get; set; }

    public string RecTime { get; set; } = null!;

    public bool FullyComp { get; set; }

    public string Printed { get; set; } = null!;

    public DateTime DateSent { get; set; }

    public string TimeSent { get; set; } = null!;

    public string SentVia { get; set; } = null!;

    public string Billcode { get; set; } = null!;

    public string Comments { get; set; } = null!;

    public string RecFound { get; set; } = null!;

    public decimal NumStCty { get; set; }

    public string County1 { get; set; } = null!;

    public string State1 { get; set; } = null!;

    public bool FDmv { get; set; }

    public bool ComDmv { get; set; }

    public bool FWkcomp { get; set; }

    public bool ComWkcomp { get; set; }

    public bool FCredit { get; set; }

    public bool ComCredit { get; set; }

    public bool FSsnver { get; set; }

    public bool ComSsnver { get; set; }

    public bool FMlost { get; set; }

    public bool ComMlost { get; set; }

    public string Reference { get; set; } = null!;

    public string Requestor { get; set; } = null!;

    public string AcctMgr { get; set; } = null!;

    public DateTime CompDate { get; set; }

    public string CompTime { get; set; } = null!;

    public bool FDmvPrt { get; set; }

    public bool FCredPrt { get; set; }

    public bool FSsnPrt { get; set; }

    public bool FWcmpPrt { get; set; }

    public bool FMlostprt { get; set; }

    public bool FConltr { get; set; }

    public bool OnHold { get; set; }

    public bool Proof { get; set; }

    public string IntId { get; set; } = null!;

    public string WebProof { get; set; } = null!;

    public bool DiscrOver { get; set; }

    public string Freeze { get; set; } = null!;

    public string Billed { get; set; } = null!;

    public string UnqOrder { get; set; } = null!;

    public decimal AgeNum { get; set; }

    public string IntTrk1 { get; set; } = null!;

    public string IntTrk2 { get; set; } = null!;

    public string IntTrk3 { get; set; } = null!;

    public string IntTrk4 { get; set; } = null!;

    public string IntTrk5 { get; set; } = null!;

    public bool AaDispute { get; set; }

    public string MultDeliv { get; set; } = null!;

    public DateTime FConprtdt { get; set; }

    public int Id { get; set; }
}
