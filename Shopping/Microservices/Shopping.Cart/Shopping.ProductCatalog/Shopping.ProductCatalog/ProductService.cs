using Shopping.Core.Models;
using Shopping.Core.Repositories;
using Shopping.Core.Services;

namespace Shopping.ProductCatalog
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public Task<Product> AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetProductsById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
