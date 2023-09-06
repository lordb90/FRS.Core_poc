using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class TudrTag
{
    public string Tagname { get; set; } = null!;

    public string Tagdesc { get; set; } = null!;

    public bool Tagdisplay { get; set; }

    public int Id { get; set; }
}
