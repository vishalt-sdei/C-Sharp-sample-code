namespace bestallningsportal.DTO.Request.Product
{
    /// <summary>
    /// Product Filters DTO Class
    /// </summary>
    public class ProductFiltersDTO
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public decimal? FromPrice { get; set; }
        public decimal? ToPrice { get; set; }
        public string Plu { get; set; }
        public int? ProductCategory { get; set; }
        public int? ProductType { get; set; }
        public bool ForSupplierOnly { get; set; } = false;
        public bool? OnlyPluProd { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsRepresentation { get; set; }
        public int? PageNo { get; set; }
        public int? PageSize { get; set; }
    }
}
