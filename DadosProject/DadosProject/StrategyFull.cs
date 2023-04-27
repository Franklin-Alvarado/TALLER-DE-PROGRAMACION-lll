using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProject
{
    public class StrategyFull : IMano
    {
        public bool Verificar(List<Dado> dados)
        {
            bool have3ocurrences = false, have2ocurrences = false;
            HashSet<Dado> list = new HashSet<Dado>(dados);
            if (list.Count != 2) return false;
            foreach (Dado dado in list)
            {
                int ocurrences = dados.FindAll((dadoP) => dadoP.Value == dado.Value).Count;
                if (ocurrences == 2) have2ocurrences = true;
                if (ocurrences == 3) have3ocurrences = true;
            }

            if (have2ocurrences && have3ocurrences)
            {
                Console.WriteLine("Es full");
                return true;
            }
            return false;
        }
    }
}
