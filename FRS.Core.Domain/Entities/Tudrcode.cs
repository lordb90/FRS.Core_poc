using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Tudrcode
{
    public bool Newlicense { get; set; }

    public bool Testing { get; set; }

    public bool Majoronly { get; set; }

    public string Licensekey { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string Bureau { get; set; } = null!;

    public string SubBureau { get; set; } = null!;

    public string Industry { get; set; } = null!;

    public string SubCode { get; set; } = null!;

    public string ProdCode { get; set; } = null!;

    public string Siteshort { get; set; } = null!;

    public string Passwrd { get; set; } = null!;

    public string Userrefnum { get; set; } = null!;

    public int Id { get; set; }
}
