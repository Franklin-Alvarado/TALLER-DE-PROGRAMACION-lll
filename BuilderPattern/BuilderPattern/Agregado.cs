using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class Agregado
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }

        public class Oregano : Agregado
        {
            public Oregano()
            {
                _descripcion = "Oregano fresco";
            }
        }

        public class Anchoas : Agregado
        {
            public Anchoas()
            {
                _descripcion = "Anchoas en aceite";
            }
        }

        public class Berenjenas : Agregado
        {
            public Berenjenas()
            {
                _descripcion = "Berenjenas sin calorias";
            }
        }
    }
}
