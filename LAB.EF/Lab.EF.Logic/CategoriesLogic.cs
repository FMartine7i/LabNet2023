using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;


namespace Lab.EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Add(Categories newCategory)
        {
            context.Categories.Add(newCategory);

            context.SaveChanges();
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

        public void Update(Categories categories)
        {
            var categoryUpdate = context.Categories.Find(categories.CategoryID);

            categoryUpdate.Description = categories.Description;

            context.SaveChanges();
        }

        public bool CategoryExists(int categoryID)
        {
            using (var dbContext = new NorthwindContext()) 
            {
                return dbContext.Categories.Any(c => c.CategoryID == categoryID);
            }
        }
    }
}
