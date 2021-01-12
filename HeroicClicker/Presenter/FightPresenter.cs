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
        BindingList<Person> Enemies;
        public FightPresenter(IFightChoiceControl fightChoiceControl, IFightControl fightControl)
        {
            FightChoiceControl = fightChoiceControl;
            Enemies = BasePresenter.Load("Enemies");
            
            FightChoiceControl.Enemies = Enemies;
            FightChoiceControl.FightButtonClick += FightButtonClick;
            FightChoiceControl.InformationButtonClick += InformationButtonClick;
            FightChoiceControl.ChangeButtonClick += ChangeButtonClick;

            FightControl = fightControl;
        }

        private void FightButtonClick()
        {
            if (FightChoiceControl.SelectedEnemy == null)
            {
                FightChoiceControl.ShowError("Противник не выбран");
                return;
            }
            FightControl.BringToFront();
            //Вызвать на бой выбранного персонажа
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
    }
}
