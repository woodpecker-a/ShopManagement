using Infrastructure.BusinessObjects;

namespace Infrastructure.Services
{
    public interface IProductService
    {
        void CreateProduct(Product product);
        Product GetProduct(int id);
        IList<Product> GetAllProducts();
        void EditProduct(Product product);
        void RemoveProduct(int id);
    }
}