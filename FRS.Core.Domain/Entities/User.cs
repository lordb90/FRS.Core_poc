using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class User
{
    public string Fullname { get; set; } = null!;

    public string Userid { get; set; } = null!;

    public string Initials { get; set; } = null!;

    public bool HiSec { get; set; }

    public DateTime DateAdd { get; set; }

    public bool ConNotify { get; set; }

    public string History { get; set; } = null!;

    public string Userprefs { get; set; } = null!;

    public string AddedBy { get; set; } = null!;

    public string UResCode { get; set; } = null!;

    public bool AFrsusers { get; set; }

    public bool ABilling { get; set; }

    public bool AMreports { get; set; }

    public bool AExprtcli { get; set; }

    public bool Nuclear { get; set; }

    public DateTime Reminddate { get; set; }

    public string Filtname1 { get; set; } = null!;

    public string Filtname2 { get; set; } = null!;

    public string Filtname3 { get; set; } = null!;

    public string Filtname4 { get; set; } = null!;

    public string Filtname5 { get; set; } = null!;

    public string Filtname6 { get; set; } = null!;

    public string Filtname7 { get; set; } = null!;

    public string Filtname8 { get; set; } = null!;

    public string Filtname9 { get; set; } = null!;

    public string Filtname10 { get; set; } = null!;

    public string Filtname11 { get; set; } = null!;

    public string Filtname12 { get; set; } = null!;

    public string Filtname13 { get; set; } = null!;

    public string Filtname14 { get; set; } = null!;

    public string Filtname15 { get; set; } = null!;

    public string Filtname16 { get; set; } = null!;

    public string Filtname17 { get; set; } = null!;

    public string Filtname18 { get; set; } = null!;

    public string Filtname19 { get; set; } = null!;

    public string Filtname20 { get; set; } = null!;

    public string Filter1 { get; set; } = null!;

    public string Filter2 { get; set; } = null!;

    public string Filter3 { get; set; } = null!;

    public string Filter4 { get; set; } = null!;

    public string Filter5 { get; set; } = null!;

    public string Filter6 { get; set; } = null!;

    public string Filter7 { get; set; } = null!;

    public string Filter8 { get; set; } = null!;

    public string Filter9 { get; set; } = null!;

    public string Filter10 { get; set; } = null!;

    public string Filter11 { get; set; } = null!;

    public string Filter12 { get; set; } = null!;

    public string Filter13 { get; set; } = null!;

    public string Filter14 { get; set; } = null!;

    public string Filter15 { get; set; } = null!;

    public string Filter16 { get; set; } = null!;

    public string Filter17 { get; set; } = null!;

    public string Filter18 { get; set; } = null!;

    public string Filter19 { get; set; } = null!;

    public string Filter20 { get; set; } = null!;

    public bool AWeblogin { get; set; }

    public bool Showcharge { get; set; }

    public bool Setapgrade { get; set; }

    public bool APurge { get; set; }

    public bool RstrctEdt { get; set; }

    public bool Rsvdclient { get; set; }

    public string AcctMgr { get; set; } = null!;

    public bool Processor { get; set; }

    public bool ProcSubjs { get; set; }

    public bool ProcProfs { get; set; }

    public bool ProcIhits { get; set; }

    public bool ProcMngmt { get; set; }

    public string UserEmail { get; set; } = null!;

    public bool Onhold { get; set; }

    public bool Shownew { get; set; }

    public int UserKey { get; set; }

    public string Userpasswd { get; set; } = null!;

    public DateTime Lastpwdt { get; set; }

    public decimal Loginfails { get; set; }

    public bool Affiliate { get; set; }

    public string AffCode { get; set; } = null!;

    public string Afflbltype { get; set; } = null!;

    public string Bocompcode { get; set; } = null!;
}
