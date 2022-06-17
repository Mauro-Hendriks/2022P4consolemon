using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{

    class Skill
    {
        string moveName = "thunder bolt";
        int damage = 2;
        int EnergyCost = 30;
        Elementen element;

        
        internal void UseOn(ConsoleMon caster, ConsoleMon target)
        {
            caster.DepleteEnergy(EnergyCost);
            target.TakeDamage(damage);
        }
        internal Skill()
        {

        }

        internal Skill(Skill copyFrom)
        {
           
            this.damage = copyFrom.damage;
            this.EnergyCost = copyFrom.EnergyCost;
            this.moveName = copyFrom.moveName;

           
        }
    }
}
