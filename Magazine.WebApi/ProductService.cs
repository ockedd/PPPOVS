using Magazine.Core.Models;
using Magazine.Core.Services;

namespace Magazine.WebApi
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new List<Product>(); // Пример использования списка для хранения продуктов
        private int _nextId = 1;

        public Product Add(Product product)
        {
            product.Id = _nextId++;
            _products.Add(product);
            return product;
        }

        public Product Remove(int id)
        {
            var product = Search(id);
            if (product != null)
            {
                _products.Remove(product);
                return product;
            }
            return null;
        }

        public Product Edit(Product product)
        {
            var existingProduct = Search(product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name; // Предположим, что у продукта есть свойство Name
                existingProduct.Price = product.Price; // Предположим, что у продукта есть свойство Price
                return existingProduct;
            }
            return null;
        }

        public Product Search(int id)
        {
            return _products.Find(p => p.Id == id); // Поиск продукта по ID
        }
    }
}
