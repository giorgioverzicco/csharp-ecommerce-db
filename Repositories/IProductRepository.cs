using csharp_ecommerce_db.Models;

namespace csharp_ecommerce_db.Repositories;

public interface IProductRepository
{
    IEnumerable<Product> GetProducts();
    Product GetProductById(int productId);
    void CreateProduct(Product product);
    void UpdateProduct(Product product);
    void DeleteProduct(int productId);
}