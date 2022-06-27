using ConsoleMon;
using ConsoleMonsters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleMonsters
{
    class ConsoleMonData
    {
        internal string monsterLine;
        internal string skillLine;
    }
    class ConsoleMonFactory
    {
        private Dictionary<string, ConsoleMonData> templates = new Dictionary<string, ConsoleMonData>();

        public void Load()
        {
            //lees je regels in
            string[] lines = File.ReadAllLines(@"C:\Users\SKIKK\F1M4\2022P4consolemon\ConsoleMon\ConsoleMon\monsterdata.txt");
            

            //loop over je regels per 2 (i+=2)
            for (int i = 0; i < lines.Length; i+=2)
            {
                ConsoleMonData data = new ConsoleMonData();
                
                //zet monsterLine (regel1) & skillLine (regel2)
                data.monsterLine = lines[i];
                data.skillLine = lines[i+1];

                //split monsterline op ',' en pak de eerste, dit zou je monsterType moeten zijn

                string[] monsterType = data.monsterLine.Split(',');



                //even toevoegen
                templates.Add(monsterType[0], data);

            }

        }

        private ConsoleMon.ConsoleMon MakeConsoleMon(ConsoleMonData data)
        {
            ConsoleMon.ConsoleMon temp = new ConsoleMon.ConsoleMon();
            //split de monsterLine uit data weer op ','

            string[] properties = data.monsterLine.Split(',');


            //monsterType bestaat nog niet op ConsoleMon, voeg deze toe, deze variable heeft type string
            temp.monsterType = properties[0];

            //vergeet niet dat health een int is, hoe ging je ook al weer van een string naar een int?
            temp.health = Int32.Parse(properties[2]);
            //misschien heet Weakness anders bij jullie
            temp.weakness = LoadElement(properties[6]);

            
            //nu de skills, OOF!9
            string[] skillSep = data.skillLine.Split(';');
            //nu hebben we de verschillende skills in strings in skillSep (bv skillSep[0] is de data van de eerste skill)

            for (int i = 1; i < skillSep.Length; i ++)
            {
                Skill skill = LoadSkill(skillSep[i]);
                //laad de skill met de LoadSkill function

                //voeg nu skill van hierboven toe aan de skills van temp
                temp.skills.Add(skill);
            }
            return temp;
        }
        private Skill LoadSkill(string skillstring)
        {
            string[] split = skillstring.Split(',');

            //mogelijk heten deze varible net iets anders bij jullie, map het dan op de goede!
            Skill skill = new Skill()
            {
                moveName = split[0],
                damage = int.Parse(split[2]),
                EnergyCost = int.Parse(split[4]),
                element = LoadElement(split[6])
            };
            return skill;

        }


        //misschien dat jouw enum niet Element heet, dan even Element vervangen door jouw naam
        private static Elementen LoadElement(string split)
        {
            //als deze crashed, misschien hebben jullie andere enum values (bv je hebt geen Fire maar water)
            return (Elementen)Enum.Parse(typeof(Elementen), split);
        }

        //30 may 2022 12:26 aangepast
        internal ConsoleMon.ConsoleMon Make(string monstertype)
        {
            return MakeConsoleMon(templates[monstertype]);
        }
    }
}
