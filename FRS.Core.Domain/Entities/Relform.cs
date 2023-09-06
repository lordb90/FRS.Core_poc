using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Relform
{
    public string RelCode { get; set; } = null!;

    public string RelType { get; set; } = null!;

    public string RelState { get; set; } = null!;

    public string RelDesc { get; set; } = null!;

    public string FormDesc { get; set; } = null!;

    public string FormName { get; set; } = null!;

    public bool Push2web { get; set; }

    public bool DelFile { get; set; }

    public bool DelRec { get; set; }

    public string FormFile { get; set; } = null!;

    public string RelCounty { get; set; } = null!;

    public int Id { get; set; }
}
