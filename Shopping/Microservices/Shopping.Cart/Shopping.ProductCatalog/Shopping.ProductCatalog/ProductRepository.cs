using Shopping.Core.Models;
using Shopping.Core.Repositories;
using Shopping.ProductCatalog.DB;

namespace Shopping.ProductCatalog
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductCatalogContext _dbContext;
        public ProductRepository(ProductCatalogContext dbContext)
        {
            _dbContext = dbContext;
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
