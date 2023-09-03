using Lab.EF.Entities;
using Lab.EF.Logic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace Lab.EF.UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void AgregarCategoria()
        {
            CategoriesLogic categoriesLogic = new CategoriesLogic();
            int CategoriaID = 22;

            categoriesLogic.Add(new Categories
            {
                CategoryID = CategoriaID,
                CategoryName = "Nuevo Nombre",
                Description = "Nueva Descripción"
            });

            var categorias = categoriesLogic.GetAll();
            bool categoriaAgregada = categorias.Any(c =>  c.CategoryID == CategoriaID);

            Assert.IsTrue(categoriaAgregada, "La categoría no se agregó correctamente a la base de datos.");
        }
    }
}
