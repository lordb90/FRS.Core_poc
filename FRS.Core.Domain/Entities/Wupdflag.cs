using System;
using System.Collections.Generic;

namespace FRS.Core.Domain.Entities;

public partial class Wupdflag
{
    public bool Webinfo { get; set; }

    public DateTime WiNeeded { get; set; }

    public DateTime WiUpdated { get; set; }

    public string WiUser { get; set; } = null!;

    public bool Webost { get; set; }

    public DateTime WoNeeded { get; set; }

    public DateTime WoUpdated { get; set; }

    public string WoUser { get; set; } = null!;

    public bool WebPkg { get; set; }

    public DateTime WpNeeded { get; set; }

    public DateTime WpUpdated { get; set; }

    public string WpUser { get; set; } = null!;

    public bool Ccdriver { get; set; }

    public DateTime CcNeeded { get; set; }

    public DateTime CcUpdated { get; set; }

    public string CcUser { get; set; } = null!;

    public bool Webhelp { get; set; }

    public DateTime WhNeeded { get; set; }

    public DateTime WhUpdated { get; set; }

    public string WhUser { get; set; } = null!;

    public bool Webcounty { get; set; }

    public DateTime WcNeeded { get; set; }

    public DateTime WcUpdated { get; set; }

    public string WcUser { get; set; } = null!;

    public bool CcardTran { get; set; }

    public DateTime CtNeeded { get; set; }

    public DateTime CtUpdated { get; set; }

    public string CtUser { get; set; } = null!;

    public int Id { get; set; }
}
