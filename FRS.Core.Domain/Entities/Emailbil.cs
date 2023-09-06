using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Emailbil
{
    public decimal EmailId { get; set; }

    public string PdfName { get; set; } = null!;

    public bool EmSent { get; set; }

    public bool WebPost { get; set; }

    public bool WebSent { get; set; }

    public int Id { get; set; }
}
