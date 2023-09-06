using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class BkEduc
{
    public decimal Key { get; set; }

    public bool CompFlag { get; set; }

    public string ResName { get; set; } = null!;

    public DateTime ResDate { get; set; }

    public string Confirmby { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Institute { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string IPhone { get; set; } = null!;

    public string IFax { get; set; } = null!;

    public string CadateAtt { get; set; } = null!;

    public string RvdateAtt { get; set; } = null!;

    public string Camajor { get; set; } = null!;

    public string Rvmajor { get; set; } = null!;

    public string Cadegree { get; set; } = null!;

    public string Rvdegree { get; set; } = null!;

    public string Caddrecv { get; set; } = null!;

    public string Rvddrecv { get; set; } = null!;

    public string Cagrades { get; set; } = null!;

    public string Rvgrades { get; set; } = null!;

    public string Cacredits { get; set; } = null!;

    public string Rvcredits { get; set; } = null!;

    public string Caaccompl { get; set; } = null!;

    public string Rvaccompl { get; set; } = null!;

    public string Icomments { get; set; } = null!;

    public string Rcomments { get; set; } = null!;

    public bool Complete { get; set; }

    public string AddInfo { get; set; } = null!;

    public bool Discrep { get; set; }

    public string ResStat { get; set; } = null!;

    public string ResWhen { get; set; } = null!;

    public string ResReturn { get; set; } = null!;

    public string Clearhouse { get; set; } = null!;

    public string IntNotes { get; set; } = null!;

    public decimal RecallCnt { get; set; }

    public string RecallDt { get; set; } = null!;

    public string SchCode { get; set; } = null!;

    public string RecalLast { get; set; } = null!;

    public decimal Eorder { get; set; }

    public string Eduemail { get; set; } = null!;

    public bool InternFlg { get; set; }

    public string InterData { get; set; } = null!;

    public string Lnameatend { get; set; } = null!;

    public string Fnameatend { get; set; } = null!;

    public string Mnameatend { get; set; } = null!;

    public bool Unabl2vrfy { get; set; }

    public bool NoCharge { get; set; }

    public int Id { get; set; }
}
