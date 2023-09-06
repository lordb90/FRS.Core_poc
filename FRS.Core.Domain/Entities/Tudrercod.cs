using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Tudrercod
{
    public string Codenumber { get; set; } = null!;

    public string Codedesc { get; set; } = null!;

    public int Id { get; set; }
}
