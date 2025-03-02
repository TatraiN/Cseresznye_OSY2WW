﻿using System;
using System.Collections.Generic;

namespace WinFormsAppColor.BookModels;

public partial class Band
{
    public int BandId { get; set; }

    public string Name { get; set; } = null!;

    public string Genre { get; set; } = null!;

    public int FormationYear { get; set; }

    public bool IsActive { get; set; }

    public string Country { get; set; } = null!;
}
