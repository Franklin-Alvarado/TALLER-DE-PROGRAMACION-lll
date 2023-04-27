using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class BuilderDirector
    {
        

        public Pizza PizzaBuilder(PizzaBuilder pizzaBuilder)
        {
            return pizzaBuilder.BuildPizza(); 
        }


    }
}
