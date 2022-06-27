using ConsoleMonsters;
using System;

namespace ConsoleMon
{
    class Program
    {

        static void Main(string[] args)
        {
            ConsoleMonFactory ConsoleMonFactory = new ();
            ConsoleMonFactory.Load();


            ConsoleMon a = ConsoleMonFactory.Make("EnterMon"); 
            ConsoleMon b = ConsoleMonFactory.Make("EnterMon"); 
            ConsoleMonArena ConsoleMonArena = new ();
            ConsoleMonArena.DoBattle(a, b);
        }
    }

}
