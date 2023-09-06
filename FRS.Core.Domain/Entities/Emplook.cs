using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Emplook
{
    public string Employer { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string EPhone { get; set; } = null!;

    public string EFax { get; set; } = null!;

    public string Supervisor { get; set; } = null!;

    public string Notes { get; set; } = null!;

    public string Clearhouse { get; set; } = null!;

    public string EmpCode { get; set; } = null!;

    public string Title { get; set; } = null!;

    public int Id { get; set; }
}
