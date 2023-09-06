using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Billxtra
{
    public decimal Key { get; set; }

    public string CompCode { get; set; } = null!;

    public string CompName { get; set; } = null!;

    public string Username { get; set; } = null!;

    public DateTime Dateenterd { get; set; }

    public DateTime Datebilled { get; set; }

    public decimal Amount { get; set; }

    public string Descript { get; set; } = null!;

    public string Invoiced { get; set; } = null!;

    public string SubjName { get; set; } = null!;

    public int Id { get; set; }
}
