using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Olserror
{
    public string Message { get; set; } = null!;

    public string Bureau { get; set; } = null!;

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public DateTime Date { get; set; }

    public string Time { get; set; } = null!;

    public string App { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public bool Viewed { get; set; }

    public int Id { get; set; }
}
