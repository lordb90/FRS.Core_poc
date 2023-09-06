using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Lxreqbtc
{
    public DateTime Datetime { get; set; }

    public string Batchid { get; set; } = null!;

    public string Acctcode { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string DSiteid { get; set; } = null!;

    public string SSiteid { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public decimal TotRecs { get; set; }

    public string Subjects { get; set; } = null!;

    public decimal EmailId { get; set; }

    public int Id { get; set; }
}
