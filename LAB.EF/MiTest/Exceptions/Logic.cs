using Lab.EF.Data;
using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiTest.Exceptions
{
    public class Logic
    {

        public static void TestAddCategory(int categoryID, string categoryName, string categoryDescription)
        {
            try
            {
                CategoriesLogic categoriesLogic = new CategoriesLogic();

                if (!categoriesLogic.CategoryExists(categoryID))
                {
                    categoriesLogic.Add(new Categories
                    {
                        CategoryID = categoryID,
                        CategoryName = categoryName,
                        Description = categoryDescription
                    });

                    Console.WriteLine("Categoria agregada con exito.");
                }
                else
                {
                    Console.WriteLine("La categoría con esta ID ya existe en la base de datos.");
                }

            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error: Operacion no valida - {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error inesperado - {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Finalmente paso");
            }
        }
    }
}
