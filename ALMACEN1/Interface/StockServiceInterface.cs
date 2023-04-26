using DatabaseProject.Models;

namespace Interface
{
    public interface StockServiceInterface
    {
        public bool Add(int code);
        public bool Update(Stock stock);
        public Stock Get(int code);
    }
}
