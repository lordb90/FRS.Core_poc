using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Drugpkg
{
    public decimal Key { get; set; }

    public decimal PkgKey { get; set; }

    public decimal Disporder { get; set; }

    public string Pkgdescrpt { get; set; } = null!;

    public string Pkgname { get; set; } = null!;

    public string Spectype { get; set; } = null!;

    public string Category { get; set; } = null!;

    public string Prodclass { get; set; } = null!;

    public string Reasontest { get; set; } = null!;

    public string Regulation { get; set; } = null!;

    public string Regtype { get; set; } = null!;

    public string Codevalue { get; set; } = null!;

    public bool Selectdpkg { get; set; }

    public string SiteId { get; set; } = null!;

    public string Action { get; set; } = null!;

    public bool Inactive { get; set; }

    public decimal VerNum { get; set; }

    public int Id { get; set; }
}
