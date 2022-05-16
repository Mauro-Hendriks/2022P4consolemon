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
        List<Skill> skills = new List<Skill>();
        internal void  TakeDamage(int damage)
        {
            
            this.health = health - damage;
            
        }

        internal void DepleteEnergy(int energy)
        {
            
            this.energy = this.energy - energy;
        }

        internal void skill()
        {

        }
        

        
    }
}
