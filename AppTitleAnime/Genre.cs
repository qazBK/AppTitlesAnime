using System;
using System.Collections.Generic;

namespace AppTitleAnime;

public partial class Genre
{
    public short Id { get; set; }

    public string GenreAnime { get; set; } = null!;

    public virtual ICollection<TitlesGenre> TitlesGenres { get; set; } = new List<TitlesGenre>();
}
