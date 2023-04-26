using System;
using System.Collections.Generic;

namespace DatabaseProject.Models;

public partial class Buy
{
    public int Id { get; set; }

    public int Date { get; set; }

    public string Supplier { get; set; } = null!;
}
