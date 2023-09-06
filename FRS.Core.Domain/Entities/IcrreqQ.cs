using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class IcrreqQ
{
    public string Name { get; set; } = null!;

    public string Ssn { get; set; } = null!;

    public string Bureau { get; set; } = null!;

    public string BurType { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public decimal Key { get; set; }

    public DateTime Senddate { get; set; }

    public string Sendtime { get; set; } = null!;

    public bool RetrAtweb { get; set; }

    public string Webresults { get; set; } = null!;

    public string ExtraInfo { get; set; } = null!;

    public string Returned { get; set; } = null!;

    public bool Compressed { get; set; }

    public int Uncompsize { get; set; }

    public int Id { get; set; }
}
