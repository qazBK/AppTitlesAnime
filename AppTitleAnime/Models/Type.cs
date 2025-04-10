namespace AppTitleAnime.Models;

public partial class Type
{
    public short Id { get; set; }

    public string TypeAnime { get; set; } = null!;


    //Навигация
    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
