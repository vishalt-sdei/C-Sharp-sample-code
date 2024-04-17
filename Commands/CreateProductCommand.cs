using bestallningsportal.Application.Common.Interfaces.Services;
using bestallningsportal.DTO.Request;
using bestallningsportal.DTO.Request.Product;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace bestallningsportal.Application.Product.Commands.CreateProduct
{
    // Command class for creating a product
    public class CreateProductCommand : IRequest<int>
    {
        // Properties for defining product attributes
        public string Name { get; set; }
        public string Unit { get; set; }
        public decimal Price { get; set; }
        public string Comment { get; set; }
        public int Vat { get; set; }
        public string Plu { get; set; }
        public bool IsPackagable { get; set; }
        public string Description { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductType ProductType { get; set; }
        public bool ForSupplierOnly { get; set; }
        public bool IsActive { get; set; }
        public bool IsRepresentation { get; set; }
        public bool IsAutomaticDeposit { get; set; }
        public int? AutomaticDepositType { get; set; }
        public bool IsPant { get; set; }
        public int AccountNumber { get; set; }
        public int AlcoholType { get; set; }
        public List<ProductListProductDto> ProductListProductsMappings { get; set; }
    }

    /// <summary>
    /// Command Handler to intercept and respond to the request made to controller by passing the request to service
    /// </summary>
    /// <param name="request">
    /// The request containing information about the product to be created.
    /// CreateProductCommand Model is passed with this Handler</param>
    /// <returns>An integer representing the result of the creation operation.</returns>
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IProductService _productService;
        // Constructor for CreateProductCommandHandler
        public CreateProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }
        // Handles the creation of a product
        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            return await _productService.AddProduct(request, cancellationToken);
        }
    }
}
