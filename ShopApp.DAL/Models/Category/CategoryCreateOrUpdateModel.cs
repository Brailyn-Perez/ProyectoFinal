
namespace ShopApp.DAL.Models.Category
{
    public class CategoryCreateOrUpdateModel
    {
        public int Categoryid { get; set; }

        public string Categoryname { get; set; } = null!;

        public string Description { get; set; } = null!;
    }
}
