
namespace ShopApp.DAL.Models.Category
{
    public class CategoryRemoveModel
    {
        public int Categoryid { get; set; }

        public int? DeleteUser { get; set; }

        public DateTime? DeleteDate { get; set; }

        public bool Deleted { get; set; }
    }
}
