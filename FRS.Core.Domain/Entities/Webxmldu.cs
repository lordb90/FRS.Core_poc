using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Webxmldu
{
    public string Fname { get; set; } = null!;

    public string Mname { get; set; } = null!;

    public string Lname { get; set; } = null!;

    public string City { get; set; } = null!;

    public string State { get; set; } = null!;

    public string Zip { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public string CompCode { get; set; } = null!;

    public string PresAddr1 { get; set; } = null!;

    public string Reference { get; set; } = null!;

    public string Requestor { get; set; } = null!;

    public string Ssn { get; set; } = null!;

    public string UnqOrder { get; set; } = null!;

    public string Passedxml { get; set; } = null!;

    public DateTime RecDate { get; set; }

    public int Id { get; set; }
}
