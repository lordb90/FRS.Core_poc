using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Ecltacct
{
    public string CompCode { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string WebPw { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string ReqEmail { get; set; } = null!;

    public string SecReq { get; set; } = null!;

    public string SecRes { get; set; } = null!;

    public string SecStat { get; set; } = null!;

    public string AdmRpts { get; set; } = null!;

    public string AdmBill { get; set; } = null!;

    public string AdmAcct { get; set; } = null!;

    public string Otherinfo { get; set; } = null!;

    public DateTime Requested { get; set; }

    public string Approved { get; set; } = null!;

    public DateTime ProcDate { get; set; }

    public string ProcUser { get; set; } = null!;

    public string Seereqonly { get; set; } = null!;

    public string ReqName { get; set; } = null!;

    public DateTime Createdate { get; set; }

    public string Pwquestion { get; set; } = null!;

    public string Pwanswer { get; set; } = null!;

    public int Id { get; set; }
}
