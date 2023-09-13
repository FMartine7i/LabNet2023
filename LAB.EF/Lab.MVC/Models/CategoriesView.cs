using System.ComponentModel.DataAnnotations;

namespace Lab.MVC.Models
{
    public class CategoriesView
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar un nombre.")]
        [MaxLength(100)]
        [MinLength(3)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Debe ingresar una descripcion.")]
        [MaxLength (200)]
        [MinLength(5)]
        public string Description { get; set; }
    }
}