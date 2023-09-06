using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class IhrMwork
{
    public decimal Key { get; set; }

    public bool Select { get; set; }

    public string Fullname { get; set; } = null!;

    public string Dob { get; set; } = null!;

    public string Jurisdictn { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Akas { get; set; } = null!;

    public string Details { get; set; } = null!;

    public string Offense { get; set; } = null!;

    public string OffType { get; set; } = null!;

    public string OffDate { get; set; } = null!;

    public string Frsproduct { get; set; } = null!;

    public int PfmlKey { get; set; }

    public int Id { get; set; }
}
