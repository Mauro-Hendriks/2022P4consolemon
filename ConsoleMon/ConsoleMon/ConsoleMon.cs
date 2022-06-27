using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    public enum Elementen { Fire, Elec, Dark, Water , Physical }
    class ConsoleMon
    {
        public string name = "Pickachu";
        public int health = 10;
        public int energy = 200;
        public Elementen weakness;
        public List<Skill> skills = new List<Skill>();
        public string monsterType;
        internal void TakeDamage(int damage)
        {

            this.health = health - damage;

        }

        internal void DepleteEnergy(int energy)
        {

            this.energy = this.energy - energy;
        }

        internal void Skill()
        {

        }
        internal ConsoleMon()
        {

        }

        internal ConsoleMon(ConsoleMon copyFrom)
        {
            this.health = copyFrom.health;
            this.energy = copyFrom.energy;
            this.name = copyFrom.name;
            this.skills = copyFrom.skills;

            foreach (Skill skill in copyFrom.skills)
            {
                Skill clone = new Skill(skill);
                this.skills.Add(clone);

            }
        }

    }

}
