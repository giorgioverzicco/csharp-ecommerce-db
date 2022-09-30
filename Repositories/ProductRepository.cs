using csharp_ecommerce_db.Models;
using Microsoft.EntityFrameworkCore;

namespace csharp_ecommerce_db.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly ECommerceContext _ctx;

    public ProductRepository(ECommerceContext ctx)
    {
        _ctx = ctx;
    }

    public IEnumerable<Product> GetProducts()
    {
        return _ctx.Products.ToList();
    }

    public Product GetProductById(int productId)
    {
        Product? product = _ctx.Products.Find(productId);
        
        if (product is null)
        {
            throw new InvalidOperationException($"Product #{productId} does not exists.");
        }
        
        return product;
    }

    public void CreateProduct(Product product)
    {
        _ctx.Products.Add(product);
        _ctx.SaveChanges();
    }

    public void UpdateProduct(Product product)
    {
        _ctx.Products.Update(product);
        _ctx.SaveChanges();
    }

    public void DeleteProduct(int productId)
    {
        Product product = GetProductById(productId);
        _ctx.Products.Remove(product);
        _ctx.SaveChanges();
    }
}