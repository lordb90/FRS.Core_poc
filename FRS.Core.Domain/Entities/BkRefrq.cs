using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class BkRefrq
{
    public decimal Key { get; set; }

    public string CompCode { get; set; } = null!;

    public string Clientid { get; set; } = null!;

    public string Clntsubid { get; set; } = null!;

    public string Rppassword { get; set; } = null!;

    public string VerType { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Namefirst { get; set; } = null!;

    public string Namemiddle { get; set; } = null!;

    public string Namelast { get; set; } = null!;

    public string Aka { get; set; } = null!;

    public string Ssn { get; set; } = null!;

    public DateTime Qdate { get; set; }

    public string Qtime { get; set; } = null!;

    public DateTime Senddate { get; set; }

    public string Sendtime { get; set; } = null!;

    public string Processed { get; set; } = null!;

    public string Returned { get; set; } = null!;

    public string Stored { get; set; } = null!;

    public string Srequest { get; set; } = null!;

    public string Response { get; set; } = null!;

    public decimal NumAkas { get; set; }

    public decimal Attempts { get; set; }

    public string AttHist { get; set; } = null!;

    public string Rporderid { get; set; } = null!;

    public string Rpconfirm { get; set; } = null!;

    public string Rperrormsg { get; set; } = null!;

    public string WebStat { get; set; } = null!;

    public string Empkey { get; set; } = null!;

    public string StrPoints { get; set; } = null!;

    public string Jurisdict { get; set; } = null!;

    public string OtherInfo { get; set; } = null!;

    public DateTime WcompDate { get; set; }

    public string WcompTime { get; set; } = null!;

    public string Wtype { get; set; } = null!;

    public string LongType { get; set; } = null!;

    public string Sdesc { get; set; } = null!;

    public bool InternFlg { get; set; }

    public int Id { get; set; }
}
