using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DadosProject
{
    public class ManoContext
    {
        private IMano mano;

        public enum Manos
        {
            Full, Poker, Escalera
        }

        public ManoContext()
        {
            this.mano = new StrategyFull();
        }

        public bool Verificar(Manos manos, List<Dado> dados)
        {
            switch (manos)
            {
                case Manos.Full:
                    this.mano = new StrategyFull();
                     break;
                case Manos.Poker:
                    this.mano = new StrategyPoker();
                    break;
                case Manos.Escalera:
                    this.mano = new StrategyEscalera();
                    break;
                default:
                    break;
            }

            return this.mano.Verificar(dados);

        }
    }
}
