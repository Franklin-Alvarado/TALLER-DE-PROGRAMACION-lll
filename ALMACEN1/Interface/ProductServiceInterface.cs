using DatabaseProject.Models;

namespace Interface
{
    public interface ProductServiceInterface
    {
        public bool Add(Product product);
        public bool Update(Product product, int oldCode);
        public Product GetById(int id);
        public List<Product> GetAll();
        public bool Delete(int id);
    }
}