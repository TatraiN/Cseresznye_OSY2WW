﻿using System;
using System.Collections.Generic;

namespace Cseresznye_OSY2WW.BookModels;

public partial class ShortQuote
{
    public int QuoteId { get; set; }

    public string Quote { get; set; } = null!;

    public string Author { get; set; } = null!;

    public string Category { get; set; } = null!;

    public bool IsFamous { get; set; }

    public int? Year { get; set; }
}
