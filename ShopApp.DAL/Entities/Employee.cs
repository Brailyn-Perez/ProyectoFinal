using ShopApp.DAL.Core;
using System;
using System.Collections.Generic;

namespace ShopApp.DAL.Entities;

public partial class Employee : LocationEntity
{
    public int Empid { get; set; }

    public string Lastname { get; set; } = null!;

    public string Firstname { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Titleofcourtesy { get; set; } = null!;

    public DateTime Birthdate { get; set; }

    public DateTime Hiredate { get; set; }

    public int? Mgrid { get; set; }
}
