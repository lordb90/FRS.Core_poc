using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Vnorder
{
    public decimal Key { get; set; }

    public decimal Weborder { get; set; }

    public string Empkey { get; set; } = null!;

    public string Vrcd { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Sdesc { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string Ssn { get; set; } = null!;

    public DateTime ReqDate { get; set; }

    public string ReqTime { get; set; } = null!;

    public string LongType { get; set; } = null!;

    public string Spflag { get; set; } = null!;

    public string Aka { get; set; } = null!;

    public string OtherInfo { get; set; } = null!;

    public string SrchInstr { get; set; } = null!;

    public string Jurisdict { get; set; } = null!;

    public string SrchCrit { get; set; } = null!;

    public string Court { get; set; } = null!;

    public string EPhone { get; set; } = null!;

    public string EFax { get; set; } = null!;

    public string Supervisor { get; set; } = null!;

    public string Eposition { get; set; } = null!;

    public string AltEmpl { get; set; } = null!;

    public string AltLoc { get; set; } = null!;

    public string AltPhone { get; set; } = null!;

    public string AltContac { get; set; } = null!;

    public string CadateAtt { get; set; } = null!;

    public string RvdateAtt { get; set; } = null!;

    public string CastTitle { get; set; } = null!;

    public string Caendtitle { get; set; } = null!;

    public string RvstTitle { get; set; } = null!;

    public string Rvendtitle { get; set; } = null!;

    public string CastDuty { get; set; } = null!;

    public string Caendduty { get; set; } = null!;

    public string RvstDuty { get; set; } = null!;

    public string Rvendduty { get; set; } = null!;

    public string CastPay { get; set; } = null!;

    public string Caendpay { get; set; } = null!;

    public string RvstPay { get; set; } = null!;

    public string Rvendpay { get; set; } = null!;

    public string CareasLv { get; set; } = null!;

    public string RvreasLv { get; set; } = null!;

    public string Rcomments { get; set; } = null!;

    public string Ecomments { get; set; } = null!;

    public string StrPoints { get; set; } = null!;

    public string WkPoints { get; set; } = null!;

    public string Sq1 { get; set; } = null!;

    public string Sq2 { get; set; } = null!;

    public string Sq3 { get; set; } = null!;

    public string Sq4 { get; set; } = null!;

    public string Sq5 { get; set; } = null!;

    public string Sq6 { get; set; } = null!;

    public string Sq7 { get; set; } = null!;

    public string Sq8 { get; set; } = null!;

    public string Sq9 { get; set; } = null!;

    public string Sq10 { get; set; } = null!;

    public string Sq11 { get; set; } = null!;

    public string Sq12 { get; set; } = null!;

    public string Sq13 { get; set; } = null!;

    public string Sq14 { get; set; } = null!;

    public string Sq15 { get; set; } = null!;

    public string Rheligible { get; set; } = null!;

    public string AddInfo { get; set; } = null!;

    public string Cform { get; set; } = null!;

    public string WebStat { get; set; } = null!;

    public DateTime WebDate { get; set; }

    public string WebTime { get; set; } = null!;

    public DateTime WcompDate { get; set; }

    public string WcompTime { get; set; } = null!;

    public string Wresults { get; set; } = null!;

    public string Extra { get; set; } = null!;

    public int Id { get; set; }
}
