using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class EmailQ
{
    public decimal EmailId { get; set; }

    public string Type { get; set; } = null!;

    public string Subtype { get; set; } = null!;

    public decimal Format { get; set; }

    public string EmailAddr { get; set; } = null!;

    public string Toname { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string Sendtime { get; set; } = null!;

    public DateTime Senddate { get; set; }

    public string SentTime { get; set; } = null!;

    public DateTime SentDate { get; set; }

    public string Status { get; set; } = null!;

    public decimal Retries { get; set; }

    public decimal Ecode { get; set; }

    public string WhoSub { get; set; } = null!;

    public bool Printed { get; set; }

    public string WhoDel { get; set; } = null!;

    public string Comprescod { get; set; } = null!;

    public string Fromemladr { get; set; } = null!;

    public bool Invrdy2snd { get; set; }

    public string Rpassword { get; set; } = null!;

    public string Addtlcode { get; set; } = null!;

    public string Replyto { get; set; } = null!;

    public int Id { get; set; }
}
