using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BuilderPattern.Agregado;

namespace BuilderPattern
{
    public class PizzaItalianaBuilder : PizzaBuilder
    {

        public PizzaItalianaBuilder()
        {
            _descripcion = "Pizza italiana";
        }
        public override Agregado BuildAgregado()
        {
            return new Anchoas();
        }

        public override Salsa BuildSalsa()
        {
            return new Oliva();
        }

        public override Masa BuilMasa()
        {
            return new AlaPiedra();
        }
    }
}
