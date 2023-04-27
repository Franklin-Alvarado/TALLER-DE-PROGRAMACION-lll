using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class BorrachoStrategyContext
    {
        private IBorracho oBorracho;

        public enum Comportamiento
        {
            HacerOjitos, InvitarCerveza, HacerDeGalan
        }
        public BorrachoStrategyContext()
        {
            this.oBorracho = new StrategyOjitos();
        }

        public void Conquistar(Comportamiento comportamiento)
        {
            switch (comportamiento)
            {
                case Comportamiento.HacerOjitos:
                    this.oBorracho = new StrategyOjitos();
                    break;
                case Comportamiento.InvitarCerveza:
                    this.oBorracho = new StrategyInvitarCerveza();
                    break;
                case Comportamiento.HacerDeGalan:
                    this.oBorracho = new StrategyHacerDeGalan();
                    break;
                default:
                    break;
            }
            this.oBorracho.Conquistar();
        }
    }
}
