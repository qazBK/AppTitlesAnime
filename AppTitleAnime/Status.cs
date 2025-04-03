using System;
using System.Collections.Generic;

namespace AppTitleAnime;

public partial class Status
{
    public short Id { get; set; }

    public string StatusAnime { get; set; } = null!;

    public virtual ICollection<TitlesStatus> TitlesStatuses { get; set; } = new List<TitlesStatus>();
}
