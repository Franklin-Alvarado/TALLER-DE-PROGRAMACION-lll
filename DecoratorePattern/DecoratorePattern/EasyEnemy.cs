using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorePattern
{
    public class EasyEnemy : Enemy
    {
        // clase concreta del Enemy
        public double TakeDamage()
        {
            return 20;
        }
    }
}
