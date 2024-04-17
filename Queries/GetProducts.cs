using bestallningsportal.Application.Common.Interfaces.Services;
using bestallningsportal.Application.Common.Models.Response.Product;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace bestallningsportal.Application.Product.Queries.GetProduct
{
    public class GetProducts: IRequest<PaginatedProducts>
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public string Comment { get; set; }
        public decimal? FromPrice { get; set; }
        public decimal? ToPrice { get; set; }
        public string Plu { get; set; }
        public int? ProductCategory { get; set; }
        public int? ProductType { get; set; }
        public bool ForSupplierOnly { get; set; }
        public bool? IsActive { get; set; }
        public bool? OnlyPluProd { get; set; }
        public bool? IsRepresentation { get; set; }
        //Pagination
        public int? PageNo { get; set; }
        public int? PageSize { get; set; }
    }

    public class GetProductQueryHandler : IRequestHandler<GetProducts, PaginatedProducts>
    {
        private readonly IProductService _productService;

        // Constructor for GetProductQueryHandler
        public GetProductQueryHandler(IProductService productService)
        {
            _productService = productService;
        }
        /// <summary>
        /// Handles the GetProduct query by invoking the product service.
        /// </summary>
        /// <param name="request">The request containing the product details.</param>
        /// <param name="cancellationToken">>A token to cancel the operation if needed.</param>
        /// <returns>The product retrieved from the product service based on the product details provided.</returns>
        public async Task<PaginatedProducts> Handle(GetProducts request, CancellationToken cancellationToken)
        {
            return await _productService.GetProducts(request, cancellationToken);
        }
    }
}
