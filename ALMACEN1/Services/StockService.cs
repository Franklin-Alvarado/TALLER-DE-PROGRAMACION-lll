using DatabaseProject.Models;
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class StockService : StockServiceInterface 
    {
        AlmacenDbContext almacenDbContext;
        public StockService()
        {
            this.almacenDbContext = new AlmacenDbContext();
        }

        public bool Add(int code)
        {
            Stock stockCode = almacenDbContext.Stocks.ToList().Find((stock) => stock.CodeProduct == code);
            if (stockCode == null)
            {
                stockCode = new Stock();
                stockCode.CodeProduct = code;
                stockCode.Amount = 1;
                try
                {
                    almacenDbContext.Stocks.Add(stockCode);
                    almacenDbContext.SaveChanges();
                    return true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);  
                    return false;
                }
            }else
            {
                stockCode.Amount = stockCode.Amount + 1;
                return Update(stockCode);         
                
            }

        }

        public Stock Get(int code)
        {
            return almacenDbContext.Stocks.ToList().Find((stock) => stock.CodeProduct == code);
        }

        public void ReduceAmount(int code)
        {
            Stock stockDB = almacenDbContext.Stocks.FirstOrDefault((stockP) => stockP.CodeProduct == code);
            
            Stock newStock = new Stock();
            newStock.Amount = stockDB.Amount - 1;
            newStock.CodeProduct = code;
            stockDB.Amount = newStock.Amount;
            stockDB.CodeProduct = newStock.CodeProduct;
            almacenDbContext.SaveChanges();
        }
        public bool Update(Stock stock)
        {
            try
            {
                almacenDbContext.Stocks.Update(stock);
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
