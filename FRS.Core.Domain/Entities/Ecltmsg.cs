using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Ecltmsg
{
    public decimal MsgKey { get; set; }

    public string CompCode { get; set; } = null!;

    public string Important { get; set; } = null!;

    public DateTime Created { get; set; }

    public string Subject { get; set; } = null!;

    public string From { get; set; } = null!;

    public string Reply { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string Viewed { get; set; } = null!;

    public bool Sent2web { get; set; }

    public DateTime Dtsent { get; set; }

    public int Id { get; set; }
}
