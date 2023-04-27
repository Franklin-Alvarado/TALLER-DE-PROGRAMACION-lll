using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProject
{
    public class StrategyPoker : IMano
    {
        public bool Verificar(List<Dado> dados)
        {
            bool have4ocurrences = false, have1ocurrence = false;
            HashSet<Dado> list = new HashSet<Dado>(dados);
            if (list.Count != 2) return false;
            foreach (Dado dado in list)
            {
                int ocurrences = dados.FindAll((dadoP) => dadoP.Value == dado.Value).Count;
                if (ocurrences == 4) have4ocurrences = true;
                if (ocurrences == 1) have1ocurrence = true;
            }

            if (have4ocurrences && have1ocurrence)
            {
                Console.WriteLine("Es Poker");
                return true;
            }

            return false;
        }
    }
}
