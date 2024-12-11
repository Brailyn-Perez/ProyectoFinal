
namespace ShopApp.DAL.Core
{
    public abstract class LocationEntity : AudiEntity
    {
        public string Address { get; set; } = null!;

        public string City { get; set; } = null!;

        public string? Region { get; set; }

        public string? Postalcode { get; set; }

        public string Country { get; set; } = null!;

        public string Phone { get; set; } = null!;
    }
}
