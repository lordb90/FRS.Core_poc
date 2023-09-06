using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Gistracking
{
    public decimal Uniqueid { get; set; }

    public string Idvalue { get; set; } = null!;

    public DateTime DtReceive { get; set; }

    public string Ssn { get; set; } = null!;

    public string Givenname { get; set; } = null!;

    public string Middlename { get; set; } = null!;

    public string Familyname { get; set; } = null!;

    public string County { get; set; } = null!;

    public string State { get; set; } = null!;

    public bool Returned { get; set; }

    public DateTime DtReturn { get; set; }

    public int Id { get; set; }
}
