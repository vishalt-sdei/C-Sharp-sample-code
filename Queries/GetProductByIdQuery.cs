using bestallningsportal.Application.Common.Interfaces.Services;
using bestallningsportal.Application.Common.Models.Response;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace bestallningsportal.Application.Product.Queries.GetProductById
{
    /// <summary>
    /// Defines a query to retrieve a product by its ID.
    /// </summary>
    public class GetProductByIdQuery: IRequest<ApplicationProduct>
    {
        public int Id { get; set; }
    }
    /// <summary>
    /// Query Handler to intercept and respond to the request made to controller by passing the request to service
    /// </summary>
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ApplicationProduct>
    {
        private readonly IProductService  _productService;

        // Constructor for GetProductByIdQueryHandler
        public GetProductByIdQueryHandler(IProductService productService)
        {
            _productService = productService;
        }

        /// <summary>
        /// Handles the GetProductById query by invoking the product service.
        /// </summary>
        /// <param name="request">The request containing the ID of the product to retrieve.</param>
        /// <param name="cancellationToken">A token to cancel the operation if needed.</param>
        /// <returns>The product retrieved from the product service based on the provided ID.</returns>
        public async Task<ApplicationProduct> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            return await _productService.GetProductById(request.Id, cancellationToken);
        }

    }
}
