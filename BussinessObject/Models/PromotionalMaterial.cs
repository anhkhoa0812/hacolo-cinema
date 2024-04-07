using System;
using System.Collections.Generic;

namespace BussinessObject.Models;

public partial class PromotionalMaterial
{
    public int MaterialId { get; set; }

    public int? MovieId { get; set; }

    public string? FilePath { get; set; }

    public string? Type { get; set; }
}
