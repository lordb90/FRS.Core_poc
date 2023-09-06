using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Chwrknbr
{
    public string EmpCode { get; set; } = null!;

    public string EmpName { get; set; } = null!;

    public string Enameclean { get; set; } = null!;

    public decimal VerNum { get; set; }

    public int Id { get; set; }
}
