using bestallningsportal.Application.Common.Models.Response;
using bestallningsportal.Application.Product.Queries.GetProduct;
using bestallningsportal.Domain.Entities;
using bestallningsportal.Domain.Entities.Product;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace bestallningsportal.Application.Common.Interfaces.Repositories
{
    /// <summary>
    /// Interface that defines what methods will the repository have
    /// </summary>
    public interface IProductRepository
    {
        #region Create
        /// <summary>
        /// This method is used to create a product
        /// </summary>
        /// <param name="application">Command containing properties to create new product</param>
        /// <param name="cancellationToken">To notify the application if the operation need to be canceled</param>
        /// <returns>Return Id of newly created product</returns>
        Task<int> AddProduct(ApplicationProduct application, CancellationToken cancellationToken);
        #endregion

        #region Return
        /// <summary>
        /// This method is used to get products based on supplied filters
        /// </summary>
        /// <param name="request">Contains properties to match with when applying filters</param>
        /// <param name="cancellationToken">To notify the application if the operation need to be canceled</param>
        /// <returns>Returns list of products and count as well</returns>
        Task<List<ApplicationProduct>> GetProducts(GetProducts request, CancellationToken cancellationToken);

        /// <summary>
        /// This method is used fot returning products count
        /// </summary>
        /// <param name="request">Contains properties to match with when applying filters</param>
        /// <param name="cancellationToken">To notify the application if the operation need to be canceled</param>
        /// <returns>Returns products count</returns>
        Task<int> GetProductsCount(GetProducts request, CancellationToken cancellationToken);

        /// <summary>
        /// This method is used to get product based on supplied id
        /// </summary>
        /// <param name="id">Id to match and return product</param>
        /// <param name="cancellationToken">To notify the application if the operation need to be canceled</param>
        /// <returns>Returns a single product object</returns>
        Task<ApplicationProduct> GetProductById(int id, CancellationToken cancellationToken);
        #endregion

        #region Update
        /// <summary>
        /// This method is used to update a product based on supplied product object
        /// </summary>
        /// <param name="product">Contains values to update for a specific</param>
        /// <param name="cancellationToken">To notify the application if the operation need to be canceled</param>
        /// <returns>Returns id of updated product</returns>
        Task<int> UpdateProduct(ProductMaster applicationProduct, CancellationToken cancellationToken);
        #endregion

        #region Delete
        /// <summary>
        /// This method is used to soft delete a product based on supplied id
        /// </summary>
        /// <param name="id">Id to match and soft delete product</param>
        /// <returns>Returns boolean value for deleted product</returns>
        Task<bool> DeleteProduct(int id);
        #endregion
    }
}
