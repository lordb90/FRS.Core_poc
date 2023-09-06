using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Wrgready
{
    public decimal Key { get; set; }

    public decimal RrType { get; set; }

    public decimal Whichres { get; set; }

    public bool PrExec { get; set; }

    public bool PrCrim { get; set; }

    public bool PrCred { get; set; }

    public bool PrSsn { get; set; }

    public bool PrDmv { get; set; }

    public bool PrWcmp { get; set; }

    public bool PrEduc { get; set; }

    public bool PrEmpl { get; set; }

    public bool PrPlic { get; set; }

    public bool PrMlos { get; set; }

    public bool PrDisc { get; set; }

    public bool PrSuppl { get; set; }

    public bool GenDaily { get; set; }

    public DateTime WrgDate { get; set; }

    public string WrgTime { get; set; } = null!;

    public decimal EmailId { get; set; }

    public string LinxmlId { get; set; } = null!;

    public bool Lpbackup { get; set; }

    public decimal BkupTries { get; set; }

    public string Lockbyuser { get; set; } = null!;

    public DateTime Lockdate { get; set; }

    public int Id { get; set; }
}
