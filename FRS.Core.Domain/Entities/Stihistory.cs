using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Stihistory
{
    public decimal Key { get; set; }

    public string Site { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Cuserid { get; set; } = null!;

    public DateTime Rdate { get; set; }

    public string Rtime { get; set; } = null!;

    public DateTime Rdatetime { get; set; }

    public int Lapsedtime { get; set; }

    public string State1 { get; set; } = null!;

    public string License1 { get; set; } = null!;

    public string Reqtypeava { get; set; } = null!;

    public string History1 { get; set; } = null!;

    public string Social1 { get; set; } = null!;

    public string Fname1 { get; set; } = null!;

    public string Middle1 { get; set; } = null!;

    public string Lname1 { get; set; } = null!;

    public string Date1 { get; set; } = null!;

    public string Sex1 { get; set; } = null!;

    public string Policy1 { get; set; } = null!;

    public string Cresponse { get; set; } = null!;

    public string Uploaded { get; set; } = null!;

    public bool Processed { get; set; }

    public int Id { get; set; }
}
