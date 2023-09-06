using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Mgrmsdel
{
    public string GroupCode { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string Requestor { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string Emailaddr { get; set; } = null!;

    public string Phone { get; set; } = null!;

    public int Id { get; set; }
}
