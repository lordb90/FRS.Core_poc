using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class ScrType
{
    public int Sequence { get; set; }

    public string Screentype { get; set; } = null!;

    public int ScreenCnt { get; set; }

    public int Id { get; set; }
}
