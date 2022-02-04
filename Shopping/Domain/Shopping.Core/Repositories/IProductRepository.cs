using Shopping.Core.Models;
namespace Shopping.Core.Repositories
{
    public interface IProductRepository
    {
        Task<Product> AddProduct(Product product);
        Task<IEnumerable<Product>> GetAllProducts();
        Task<Product> GetProductsById(int id);
       
    }
}
