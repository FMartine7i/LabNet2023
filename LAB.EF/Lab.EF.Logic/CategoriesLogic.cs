using Lab.EF.Data;
using Lab.EF.Entities;
using System.Collections.Generic;
using System.Linq;


namespace Lab.EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        public CategoriesLogic(NorthwindContext context) : base(context) 
        { 
        
        }

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

            if (categoryUpdate != null)
            {
                categoryUpdate.CategoryName = categories.CategoryName;
                categoryUpdate.Description = categories.Description;
                context.SaveChanges();
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
