using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class Masa
    {
        protected string _descripcion;
        public string Descripcion { get { return _descripcion; } }

    }

    public class AlMolde : Masa
    {
        public AlMolde()
        {
            _descripcion = "Masa al molde";
        }
    }

    public class Integral : Masa
    {
        public Integral()
        {
            _descripcion = "Masa de harina integral";
        }
    }

    public class AlaPiedra : Masa
    {
        public AlaPiedra()
        {
            _descripcion = "Masa a la piedra del horno a leña";
        }
    }
}
