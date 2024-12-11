using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopApp.DAL.Entities;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Category;

namespace ShopApp.WEB.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IDaoCategory _daoCategory;

        public CategoryController(IDaoCategory daoCategory)
        {
            _daoCategory = daoCategory;
        }

        // GET: CategoryController
        public ActionResult Index()
        {
            var categories = _daoCategory.GetCategory();
            return View(categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var category = _daoCategory.GetCategoriesById(id);
            return View(category);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CategoryCreateOrUpdateModel categoryCreate)
        {
            try
            {
                _daoCategory.CreateCategory(categoryCreate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var categoryById = _daoCategory.GetCategoriesById(id);
            return View(categoryById);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(GetCategoryModel categoryUpdate)
        {
            try
            {
                _daoCategory.UpdateCategory(categoryUpdate);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
