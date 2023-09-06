using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;


public partial class Audit
{
    public string Acode { get; set; } = null!;

    public string Auser { get; set; } = null!;

    public string Adate { get; set; } = null!;

    public string Atime { get; set; } = null!;

    public string Aref { get; set; } = null!;

    public decimal Akey { get; set; }

    public int Id { get; set; }
}
