using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class PstreqQ
{
    public decimal Key { get; set; }

    public string CompCode { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Glbpurpose { get; set; } = null!;

    public string Dlpurpose { get; set; } = null!;

    public string Version { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Namefirst { get; set; } = null!;

    public string Namemiddle { get; set; } = null!;

    public string Namelast { get; set; } = null!;

    public string Namesuffix { get; set; } = null!;

    public string Address1 { get; set; } = null!;

    public string Address2 { get; set; } = null!;

    public string Addrlast { get; set; } = null!;

    public string Streetnbr { get; set; } = null!;

    public string Streetpre { get; set; } = null!;

    public string Streetname { get; set; } = null!;

    public string Streetpost { get; set; } = null!;

    public string Streetsuff { get; set; } = null!;

    public string Unitnumber { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string Zip4 { get; set; } = null!;

    public string Radius { get; set; } = null!;

    public string Phone10 { get; set; } = null!;

    public string Ssn { get; set; } = null!;

    public string Ssnlast4 { get; set; } = null!;

    public string Dobyear { get; set; } = null!;

    public string Dobmonth { get; set; } = null!;

    public string Dobday { get; set; } = null!;

    public string Agelow { get; set; } = null!;

    public string Agehigh { get; set; } = null!;

    public string Verifyssns { get; set; } = null!;

    public string Usephonet { get; set; } = null!;

    public string Nonickname { get; set; } = null!;

    public string StartingR { get; set; } = null!;

    public string Returncnt { get; set; } = null!;

    public string Subpriorad { get; set; } = null!;

    public string Billngcode { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string Queryid { get; set; } = null!;

    public string Bankruptcy { get; set; } = null!;

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

    public string RespRfmt { get; set; } = null!;

    public string Alerts { get; set; } = null!;

    public decimal NbrCtys { get; set; }

    public decimal NbrAddr { get; set; }

    public decimal Attempts { get; set; }

    public string AttHist { get; set; } = null!;

    public bool RetrAtweb { get; set; }

    public bool Respcompre { get; set; }

    public int Respuncosz { get; set; }

    public bool Rfmtcompre { get; set; }

    public int Rfmtuncosz { get; set; }

    public bool AttCompre { get; set; }

    public int AttUncosz { get; set; }

    public string RespRtn { get; set; } = null!;

    public bool Rrtncompre { get; set; }

    public int Rrtnuncosz { get; set; }

    public bool Pstreviewd { get; set; }

    public int Id { get; set; }
}
