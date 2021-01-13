using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroicClicker.Model
{
    class Fight
    {
        Person FirstFighter;
        Person SecondFighter;

        public Fight(Person firstFighter, Person secondFighter)
        {
            FirstFighter = firstFighter;
            SecondFighter = secondFighter;
        }

        public void StartFight(ref StringBuilder log)
        {
            log.AppendFormat("Битва между {0} и {1} началась", FirstFighter.Name, SecondFighter.Name);
        }

        public Person FightContinue(ref StringBuilder log)
        {
            log.Append($"{FirstFighter.Name} наносит противнику 10 урона");
            return null;
        }
    }
}
