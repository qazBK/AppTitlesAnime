using System;
using System.Collections.Generic;

namespace AppTitleAnime.Models_2;

public partial class TitlesGenre
{
    public int Id { get; set; }

    public short IdGenre { get; set; }

    public int IdAnime { get; set; }

    public virtual AnimeTitle IdAnimeNavigation { get; set; } = null!;

    public virtual Genre IdGenreNavigation { get; set; } = null!;
}
