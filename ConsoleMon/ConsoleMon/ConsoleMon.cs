using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    class ConsoleMon
    {
        public string name = "Pickachu"; 
        public int health = 10;
        public int energy = 200;
      
         internal void  TakeDamage(int damage)
        {
            
            int Health = health - damage;
        }

        internal void DepleteEnergy(int Energy)
        {
            
            int bEnergy = energy - Energy;
        }
    }
}
