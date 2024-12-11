
namespace ShopApp.DAL.Models.Category
{
    public class GetCategoryModel
    {
        public int Categoryid { get; set; }

        public string Categoryname { get; set; } = null!;

        public string Description { get; set; } = null!;

        public DateTime CreationDate { get; set; }

        public int CreationUser { get; set; }
    }
}
