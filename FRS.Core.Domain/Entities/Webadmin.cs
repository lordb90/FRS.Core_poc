using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Webadmin
{
    public string CompCode { get; set; } = null!;

    public string WebPw { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string SecReq { get; set; } = null!;

    public string SecRes { get; set; } = null!;

    public string SecStat { get; set; } = null!;

    public string SecBill { get; set; } = null!;

    public string Wemail { get; set; } = null!;

    public string ReqEmail { get; set; } = null!;

    public bool ReqOnly { get; set; }

    public bool VuAlerts { get; set; }

    public string ConthrTxt { get; set; } = null!;

    public bool ViewAdjud { get; set; }

    public bool AdmAcct { get; set; }

    public bool AdmBill { get; set; }

    public bool AdmRpts { get; set; }

    public bool Fi9Approv { get; set; }

    public bool AdmOlapps { get; set; }

    public bool AdmOlPkg { get; set; }

    public bool AdmOlCfg { get; set; }

    public bool AdmOlques { get; set; }

    public bool AdmOl2bg { get; set; }

    public bool AdmOlFlg { get; set; }

    public bool EmailAdj { get; set; }

    public bool SuprView { get; set; }

    public string Userinfo { get; set; } = null!;

    public string Pquestion { get; set; } = null!;

    public string Panswer { get; set; } = null!;

    public bool Isapproved { get; set; }

    public DateTime LActivity { get; set; }

    public DateTime PchangeDt { get; set; }

    public bool Isonline { get; set; }

    public bool Islocked { get; set; }

    public DateTime Lastlockdt { get; set; }

    public decimal FpLogcnt { get; set; }

    public DateTime FpStartD { get; set; }

    public decimal FpAnsCnt { get; set; }

    public DateTime FpAnsSt { get; set; }

    public string Expand1 { get; set; } = null!;

    public bool CcAccess { get; set; }

    public bool CcUse { get; set; }

    public bool ApGrading { get; set; }

    public bool ViewPf { get; set; }

    public bool ChangePf { get; set; }

    public bool Restrictp1 { get; set; }

    public bool Restrictp2 { get; set; }

    public bool Restrictp3 { get; set; }

    public bool Restrictp4 { get; set; }

    public bool Restrictp5 { get; set; }

    public bool Restrictp6 { get; set; }

    public bool Restrictp7 { get; set; }

    public bool Restrictp8 { get; set; }

    public bool Restrictp9 { get; set; }

    public decimal Emlrsltype { get; set; }

    public string Addrslteml { get; set; } = null!;

    public bool AdmOlMe { get; set; }

    public bool VuAlSupr { get; set; }

    public string ReqPhone { get; set; } = null!;

    public int Id { get; set; }
}
