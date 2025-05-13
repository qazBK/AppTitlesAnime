using System;
using System.Collections.Generic;

namespace AppTitleAnime.Models_2;

public partial class Studio
{
    public short Id { get; set; }

    public string Studio1 { get; set; } = null!;

    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
