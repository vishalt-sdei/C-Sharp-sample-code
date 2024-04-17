using System.Collections.Generic;

namespace bestallningsportal.Application.Common.Models.Response.Product
{
    /// <summary>
    /// Paginated Products Class
    /// </summary>
    public class PaginatedProducts
    {
        // Paginated Products Constructor
        public PaginatedProducts()
        {
            ProductsList = new List<ApplicationProduct>();
        }
        public int TotalCount { get; set; }
        public List<ApplicationProduct> ProductsList { get; set; }
    }
}
