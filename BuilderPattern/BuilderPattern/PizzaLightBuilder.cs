using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BuilderPattern.Agregado;

namespace BuilderPattern
{
    public class PizzaLightBuilder : PizzaBuilder
    {
        public PizzaLightBuilder()
        {
            _descripcion = "Pizza Light";
        }
        public override Agregado BuildAgregado()
        {
            return new Berenjenas();
        }

        public override Salsa BuildSalsa()
        {
            return new Light();
        }

        public override Masa BuilMasa()
        {
            return new Integral();
        }
    }
}
