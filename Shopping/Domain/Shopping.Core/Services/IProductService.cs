using Shopping.Core.Models;

namespace Shopping.Core.Services
{
    public interface IProductService
    {
        Task<Product> AddProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductsById(int id);
    }
}
