using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Salestax
{
    public string InvNum { get; set; } = null!;

    public decimal InvNum2 { get; set; }

    public DateTime InvDate { get; set; }

    public decimal Salestxamt { get; set; }

    public decimal SalesTax1 { get; set; }

    public bool Taxsupchrg { get; set; }

    public string CompCode { get; set; } = null!;

    public int Id { get; set; }
}
