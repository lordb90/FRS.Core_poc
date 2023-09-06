using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Tudrcli
{
    public string CompCode { get; set; } = null!;

    public decimal Autoasgndr { get; set; }

    public decimal Createmvr { get; set; }

    public decimal Tdrbillper { get; set; }

    public decimal TdrFee { get; set; }

    public decimal TdraFee { get; set; }

    public string TdrEmail { get; set; } = null!;

    public bool Tdrautogen { get; set; }

    public string Tdremlmsg { get; set; } = null!;

    public DateTime Lastemail { get; set; }

    public int Id { get; set; }
}
