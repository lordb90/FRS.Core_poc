using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class FrsupdQ
{
    public decimal Subjectkey { get; set; }

    public string AuditKey { get; set; } = null!;

    public bool Synced { get; set; }

    public string Action { get; set; } = null!;

    public string CompCode { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string TimeEnter { get; set; } = null!;

    public string DateEnter { get; set; } = null!;

    public string Timezone { get; set; } = null!;

    public string Codedata { get; set; } = null!;

    public string CompDate { get; set; } = null!;

    public int Id { get; set; }
}
