using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class UsedFile
{
    public string Filename { get; set; } = null!;

    public int Id { get; set; }
}
