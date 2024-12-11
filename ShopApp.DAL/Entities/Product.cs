using ShopApp.DAL.Core;
using System;
using System.Collections.Generic;

namespace ShopApp.DAL.Entities;

public partial class Product : AudiEntity
{
    public int Productid { get; set; }

    public string Productname { get; set; } = null!;

    public int Supplierid { get; set; }

    public int Categoryid { get; set; }

    public decimal Unitprice { get; set; }

    public bool Discontinued { get; set; }
}
