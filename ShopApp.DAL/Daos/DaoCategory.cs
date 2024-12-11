
using Microsoft.Extensions.Logging;
using ShopApp.DAL.Context;
using ShopApp.DAL.Entities;
using ShopApp.DAL.Exceptions;
using ShopApp.DAL.Interfaces;
using ShopApp.DAL.Models.Category;
using System.Net.Http.Headers;

namespace ShopApp.DAL.Daos
{
    public class DaoCategory : IDaoCategory
    {
        private readonly ILogger _logger;
        private readonly ApplicationDbContext _context;

        public DaoCategory(ILogger<DaoCategory> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void CreateCategory(CategoryCreateOrUpdateModel categoryCreate)
        {
            try
            {
                if (categoryCreate is null)
                {
                    throw new DaoCategoryException("No puedes mandar el objeto nulo");
                }
                if (string.IsNullOrEmpty(categoryCreate.Categoryname)||string.IsNullOrWhiteSpace(categoryCreate.Categoryname) || categoryCreate.Categoryname.Length>15)
                {
                    throw new DaoCategoryException("No puedes enviar datos vacios ni superiores a 15");
                }
                if (string.IsNullOrEmpty(categoryCreate.Description) || string.IsNullOrWhiteSpace(categoryCreate.Description) || categoryCreate.Description.Length > 200)
                {
                    throw new DaoCategoryException("No puedes enviar una descripcion vacia ni superiores a 200");
                }

                Category category = new Category()
                {
                   Categoryid = categoryCreate.Categoryid,
                   Categoryname = categoryCreate.Categoryname,
                   Description = categoryCreate.Description,
                };

                _context.Categories.Add(category);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError("Ocurrio un error creando la categoria",ex.ToString());
            }
        }

        public GetCategoryModel GetCategoriesById(int id)
        {
            GetCategoryModel getCategoryModel = new GetCategoryModel();
            try
            {
                var category = _context.Categories.Find(id);

                if (category is null)
                {
                    throw new DaoCategoryException("No puedes mandar el objeto nulo");
                }

                getCategoryModel.Categoryid = category.Categoryid;
                getCategoryModel.Categoryname = category.Categoryname;
                getCategoryModel.Description = category.Description;
                getCategoryModel.CreationDate = category.CreationDate;
                getCategoryModel.CreationUser = category.CreationUser;


            }
            catch (Exception ex)
            {
                _logger.LogError("Error Obtiendo la categoria por id",ex.ToString());
            }

            return getCategoryModel;

            
        }

        public List<GetCategoryModel> GetCategory()
        {
            List<GetCategoryModel> category = new List<GetCategoryModel>();
            try
            {
                category = (from categorydtos in _context.Categories
                            where categorydtos.Deleted == false
                            orderby categorydtos.CreationDate descending
                            select new GetCategoryModel()
                            {
                                Categoryid = categorydtos.Categoryid,
                                Categoryname = categorydtos.Categoryname,
                                Description = categorydtos.Description,
                                CreationDate = categorydtos.CreationDate,
                            }).ToList();
            }
            catch (Exception ex)
            {
                _logger.LogError("Error al optener la lista de categorias",ex.ToString());
            }
            return category;
        }

        public void UpdateCategory(GetCategoryModel categoryUpdate)
        {
            try
            {
                if (categoryUpdate is null)
                {
                    throw new DaoCategoryException("No puedes mandar el objeto nulo");
                }
                if (string.IsNullOrEmpty(categoryUpdate.Categoryname) || string.IsNullOrWhiteSpace(categoryUpdate.Categoryname) || categoryUpdate.Categoryname.Length > 15)
                {
                    throw new DaoCategoryException("No puedes enviar datos vacios ni superiores a 15");
                }
                if (string.IsNullOrEmpty(categoryUpdate.Description) || string.IsNullOrWhiteSpace(categoryUpdate.Description) || categoryUpdate.Description.Length > 200)
                {
                    throw new DaoCategoryException("No puedes enviar una descripcion vacia ni superiores a 200");
                }
                Category category = new Category()
                {
                    Categoryid = categoryUpdate.Categoryid,
                    Categoryname = categoryUpdate.Categoryname,
                    Description = categoryUpdate.Description,
                    ModifyDate = DateTime.Now,
                    ModifyUser = 1
                };
                _context.Categories.Update(category);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError("Ocurrio un error editando");
            }
            
        }
    }
}
