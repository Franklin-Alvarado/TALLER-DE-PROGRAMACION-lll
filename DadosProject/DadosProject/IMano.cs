using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProject
{
    public interface IMano
    {
        public bool Verificar(List<Dado> dados);
    }
}
