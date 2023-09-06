using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Subattch
{
    public decimal Key { get; set; }

    public string Descriptn { get; set; } = null!;

    public string AttachDoc { get; set; } = null!;

    public string Filename { get; set; } = null!;

    public string Location { get; set; } = null!;

    public DateTime Attachdttm { get; set; }

    public string Whoattach { get; set; } = null!;

    public bool Internal { get; set; }

    public bool Post2web { get; set; }

    public DateTime Post2webdt { get; set; }

    public decimal Weborder { get; set; }

    public bool Post2email { get; set; }

    public DateTime Post2emldt { get; set; }

    public decimal EmailId { get; set; }

    public bool Push2web { get; set; }

    public bool DelFile { get; set; }

    public string Zipfile { get; set; } = null!;

    public bool Archived { get; set; }

    public int Id { get; set; }
}
