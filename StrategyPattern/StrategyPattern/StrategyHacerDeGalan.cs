using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class StrategyHacerDeGalan : IBorracho
    {
        public void Conquistar()
        {
            Console.WriteLine("Hago de galan para conquistar a la muchacha");
        }
    }
}
