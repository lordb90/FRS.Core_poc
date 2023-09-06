using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Faxqueue
{
    public string Toname { get; set; } = null!;

    public string Tonumber { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public string Sendtime { get; set; } = null!;

    public DateTime Senddate { get; set; }

    public string SentTime { get; set; } = null!;

    public DateTime SentDate { get; set; }

    public decimal Totalpages { get; set; }

    public decimal PagesSent { get; set; }

    public string Timelength { get; set; } = null!;

    public string Remoteid { get; set; } = null!;

    public decimal FaxSpeed { get; set; }

    public decimal FaxPort { get; set; }

    public decimal Faxid { get; set; }

    public decimal Faxlogid { get; set; }

    public string Status { get; set; } = null!;

    public decimal Ecode { get; set; }

    public decimal Hangcode { get; set; }

    public decimal Codetype { get; set; }

    public decimal Retries { get; set; }

    public string WhoSub { get; set; } = null!;

    public decimal Priority { get; set; }

    public bool Resub { get; set; }

    public bool Printed { get; set; }

    public string WhoDel { get; set; } = null!;

    public DateTime IrecDate { get; set; }

    public string IrecTime { get; set; } = null!;

    public decimal FaxVia { get; set; }

    public string ItransId { get; set; } = null!;

    public string IrtnStat { get; set; } = null!;

    public string IrtnTrans { get; set; } = null!;

    public string IsentResp { get; set; } = null!;

    public string IstatResp { get; set; } = null!;

    public string IsentXml { get; set; } = null!;

    public decimal SubjKey { get; set; }

    public int Id { get; set; }
}
