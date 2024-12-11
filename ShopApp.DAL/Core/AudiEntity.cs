
namespace ShopApp.DAL.Core
{
    public abstract class AudiEntity
    {
        protected AudiEntity()
        {
            CreationDate = DateTime.Now;
            Deleted = false;
            CreationUser = 1;

        }

        public DateTime CreationDate { get; set; }

        public int CreationUser { get; set; }

        public DateTime? ModifyDate { get; set; }

        public int? ModifyUser { get; set; }

        public int? DeleteUser { get; set; }

        public DateTime? DeleteDate { get; set; }

        public bool Deleted { get; set; }
    }
}
