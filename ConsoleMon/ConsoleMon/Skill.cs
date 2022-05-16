using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{

    class Skill
    {
        string name = "thunder bolt";
        int damage = 2;
        int EnergyCost = 30;

        List<string> skills = new List<string>();
        internal void UseOn(ConsoleMon caster, ConsoleMon target)
        {
            caster.DepleteEnergy(EnergyCost);
            target.TakeDamage(damage);
        }
    }
}
