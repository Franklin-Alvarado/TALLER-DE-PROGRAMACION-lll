using System;
using System.Collections.Generic;

namespace DatabaseProject.Models;

public partial class Stock
{
    public int Id { get; set; }

    public int Amount { get; set; }

    public int CodeProduct { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();

    public override string ToString()
    {
        return "Stock: " + Amount;
    }
}
