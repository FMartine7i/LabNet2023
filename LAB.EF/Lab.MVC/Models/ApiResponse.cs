using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.MVC.Models
{
    public class ApiResponse<T>
    {
        public List<T> Results { get; set; }
    }
}