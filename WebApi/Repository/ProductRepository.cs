using WebApi.Data;
using WebApi.Models;

namespace WebApi.Repository
{
    public class ProductRepository: IProductRepository
    {
        private DataContext _context;

        public ProductRepository(DataContext context)
        {
            _context = context;
        }

        public Product Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public void DeleteProductById(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
            {
                throw new Exception($"{product.Id} not found");
            }
            _context.Products.Remove(product);
            _context.SaveChanges();

        }
        public Product GetProductById(int id)
        {

            return _context.Products.Find(id);
        }

        public List<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        public Product UpdateProduct(Product product)
        {

            _context.Products.Update(product);
            _context.SaveChanges();

            return product;
        }
    }
}
