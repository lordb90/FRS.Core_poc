using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Wmstrgrp
{
    public string Mstrgroup { get; set; } = null!;

    public string Desc { get; set; } = null!;

    public string Password { get; set; } = null!;

    public decimal Grpmembers { get; set; }

    public decimal Indmembers { get; set; }

    public bool PrefAdver { get; set; }

    public bool PrefBill { get; set; }

    public bool PrefRpts { get; set; }

    public bool PrefAccts { get; set; }

    public bool PrefMask { get; set; }

    public bool PrefNotes { get; set; }

    public bool PrefInter { get; set; }

    public string Emailaddr { get; set; } = null!;

    public bool PrefCdate { get; set; }

    public bool PrefPrevw { get; set; }

    public bool PrefWord { get; set; }

    public bool PrefStrpw { get; set; }

    public string Typpwcrypt { get; set; } = null!;

    public bool AllowReqs { get; set; }

    public bool ApGrading { get; set; }

    public bool ViewPf { get; set; }

    public bool ChangePf { get; set; }

    public bool Useblueorg { get; set; }

    public bool PrefAself { get; set; }

    public bool PrefAfail { get; set; }

    public bool PrefEmlrs { get; set; }

    public bool PrefMovrs { get; set; }

    public bool PrefDelrs { get; set; }

    public bool PrefDsprs { get; set; }

    public bool PrefTrnhr { get; set; }

    public string Requestor { get; set; } = null!;

    public bool PrefI9 { get; set; }

    public bool PrefEvp { get; set; }

    public bool PrefSuper { get; set; }

    public string I9compId { get; set; } = null!;

    public bool PrefHtml { get; set; }

    public bool BpaGen { get; set; }

    public string Welcomemsg { get; set; } = null!;

    public bool PrevTscrn { get; set; }

    public bool PrevVtsal { get; set; }

    public string MstrPhone { get; set; } = null!;

    public bool PrefMfa { get; set; }

    public int Id { get; set; }
}
