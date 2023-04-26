using DatabaseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ProductServiceInterface
    {
        public bool Add(Product product);
        public bool Update(Product product);
        public Product GetById(int id);
        public List<Product> GetAll();
        public bool Delete(int id);
    }
}
