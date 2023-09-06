using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Vntadmin
{
    public string RTrace { get; set; } = null!;

    public string ResCode { get; set; } = null!;

    public string WebPw { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string Username { get; set; } = null!;

    public int Id { get; set; }
}
