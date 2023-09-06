using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Specinst
{
    public string RTrace { get; set; } = null!;

    public string SiCounty { get; set; } = null!;

    public string SiState { get; set; } = null!;

    public string Message { get; set; } = null!;

    public string SrchInstr { get; set; } = null!;

    public decimal CourtFee { get; set; }

    public decimal CvlFee { get; set; }

    public decimal FedFee { get; set; }

    public decimal OthFee { get; set; }

    public int Id { get; set; }
}
