using HeroicClicker.Model;
using HeroicClicker.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroicClicker.Presenter
{
    class BattlePresenter
    {
        Person FirstFighter;
        Person SecondFighter;


        IFightControl FightControl;
        IControl Control;

        StringBuilder Log;
        StringBuilder LogFirst;
        StringBuilder LogSecond;

        bool isQuery = true;
        bool IsEnd = false;
        bool isVictory = false;

        public event Action DoNextStepStory;


        public BattlePresenter(IFightControl fightControl)
        {
            FightControl = fightControl;
            FightControl.FigthButtonClick += FightButtonClick;


            Log = new StringBuilder();
            LogFirst = new StringBuilder();
            LogSecond = new StringBuilder();

        }



        public void StartFight(Person firstFighter, Person secondFighter, IControl control)
        {
            Control = control;

            FightControl.BringToFront();

            FirstFighter = firstFighter;
            SecondFighter = secondFighter;

            Log.Clear();
            LogFirst.Clear();
            LogSecond.Clear();
            IsEnd = false;


            FightControl.Log = Log.ToString();
            FightControl.LogFirstFigher = LogFirst.ToString();
            FightControl.LogSecondFigher = LogSecond.ToString();

            FightControl.NameOfFirstFigther = FirstFighter.Name;
            FightControl.NameOfSecondFighter = SecondFighter.Name;

            FightControl.FirstFighterMaxHealth = FirstFighter.Body * 2;
            FightControl.SecondFighterMaxHealth = SecondFighter.Body * 2;

            FightControl.HealthOfFirstFighter = FightControl.FirstFighterMaxHealth;
            FightControl.HealthOfSecondFighter = FightControl.SecondFighterMaxHealth;


            FightControl.FightButtonText = "Старт";
        }

        private void FightButtonClick()
        {
            if (FightControl.FightButtonText == "Старт")
            {
                StartFight();
                return;
            }
            if (IsEnd)
            {
                if (DoNextStepStory != null && isVictory)
                {
                    DoNextStepStory.Invoke();
                    return;
                }
                Control.BringToFront();
                return;
            }



            if (isQuery)
            {
                FightControl.HealthOfSecondFighter = Step(FirstFighter, FightControl.HealthOfSecondFighter, LogFirst, LogSecond);
            }
            else
            {
                FightControl.HealthOfFirstFighter = Step(SecondFighter, FightControl.HealthOfFirstFighter, LogSecond, LogFirst);
            }

            
            if (FightControl.HealthOfFirstFighter * FightControl.HealthOfSecondFighter == 0)
            {
                FinalBattle();
            }

        }

        private void FinalBattle()
        {
            if (FightControl.HealthOfFirstFighter > FightControl.HealthOfSecondFighter)
            {
                Log.Append("ВЫ ВЫИГРАЛИ");
                isVictory = true;
            }
            else
            {
                Log.Append("ВЫ ПРОИГРАЛИ");
                isVictory = false;
            }

            FightControl.Log = Log.ToString();
            FightControl.FightButtonText = "Финиш";
            IsEnd = true;

        }

        private void StartFight()
        {
            FightControl.FightButtonText = "Продолжить";

            Log.AppendFormat("Битва между {0} и {1} началась", FirstFighter.Name, SecondFighter.Name);
            Log.AppendLine();
            FightControl.Log = Log.ToString();
        }

        private int Step(Person Striker, int healthEnemy, StringBuilder logStriker, StringBuilder logEnemy)
        {
            int damage = GetDamage(Striker);
            logStriker.AppendFormat("{0} наносит {1} урона", Striker.Name, damage);
            logStriker.AppendLine();
            logEnemy.AppendLine();
            isQuery = !isQuery;

            FightControl.LogFirstFigher = LogFirst.ToString();
            FightControl.LogSecondFigher = LogSecond.ToString();
            return healthEnemy -= damage;

        }
        private int GetDamage(Person person)
        {
            Random random = new Random();
            return person.Body / 4 + person.Spirit / 2 + random.Next(0, person.Mind);
        }
    }
}
