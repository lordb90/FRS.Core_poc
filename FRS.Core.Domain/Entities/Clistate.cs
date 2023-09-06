using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Clistate
{
    public string State { get; set; } = null!;

    public string Years { get; set; } = null!;

    public string CourtDesc { get; set; } = null!;

    public string SwYears { get; set; } = null!;

    public string FedYears { get; set; } = null!;

    public string CvlYears { get; set; } = null!;

    public string OthYears { get; set; } = null!;

    public string SwCourt { get; set; } = null!;

    public string FedCourt { get; set; } = null!;

    public string CvlCourt { get; set; } = null!;

    public string OthCourt { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public decimal CcEc10 { get; set; }

    public decimal CcEc15 { get; set; }

    public decimal CcEcUnl { get; set; }

    public decimal SwEc10 { get; set; }

    public decimal SwEc15 { get; set; }

    public decimal SwEcUnl { get; set; }

    public decimal FedEc10 { get; set; }

    public decimal FedEc15 { get; set; }

    public decimal FedEcUnl { get; set; }

    public decimal CvlEc10 { get; set; }

    public decimal CvlEc15 { get; set; }

    public decimal CvlEcUnl { get; set; }

    public decimal OthEc10 { get; set; }

    public decimal OthEc15 { get; set; }

    public decimal OthEcUnl { get; set; }

    public int Id { get; set; }
}
