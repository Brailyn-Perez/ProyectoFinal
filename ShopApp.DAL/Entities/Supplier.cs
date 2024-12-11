using ShopApp.DAL.Core;
namespace ShopApp.DAL.Entities;

public partial class Supplier : LocationEntity
{
    public int Supplierid { get; set; }

    public string Companyname { get; set; } = null!;

    public string Contactname { get; set; } = null!;

    public string Contacttitle { get; set; } = null!;

    public string? Fax { get; set; }
}
