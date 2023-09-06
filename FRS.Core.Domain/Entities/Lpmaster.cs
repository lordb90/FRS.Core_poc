using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Lpmaster
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

    public string TempPrt { get; set; } = null!;

    public string Billcode { get; set; } = null!;

    public decimal Price { get; set; }

    public string Comments { get; set; } = null!;

    public string RecFound { get; set; } = null!;

    public decimal NumStCty { get; set; }

    public string County1 { get; set; } = null!;

    public string State1 { get; set; } = null!;

    public bool FCrim { get; set; }

    public bool ComCrim { get; set; }

    public string SumCrim { get; set; } = null!;

    public bool FDmv { get; set; }

    public bool ComDmv { get; set; }

    public string SumDmv { get; set; } = null!;

    public bool FWkcomp { get; set; }

    public bool ComWkcomp { get; set; }

    public string SumWkcomp { get; set; } = null!;

    public bool FCredit { get; set; }

    public bool ComCredit { get; set; }

    public string SumCredit { get; set; } = null!;

    public bool FSsnver { get; set; }

    public bool ComSsnver { get; set; }

    public string SumSsnver { get; set; } = null!;

    public bool FEducat { get; set; }

    public bool ComEducat { get; set; }

    public string SumEducat { get; set; } = null!;

    public bool FEmploy { get; set; }

    public bool ComEmploy { get; set; }

    public string SumEmploy { get; set; } = null!;

    public bool FPlic { get; set; }

    public bool ComPlic { get; set; }

    public string SumPlic { get; set; } = null!;

    public bool FMlost { get; set; }

    public bool ComMlost { get; set; }

    public string SumMlost { get; set; } = null!;

    public bool FExecut { get; set; }

    public string Wkcmpsum { get; set; } = null!;

    public string KeySrc { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string Indicator { get; set; } = null!;

    public bool Rush { get; set; }

    public decimal ExtraCost { get; set; }

    public string ExtraDesc { get; set; } = null!;

    public string Requestor { get; set; } = null!;

    public string Sexrace { get; set; } = null!;

    public decimal HomeKey { get; set; }

    public string AcctMgr { get; set; } = null!;

    public string SrchInstr { get; set; } = null!;

    public DateTime CompDate { get; set; }

    public string CompTime { get; set; } = null!;

    public string CompId { get; set; } = null!;

    public bool FDmvPrt { get; set; }

    public bool FCredPrt { get; set; }

    public bool FSsnPrt { get; set; }

    public bool FWcmpPrt { get; set; }

    public bool FMlostprt { get; set; }

    public bool PartComp { get; set; }

    public string SsnRes { get; set; } = null!;

    public string CredRes { get; set; } = null!;

    public bool SrchSw { get; set; }

    public string BillDtl { get; set; } = null!;

    public bool FConltr { get; set; }

    public bool FConlPrt { get; set; }

    public bool FMlostres { get; set; }

    public bool CrJoint { get; set; }

    public decimal SpSsno { get; set; }

    public string SpFname { get; set; } = null!;

    public string SpLname { get; set; } = null!;

    public string SpMname { get; set; } = null!;

    public string Overall { get; set; } = null!;

    public bool OnHold { get; set; }

    public bool Proof { get; set; }

    public string ProofWhen { get; set; } = null!;

    public string ProofRstr { get; set; } = null!;

    public string SsnRsumm { get; set; } = null!;

    public string CredRsumm { get; set; } = null!;

    public decimal SsnPflag { get; set; }

    public decimal CredPflag { get; set; }

    public string IntId { get; set; } = null!;

    public bool AkaSpec { get; set; }

    public string WebProof { get; set; } = null!;

    public string DailyStat { get; set; } = null!;

    public bool DiscrOver { get; set; }

    public string DiscrNote { get; set; } = null!;

    public bool DiscrCrim { get; set; }

    public bool DiscrDmv { get; set; }

    public bool DiscrWcmp { get; set; }

    public bool DiscrCred { get; set; }

    public bool DiscrSsn { get; set; }

    public bool DiscrEmpl { get; set; }

    public bool DiscrEduc { get; set; }

    public bool DiscrPlic { get; set; }

    public bool DiscrMlos { get; set; }

    public string Freeze { get; set; } = null!;

    public string Billed { get; set; } = null!;

    public string RetresFmt { get; set; } = null!;

    public string SuppDoc { get; set; } = null!;

    public bool SuppDocsd { get; set; }

    public decimal MstrInv { get; set; }

    public bool SpecFilt { get; set; }

    public decimal Rextracost { get; set; }

    public string Rextradesc { get; set; } = null!;

    public string EmailReq { get; set; } = null!;

    public bool EmailThis { get; set; }

    public string ElectSig { get; set; } = null!;

    public string AttachDoc { get; set; } = null!;

    public bool Post2web { get; set; }

    public bool Posted2web { get; set; }

    public DateTime Posteddttm { get; set; }

    public string Attachorig { get; set; } = null!;

    public string Attachuser { get; set; } = null!;

    public DateTime Attachdttm { get; set; }

    public bool Everonhold { get; set; }

    public string UnqOrder { get; set; } = null!;

    public string AppPhone { get; set; } = null!;

    public string AppEmail { get; set; } = null!;

    public string Docmgaudit { get; set; } = null!;

    public string ExtraId { get; set; } = null!;

    public string SpecFlag { get; set; } = null!;

    public bool Autofreeze { get; set; }

    public decimal Adjustatus { get; set; }

    public DateTime FConprtdt { get; set; }

    public bool Attach2eml { get; set; }

    public DateTime Delaydeliv { get; set; }

    public bool SuppDoccl { get; set; }

    public string Customized { get; set; } = null!;

    public bool RetSsnver { get; set; }

    public string Linkwebadd { get; set; } = null!;

    public string PasstAkas { get; set; } = null!;

    public bool Bkgnorechk { get; set; }

    public string SpecfrsId { get; set; } = null!;

    public string Passfail { get; set; } = null!;

    public decimal AgeNum { get; set; }

    public string IntTrk1 { get; set; } = null!;

    public string IntTrk2 { get; set; } = null!;

    public string IntTrk3 { get; set; } = null!;

    public string IntTrk4 { get; set; } = null!;

    public string IntTrk5 { get; set; } = null!;

    public bool EmailAdj { get; set; }

    public string Attchaudit { get; set; } = null!;

    public string Internat { get; set; } = null!;

    public bool AaDispute { get; set; }

    public string Reqstrtype { get; set; } = null!;

    public string Reqstrusid { get; set; } = null!;

    public string MultDeliv { get; set; } = null!;

    public string ExtraInfo { get; set; } = null!;

    public decimal Quickstat { get; set; }

    public string Adjureason { get; set; } = null!;

    public string Adjucoment { get; set; } = null!;

    public string Adjuemail { get; set; } = null!;

    public string NopasstSt { get; set; } = null!;

    public string Tenantinfo { get; set; } = null!;

    public string Deluxefile { get; set; } = null!;

    public string SksCid { get; set; } = null!;

    public bool Dontdelay { get; set; }

    public string Settings { get; set; } = null!;

    public bool Dispute613 { get; set; }

    public string Salarykey { get; set; } = null!;

    public string Lockbyuser { get; set; } = null!;

    public DateTime Lockdate { get; set; }

    public int Id { get; set; }
}
