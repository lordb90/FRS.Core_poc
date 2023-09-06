using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Trakfield
{
    public bool Excluded { get; set; }

    public string TableName { get; set; } = null!;

    public string FieldName { get; set; } = null!;

    public string FieldType { get; set; } = null!;

    public decimal FieldLen { get; set; }

    public decimal FieldDec { get; set; }

    public string Descript { get; set; } = null!;

    public string Settngtype { get; set; } = null!;

    public string FormName { get; set; } = null!;

    public string FormName2 { get; set; } = null!;

    public string FormName3 { get; set; } = null!;

    public string CntlName { get; set; } = null!;

    public string TabNum { get; set; } = null!;

    public bool AdminOnly { get; set; }

    public bool Firstelem0 { get; set; }

    public bool Override { get; set; }

    public string Subrecord { get; set; } = null!;

    public int Id { get; set; }
}
