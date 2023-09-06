using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Dragndrop
{
    public string Dragroup { get; set; } = null!;

    public string Dragtext { get; set; } = null!;

    public int Id { get; set; }
}
