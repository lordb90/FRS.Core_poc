using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Activity
{
    public string Userid { get; set; } = null!;

    public DateTime DateIn { get; set; }

    public DateTime DateOut { get; set; }

    public string Logoutcode { get; set; } = null!;

    public int Id { get; set; }
}
