using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProject
{
    public class StrategyEscalera : IMano
    {
        public bool Verificar(List<Dado> dados)
        {
            bool isEscalera = true;
            dados.Sort();
            HashSet<Dado> list = new HashSet<Dado>(dados);
            if (list.Count != dados.Count) return false;
            int valuePrev = dados[0].Value;
            for(int i = 1; i < dados.Count; i++)
            {
                if (valuePrev - 1 != dados[i].Value)
                {
                    isEscalera = false;
                    break;
                }
                valuePrev = dados[i].Value;
            }
            if (isEscalera) Console.WriteLine("Es escalera");
            return isEscalera;
            
        }
    }
}
