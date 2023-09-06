using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Webccset
{
    public bool Internat { get; set; }

    public bool Canada { get; set; }

    public bool Past7 { get; set; }

    public bool PrSw { get; set; }

    public bool PrCty { get; set; }

    public decimal PrFirst { get; set; }

    public bool PrFed { get; set; }

    public bool FedAll { get; set; }

    public decimal FedFirst { get; set; }

    public decimal VordCrim { get; set; }

    public decimal VordFed { get; set; }

    public decimal VordOst { get; set; }

    public decimal VordInt { get; set; }

    public decimal VordCan { get; set; }

    public decimal VordP7 { get; set; }

    public int Id { get; set; }
}
