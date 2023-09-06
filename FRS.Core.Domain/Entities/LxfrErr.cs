﻿using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class LxfrErr
{
    public DateTime Datetime { get; set; }

    public string Batchid { get; set; } = null!;

    public string Acctcode { get; set; } = null!;

    public string Type { get; set; } = null!;

    public string DSiteid { get; set; } = null!;

    public string SSiteid { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public string Errmsg { get; set; } = null!;

    public bool Viewed { get; set; }

    public int Id { get; set; }
}
