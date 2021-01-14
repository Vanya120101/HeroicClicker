using HeroicClicker.Model;
using HeroicClicker.View;
using HeroicClicker.View.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroicClicker.Presenter
{
    class FightPresenter
    {
        IFightChoiceControl FightChoiceControl;
        IFightControl FightControl;
        MainPresenter MainPresenter;

        BindingList<Person> Enemies;

        StringBuilder log;
        StringBuilder logFirst;
        StringBuilder logSecond;


        bool isQuery = true;
        Person FirstFighter
        {
            get { return MainPresenter.CurrentPerson; } 
        }

        Person SecondFighter
        {
            get { return FightChoiceControl.SelectedEnemy; }
        }
        public FightPresenter(MainPresenter mainPresenter, IFightChoiceControl fightChoiceControl, IFightControl fightControl)
        {
            MainPresenter = mainPresenter;

            FightChoiceControl = fightChoiceControl;
            Enemies = BasePresenter.Load("Enemies");
            
            FightChoiceControl.Enemies = Enemies;
            FightChoiceControl.FightButtonClick += FightButtonClick;
            FightChoiceControl.InformationButtonClick += InformationButtonClick;
            FightChoiceControl.ChangeButtonClick += ChangeButtonClick;

            FightControl = fightControl;
            FightControl.FigthButtonClick += FightButtonClickHit;

            log = new StringBuilder();
            logFirst = new StringBuilder();
            logSecond = new StringBuilder();


        }

        private void FightButtonClick()
        {
            if (FightChoiceControl.SelectedEnemy == null)
            {
                FightChoiceControl.ShowError("Противник не выбран");
                return;
            }
            FightControl.BringToFront();
            AdjustFightControl();

        }

        private void AdjustFightControl()
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
        private void InformationButtonClick()
        {
            if (FightChoiceControl.SelectedEnemy == null)
            {
                FightChoiceControl.ShowError("Персонаж не выбран");
                return;
            }

            PersonInformationForm personInformationForm = new PersonInformationForm(FightChoiceControl.SelectedEnemy);
            personInformationForm.Show();
            //Вывести информацию о противнике
        }
        private void ChangeButtonClick()
        {
            //Поменять список противников
        }

        private void FightButtonClickHit()
        {
            if (FightControl.FightButtonText == "Старт")
            { 
                FightControl.FightButtonText = "Ударить";
                log.AppendFormat("Битва между {0} и {1} началась", FirstFighter.Name, SecondFighter.Name);
                log.AppendLine();
                FightControl.Log = log.ToString();
                return;
            }
            if (FightControl.FightButtonText == "Финиш")
            {
                FightChoiceControl.BringToFront();
                log.Clear();
                logFirst.Clear();
                logSecond.Clear();
                return;
            }



            if (isQuery)
            {
                int damage = GetDamage(FirstFighter);
                logFirst.AppendFormat("{0} наносит {1} урона", FirstFighter.Name, damage);
                logFirst.AppendLine();
                logSecond.AppendLine();
                FightControl.LogFirstFigher = logFirst.ToString();
                FightControl.HealthOfSecondFighter -= damage;
                isQuery = false;
            }
            else
            {
                int damage = GetDamage(SecondFighter);
                logSecond.AppendFormat("{0} наносит {1} урона", SecondFighter.Name, damage);
                logSecond.AppendLine();
                logFirst.AppendLine();

                FightControl.LogSecondFigher = logSecond.ToString();
                FightControl.HealthOfFirstFighter -= damage;
                isQuery = true;
            }

            if (FightControl.HealthOfFirstFighter <=0)
            {
                log.Append("ВЫ ПРОИГРАЛИ");
                FightControl.Log = log.ToString();
                FightControl.FightButtonText = "Финиш";

            }
            if (FightControl.HealthOfSecondFighter <= 0)
            {
                log.Append("ВЫ ВЫИГРАЛИ");
                FightControl.Log = log.ToString();
                FightControl.FightButtonText = "Финиш";

            }

        }

        private int GetDamage(Person person) 
        {
            Random random = new Random();
            return person.Body / 4 + person.Spirit / 2 + random.Next(0, person.Mind);
        }
    }
}
