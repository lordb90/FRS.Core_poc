using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class ConRecv
{
    public string Filename { get; set; } = null!;

    public string FcId { get; set; } = null!;

    public DateTime RecvDate { get; set; }

    public string RecvTime { get; set; } = null!;

    public bool Processed { get; set; }

    public decimal NumReqIn { get; set; }

    public decimal NumResIn { get; set; }

    public DateTime LoadDate { get; set; }

    public string LoadTime { get; set; } = null!;

    public string LoadId { get; set; } = null!;

    public string Other { get; set; } = null!;

    public bool ViewErr { get; set; }

    public bool EmailSent { get; set; }

    public string EmailAddr { get; set; } = null!;

    public bool EmailFrs { get; set; }

    public bool EmailCli { get; set; }

    public bool EmailErr { get; set; }

    public DateTime EmailDate { get; set; }

    public string EmailTime { get; set; } = null!;

    public string EmailPnt { get; set; } = null!;

    public int Id { get; set; }
}
