using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class BkDlxrq
{
    public decimal Key { get; set; }

    public string CompCode { get; set; } = null!;

    public string Frsproduct { get; set; } = null!;

    public string OstDesc { get; set; } = null!;

    public string OstType { get; set; } = null!;

    public string Version { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string AffSupCd { get; set; } = null!;

    public string SiteId { get; set; } = null!;

    public string Transid { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Namefirst { get; set; } = null!;

    public string Namemiddle { get; set; } = null!;

    public string Namelast { get; set; } = null!;

    public string Namesuffix { get; set; } = null!;

    public string Aka { get; set; } = null!;

    public string Ssn { get; set; } = null!;

    public string Dobyear { get; set; } = null!;

    public string Dobmonth { get; set; } = null!;

    public string Dobday { get; set; } = null!;

    public string SearchSt { get; set; } = null!;

    public bool DispJuris { get; set; }

    public decimal DlinxDob { get; set; }

    public decimal DlinxXtra { get; set; }

    public bool Incnulldob { get; set; }

    public bool Namematch { get; set; }

    public string Billngcode { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string Queryid { get; set; } = null!;

    public string SubjName { get; set; } = null!;

    public DateTime Qdate { get; set; }

    public string Qtime { get; set; } = null!;

    public DateTime Senddate { get; set; }

    public string Sendtime { get; set; } = null!;

    public string Processed { get; set; } = null!;

    public string Stored { get; set; } = null!;

    public string Ecode { get; set; } = null!;

    public string Srequest { get; set; } = null!;

    public string Response { get; set; } = null!;

    public string RespExtra { get; set; } = null!;

    public decimal NumAkas { get; set; }

    public string RespAka1 { get; set; } = null!;

    public string RespAka2 { get; set; } = null!;

    public string RespAka3 { get; set; } = null!;

    public string RextrAka1 { get; set; } = null!;

    public string RextrAka2 { get; set; } = null!;

    public string RextrAka3 { get; set; } = null!;

    public string SreqAka { get; set; } = null!;

    public decimal NbrHits { get; set; }

    public decimal Attempts { get; set; }

    public string AttHist { get; set; } = null!;

    public bool Dlinxovral { get; set; }

    public string RespAka4 { get; set; } = null!;

    public string RespAka5 { get; set; } = null!;

    public string RespAka6 { get; set; } = null!;

    public string RespAka7 { get; set; } = null!;

    public string RespAka8 { get; set; } = null!;

    public string RespAka9 { get; set; } = null!;

    public string RextrAka4 { get; set; } = null!;

    public string RextrAka5 { get; set; } = null!;

    public string RextrAka6 { get; set; } = null!;

    public string RextrAka7 { get; set; } = null!;

    public string RextrAka8 { get; set; } = null!;

    public string RextrAka9 { get; set; } = null!;

    public int Id { get; set; }
}
