using HeroicClicker.Model;
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
        BindingList<Person> Enemies;
        public FightPresenter(IFightChoiceControl fightChoiceControl)
        {
            FightChoiceControl = fightChoiceControl;
            Enemies = BasePresenter.Load("Enemies");
            
            FightChoiceControl.Enemies = Enemies;
            FightChoiceControl.FightButtonClick += FightButtonClick;
            FightChoiceControl.InformationButtonClick += InformationButtonClick;
            FightChoiceControl.ChangeButtonClick += ChangeButtonClick;


        }

        private void FightButtonClick()
        {
            if (FightChoiceControl.SelectedEnemy == null)
            {
                FightChoiceControl.ShowError("Противник не выбран");
            }
            //Вызвать на бой выбранного персонажа
        }
        private void InformationButtonClick()
        {
            if (FightChoiceControl.SelectedEnemy == null)
            {
                FightChoiceControl.ShowError("Персонаж не выбран");
            }
            //Вывести информацию о противнике
        }
        private void ChangeButtonClick()
        {
            //Поменять список противников
        }
    }
}
