using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorePattern
{
    public class ArmourDecorator : EnemyDecorator
    {
        // Clase concreta decorador
        public ArmourDecorator(Enemy enemy) : base(enemy)
        {
        }

        public override double TakeDamage()
        {
            return this.enemy.TakeDamage() / 1.5;
        }
    }
}
