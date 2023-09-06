using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class BillingHistory
{
    public DateTime StartDate { get; set; }

    public DateTime EndDate { get; set; }

    public DateTime InvDate { get; set; }

    public DateTime DueDate { get; set; }

    public decimal NbrClient { get; set; }

    public string BasedOn { get; set; } = null!;

    public string Master { get; set; } = null!;

    public decimal InvCopies { get; set; }

    public decimal BlCopies { get; set; }

    public string QbExport { get; set; } = null!;

    public string UserName { get; set; } = null!;

    public DateTime GenDate { get; set; }

    public string GenTime { get; set; } = null!;

    public string Adtlsetngs { get; set; } = null!;

    public int Id { get; set; }
}
