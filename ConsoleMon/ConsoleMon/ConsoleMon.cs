using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class ConsoleMon
    {
        string name = "Pickachu"; 
        int health = 10;
        int energy = 200;

        internal void  TakeDamage()
        {
            int damage = 2;
            int Health = health - damage;
        }

        internal void DepleteEnergy()
        {
            int Energy = 30;
            int bEnergy = energy - Energy;
        }
    }
}
