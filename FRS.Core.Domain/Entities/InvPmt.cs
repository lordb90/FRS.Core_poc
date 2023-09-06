using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class InvPmt
{
    public DateTime Pmtdate { get; set; }

    public decimal Pmtamount { get; set; }

    public string Pmtdesc { get; set; } = null!;

    public string Pmtcommnts { get; set; } = null!;

    public decimal Pmtkeyid { get; set; }

    public string Enteredby { get; set; } = null!;

    public int Id { get; set; }
}
