using System;


namespace ConsoleMon
{
    class ConsoleMonArena
    {
        
        internal void DoBattle(ConsoleMon a, ConsoleMon b)
        {
            Random random = new Random();

            int skillOfA = random.Next(0, a.skills.Count);
            a.skills[skillOfA].UseOn(a, b);
            Console.WriteLine("skill van A = " + a.skills[skillOfA].moveName);
            int skillOfB = random.Next(0, b.skills.Count);
            Console.WriteLine("skill van B = " + b.skills[skillOfB].moveName);
            b.skills[skillOfB].UseOn(b, a);

        }

    }

}
