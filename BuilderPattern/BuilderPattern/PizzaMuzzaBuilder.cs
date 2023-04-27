using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BuilderPattern.Agregado;

namespace BuilderPattern
{
    public class PizzaMuzzaBuilder : PizzaBuilder
    {
        public PizzaMuzzaBuilder()
        {
            _descripcion = "Pizza de Muzzarela";
        }
        public override Agregado BuildAgregado()
        {
            return new Oregano();
        }

        public override Salsa BuildSalsa()
        {
            return new Tomate();
        }

        public override Masa BuilMasa()
        {
            return new AlMolde();
        }
    }
}
