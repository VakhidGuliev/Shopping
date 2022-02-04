using Microsoft.EntityFrameworkCore;
using Shed.CoreKit.WebApi;
using Shopping.Core.Repositories;
using Shopping.Core.Services;
using Shopping.ProductCatalog;
using Shopping.ProductCatalog.DB;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
builder.Services.AddDbContext<ProductCatalogContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:ProductCatalogDb"]);
});
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<IProductService, ProductService>();
app.UseWebApiEndpoint<IProductService>();


app.Run();
