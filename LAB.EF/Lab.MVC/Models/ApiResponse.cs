using System.Collections.Generic;

namespace Lab.MVC.Models
{
    public class ApiResponse<T>
    {
        public List<T> Results { get; set; }
    }
}