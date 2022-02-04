using Microsoft.EntityFrameworkCore;
using Shopping.Core.Models;

namespace Shopping.ProductCatalog.DB
{
    public class ProductCatalogContext :DbContext
    {
        public ProductCatalogContext(DbContextOptions<ProductCatalogContext> options)
            : base(options)
        {

        }
        public DbSet <Product>? Products { get; set; }
    }
}
