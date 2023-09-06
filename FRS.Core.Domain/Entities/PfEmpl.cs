using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class PfEmpl
{
    public decimal Key { get; set; }

    public bool CompFlag { get; set; }

    public string ResName { get; set; } = null!;

    public DateTime ResDate { get; set; }

    public string Employer { get; set; } = null!;

    public string Location { get; set; } = null!;

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

    public string QuesSet { get; set; } = null!;

    public string SpecQues { get; set; } = null!;

    public bool Complete { get; set; }

    public string Rmemo { get; set; } = null!;

    public string AddInfo { get; set; } = null!;

    public bool Discrep { get; set; }

    public string Empkey { get; set; } = null!;

    public decimal Eorder { get; set; }

    public string Rheligible { get; set; } = null!;

    public string ResStat { get; set; } = null!;

    public string ResWhen { get; set; } = null!;

    public string ResReturn { get; set; } = null!;

    public bool WebSpques { get; set; }

    public bool EmplPrint { get; set; }

    public string IntNotes { get; set; } = null!;

    public string RecallDt { get; set; } = null!;

    public decimal RecallCnt { get; set; }

    public string Clearhouse { get; set; } = null!;

    public string EmpCode { get; set; } = null!;

    public string RecalLast { get; set; } = null!;

    public DateTime Lastmodify { get; set; }

    public string Empemail { get; set; } = null!;

    public bool InternFlg { get; set; }

    public string InterData { get; set; } = null!;

    public bool RecReview { get; set; }

    public string Lnameempl { get; set; } = null!;

    public string Fnameempl { get; set; } = null!;

    public string Mnameempl { get; set; } = null!;

    public decimal Skipwknord { get; set; }

    public bool RpDotFlg { get; set; }

    public bool Unabl2vrfy { get; set; }

    public int PfKey { get; set; }

    public bool DotRegula { get; set; }

    public bool NoCharge { get; set; }

    public bool Dontreport { get; set; }
}
