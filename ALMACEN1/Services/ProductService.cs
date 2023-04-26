using DatabaseProject.Models;
using Interface;

namespace Services
{
    public class ProductService : ProductServiceInterface
    {
        AlmacenDbContext almacenDbContext;
        StockService stockService;

        public ProductService()
        {
            this.almacenDbContext = new AlmacenDbContext();
            this.stockService = new StockService();
        }

        public bool Add(Product product)
        {
            try
            {
                
                almacenDbContext.Products.Add(product);
                almacenDbContext.SaveChanges();
                Product lastProduct = almacenDbContext.Products.LastOrDefault(null, null);
                int lastId = lastProduct == null ? 0 : lastProduct.Id;
                Product productAdded = almacenDbContext.Products.ToList().Find(productDb =>   productDb.Id == lastId + 1);  
                return productAdded != null ? true : false;
            }
            catch (Exception ex)
            {
                return false;
            }


        }

        public bool Delete(int id)
        {
            Product product = almacenDbContext.Products.FirstOrDefault((product) => product.Id == id);
            almacenDbContext.Products.Remove(product);
            almacenDbContext.SaveChanges();
            Product productRemoved = almacenDbContext.Products.FirstOrDefault((product) => product.Id == id);
            return productRemoved == null;
        }

        public List<Product> GetAll()
        {
            return almacenDbContext.Products.ToList();
        }

        public Product GetById(int id)
        {
            return almacenDbContext.Products.ToList().Find((product) => product.Id == id);
        }

        public bool Update(Product product,int oldCode)
        {
            try
            {
                
                if (oldCode != product.Code)
                {
                    stockService.Add(product.Code);
                    stockService.ReduceAmount(oldCode);
                }
                almacenDbContext.Products.Update(product);
                almacenDbContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}