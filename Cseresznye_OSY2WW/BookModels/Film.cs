using System;
using System.Collections.Generic;

namespace Cseresznye_OSY2WW.BookModels;

public partial class Film
{
    public int FilmId { get; set; }

    public string Title { get; set; } = null!;

    public int ReleaseYear { get; set; }

    public string Genre { get; set; } = null!;

    public bool IsAvailable { get; set; }
}
