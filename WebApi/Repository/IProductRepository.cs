using WebApi.Models;

namespace WebApi.Repository
{
    public interface IProductRepository
    {
        List<Product> GetProducts();

        Product GetProductById(int id);

        Product Create(Product product);

        void DeleteProductById(int id);

        Product UpdateProduct(Product product);
    }
}
