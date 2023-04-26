using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseProject.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int IdType { get; set; }

    public string Origin { get; set; } = null!;

    public string BrandModel { get; set; } = null!;

    public decimal Price { get; set; }

    public int Code { get; set; }

    public string Description { get; set; } = null!;

    public virtual Stock CodeNavigation { get; set; } = null!;

    public virtual Type IdTypeNavigation { get; set; } = null!;

    public override string ToString()
    {
        StringBuilder productToString = new StringBuilder();
        productToString.AppendLine("Product " + Id );
        productToString.AppendLine("Name: " + Name + ",");
        productToString.AppendLine("Description: " + Description + ",");
        productToString.AppendLine("Code: " + Code + ",");
        productToString.AppendLine("Price: " + Price + ",");
        productToString.AppendLine("BrandModel: " + BrandModel + ",");
        productToString.AppendLine("Origin: " + Origin + "");
        return productToString.ToString();
    }
}
