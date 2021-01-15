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

        BattlePresenter BattlePresenter;




        public FightPresenter(MainPresenter mainPresenter, IFightChoiceControl fightChoiceControl, IFightControl fightControl, BattlePresenter battlePresenter)
        {
            MainPresenter = mainPresenter;

            FightChoiceControl = fightChoiceControl;
            Enemies = BasePresenter.Load("Enemies");
            BattlePresenter = battlePresenter;
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

            BattlePresenter.StartFight(MainPresenter.CurrentPerson, FightChoiceControl.SelectedEnemy, FightChoiceControl);

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
