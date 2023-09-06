using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Vntrack
{
    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime Logdate { get; set; }

    public string Logtime { get; set; } = null!;

    public string Logurl { get; set; } = null!;

    public string LocalAddr { get; set; } = null!;

    public string RemoteAdd { get; set; } = null!;

    public string HttpUser { get; set; } = null!;

    public string Logsuccess { get; set; } = null!;

    public int Id { get; set; }
}
