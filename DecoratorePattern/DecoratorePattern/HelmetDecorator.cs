using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorePattern
{
    public class HelmetDecorator : EnemyDecorator
    {
        public HelmetDecorator(Enemy enemy) : base(enemy)
        {
        }

        public override double TakeDamage()
        {
            return this.enemy.TakeDamage() / 2;
        }
    }
}
