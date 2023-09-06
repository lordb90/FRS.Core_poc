using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Emailatc
{
    public decimal EmailId { get; set; }

    public string Descriptn { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string OrigFname { get; set; } = null!;

    public int Id { get; set; }
}
