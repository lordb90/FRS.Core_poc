using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Frschool
{
    public string School { get; set; } = null!;

    public string Campus { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public string VoicePhn { get; set; } = null!;

    public string FaxNumber { get; set; } = null!;

    public string U { get; set; } = null!;

    public string ClNotes { get; set; } = null!;

    public string Clearhouse { get; set; } = null!;

    public string SchCode { get; set; } = null!;

    public string Address { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string Title { get; set; } = null!;

    public decimal Feescolleg { get; set; }

    public decimal Feesretail { get; set; }

    public DateTime Activation { get; set; }

    public int Id { get; set; }
}
