using ShopApp.DAL.Core;
using System;
using System.Collections.Generic;

namespace ShopApp.DAL.Entities;

public partial class Category : AudiEntity
{
    public int Categoryid { get; set; }

    public string Categoryname { get; set; } = null!;

    public string Description { get; set; } = null!;

}
