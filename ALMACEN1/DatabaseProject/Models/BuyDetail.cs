using System;
using System.Collections.Generic;

namespace DatabaseProject.Models;

public partial class BuyDetail
{
    public int IdBuy { get; set; }

    public int IdProduct { get; set; }

    public decimal PriceUnit { get; set; }

    public virtual Buy IdBuyNavigation { get; set; } = null!;

    public virtual Product IdProductNavigation { get; set; } = null!;
}
