using Lab.EF.Data;
using Lab.EF.Entities.DTOs;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab.EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<CategoriesDTO>
    {
        public CategoriesLogic() : base() { }

        public CategoriesDTO GetCategoryID(int id)
        {
            try
            { 
                var eCategory = context.Categories.Find(id);

                if (eCategory != null)
                {
                    CategoriesDTO categoriesDTO = new CategoriesDTO()
                    {
                        CategoryID = eCategory.CategoryID,
                        CategoryName = eCategory.CategoryName,
                        CategoryDescription = eCategory.Description
                    };
                    return categoriesDTO;
                }
                else
                    throw new Exception();
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
        }

        public List<CategoriesDTO> GetAll()
        {
            IEnumerable<Categories> categories = context.Categories.AsEnumerable();
            List<CategoriesDTO> result = categories.Select(c => new CategoriesDTO
            {
                CategoryID = c.CategoryID,
                CategoryName = c.CategoryName,
                CategoryDescription = c.Description
            }).ToList();

            return result;
        }

        public CategoriesDTO Add(CategoriesDTO categoryDTO)
        {
            var newCategory = new Categories
            {
                CategoryID = categoryDTO.CategoryID,
                CategoryName = categoryDTO.CategoryName,
                Description = categoryDTO.CategoryDescription
            };

            context.Categories.Add(newCategory);
            context.SaveChanges();

            return categoryDTO;
        }

        public void Delete(int ID)
        {
            var categoriaAEliminar = context.Categories.SingleOrDefault(c => c.CategoryID == ID);

            if (categoriaAEliminar != null)
            {
                context.Categories.Remove(categoriaAEliminar);
                context.SaveChanges();
            }
        }

        public void Update(CategoriesDTO categoriesDTO)
        {
            var categoryUpdate = context.Categories.Find(categoriesDTO.CategoryID);

            try
            {
                categoryUpdate.CategoryID = categoriesDTO.CategoryID;
                categoryUpdate.CategoryName = categoriesDTO.CategoryName;
                categoryUpdate.Description = categoriesDTO.CategoryDescription;
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool CategoryExists(int categoryID)      // Este método busca dentro de la BD la ID buscada, en este caso, para 'categories'. Luego sirve para que la lógica del test avise si encontró una ID igual o se puede ingresar correctamente la nueva categoría
        {
            using (var dbContext = new NorthwindContext()) 
            {
                return dbContext.Categories.Any(c => c.CategoryID == categoryID);
            }
        }
    }
}
