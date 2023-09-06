using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Stibatch
{
    public decimal Key { get; set; }

    public string StiKey { get; set; } = null!;

    public string State1 { get; set; } = null!;

    public string License1 { get; set; } = null!;

    public string Name { get; set; } = null!;

    public DateTime Bdate { get; set; }

    public string Btime { get; set; } = null!;

    public DateTime Rdate { get; set; }

    public string Method { get; set; } = null!;

    public string Rtime { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string History { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string Usercd { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime Lastdtchk { get; set; }

    public int Id { get; set; }
}
