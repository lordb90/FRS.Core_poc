using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Eclthelp
{
    public string Title { get; set; } = null!;

    public string Content { get; set; } = null!;

    public decimal HelpNbr { get; set; }

    public string Desc { get; set; } = null!;

    public DateTime Lastupdate { get; set; }

    public string Lastuser { get; set; } = null!;

    public int Id { get; set; }
}
