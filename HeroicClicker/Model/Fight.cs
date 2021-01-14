using HeroicClicker.View.Interfaces;
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
        IFightControl FightControl;
        IFightChoiceControl FightChoiceControl;

        StringBuilder log;
        StringBuilder logFirst;
        StringBuilder logSecond;
        bool isQuery = true;

        public Fight(IFightControl fightControl, IFightChoiceControl fightChoiceControl, Person firstFighter, Person secondFighter)
        {
            FightControl = fightControl;
            FirstFighter = firstFighter;
            SecondFighter = secondFighter;

            StartFight();
        }

        public void StartFight()
        {
            FightControl.NameOfFirstFigther = FirstFighter.Name;
            FightControl.NameOfSecondFighter = SecondFighter.Name;

            FightControl.FirstFighterMaxHealth = FirstFighter.Body * 2;
            FightControl.SecondFighterMaxHealth = SecondFighter.Body * 2;

            FightControl.HealthOfFirstFighter = FightControl.FirstFighterMaxHealth;
            FightControl.HealthOfSecondFighter = FightControl.SecondFighterMaxHealth;

            FightControl.Log = log.ToString();
            FightControl.LogFirstFigher = logFirst.ToString();
            FightControl.LogSecondFigher = logSecond.ToString();

            FightControl.FightButtonText = "Старт";
        }

        public Person FightContinue(ref StringBuilder log)
        {
            log.Append($"{FirstFighter.Name} наносит противнику 10 урона");
            return null;
        }

     
    }
}
