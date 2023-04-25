using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorePattern
{
    public abstract class EnemyDecorator : Enemy
    {
        protected Enemy enemy;

        public EnemyDecorator(Enemy enemy)
        {
            this.enemy = enemy;
        }
        public abstract double TakeDamage();
    }
}
