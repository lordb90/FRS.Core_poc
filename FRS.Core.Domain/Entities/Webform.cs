using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Webform
{
    public string Formname { get; set; } = null!;

    public string Formdesc { get; set; } = null!;

    public string Formlink { get; set; } = null!;

    public decimal Disporder { get; set; }

    public string Send2web { get; set; } = null!;

    public int Id { get; set; }
}
