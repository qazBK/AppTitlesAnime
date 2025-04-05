using System;
using System.Collections.Generic;

namespace AppTitleAnime.Models;

public partial class Status
{
    public short Id { get; set; }

    public string StatusAnime { get; set; } = null!;


    //Навигация
    public virtual ICollection<TitlesStatus> TitlesStatuses { get; set; } = new List<TitlesStatus>();
}
