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
            fightChoiceControl.ChangeButtonClick += ChangeButtonClick;

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
        }
        private void ChangeButtonClick()
        {
            BindingList<Person> newEnemies = new BindingList<Person>();
            Random random = new Random();
            for (int i = 0; i < 15; i++)
            {
                string name;
                switch (random.Next(1, 11))
                {
                    case 1:
                        name = "Финр";
                        break;
                    case 2:
                        name = "Хакон";
                        break;
                    case 3:
                        name = "Эгиль";
                        break;
                    case 4:
                        name = "Асне";
                        break;
                    case 5:
                        name = "Адела";
                        break;
                    case 6:
                        name = "Алва";
                        break;
                    case 7:
                        name = "Брунхильда";
                        break;
                    case 8:
                        name = "Герда";
                        break;
                    case 9:
                        name = "Гурда";
                        break;
                    case 10:
                        name = "Кэри";
                        break;
                    default:
                        name = "Неизвестный";
                        break;
                }

                WorldView worldView = (WorldView)random.Next(1, 4);
                Class @class = (Class)random.Next(1, 4);

                int result = 0;
                int body = 0;
                int mind = 0;
                int spirit = 0;
                while (result != 20)
                {
                    body = random.Next(5, 11);
                    mind = random.Next(5, 11);
                    spirit = random.Next(5, 11);
                    result = body + mind + spirit;
                }

                int level = random.Next(1, MainPresenter.CurrentPerson.Level + 5);

                Person person = new Person(name, worldView, level, @class, body, mind, spirit);
                newEnemies.Add(person);
            }
            Enemies = newEnemies;
            FightChoiceControl.Enemies = Enemies;



        }



    }
}
