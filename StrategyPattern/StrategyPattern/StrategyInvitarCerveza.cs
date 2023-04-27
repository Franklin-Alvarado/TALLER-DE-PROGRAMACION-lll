using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class StrategyInvitarCerveza : IBorracho
    {
        public void Conquistar()
        {
            Console.WriteLine("Le invita una cerveza a la muchacha");
        }
    }
}
