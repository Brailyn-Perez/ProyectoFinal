
using ShopApp.DAL.Entities;
using ShopApp.DAL.Models.Category;

namespace ShopApp.DAL.Interfaces
{
    public interface IDaoCategory
    {
        void CreateCategory(CategoryCreateOrUpdateModel categoryCreate);

        void UpdateCategory(GetCategoryModel categoryUpdate);

        List<GetCategoryModel> GetCategory();

        GetCategoryModel GetCategoriesById(int id);
    }
}
