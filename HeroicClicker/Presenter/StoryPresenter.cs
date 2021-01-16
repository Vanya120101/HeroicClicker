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
    class StoryPresenter
    {
        IStoryControl StoryControl;
        IFightControl FightControl;
        MainPresenter MainPresenter;
        BattlePresenter BattlePresenter;

        BindingList<Person> Enemies;

        public event AddAchievement AddAchievement;

        int step = 0;
        int count = 0;


        public StoryPresenter(MainPresenter mainPresenter, IStoryControl storyControl, IFightControl fightControl, BattlePresenter battlePresenter)
        {
            StoryControl = storyControl;
            FightControl = fightControl;
            MainPresenter = mainPresenter;
            BattlePresenter = battlePresenter;
            BattlePresenter.DoNextStepStory += BeginStartStory;
            Enemies = BasePresenter.Load("Enemies");

            StoryControl.StartStory += BeginStory;


            FillInStories();

        }

   

        private void BattlePresenter_DoNextStep()
        {
            BeginStartStory();
        }

        private void FillInStories()
        {
            BindingList<string> stories = new BindingList<string>();
            stories.Add("Легкая");
            stories.Add("Средняя");
            stories.Add("Сложная");

            StoryControl.Stories = stories;
        }
        private void BeginStory()
        {
            if (StoryControl.SelectedStory == "Легкая")
            {
                step = 5;
                Enemies = GenerateEnemies(5, 1);
            }
            if (StoryControl.SelectedStory == "Средняя")
            {
                step = 10;
                Enemies = GenerateEnemies(10, 5);

            }
            if (StoryControl.SelectedStory == "Сложная")
            {
                step = 15;
                Enemies = GenerateEnemies(15, 15);

            }
            count = 0;
            BeginStartStory();
        }
        private void BeginStartStory()
        {
            if (count < step)
            {
                BattlePresenter.StartFight(MainPresenter.CurrentPerson, Enemies[count], StoryControl, true);
                count++;
            }
            else
            {
                FightControl.ShowError(string.Format("История {0} пройдена", StoryControl.SelectedStory));
                MainPresenter.CurrentPerson.Achievements.Add(string.Format("{0} история покорена", StoryControl.SelectedStory));
                AddAchievement(MainPresenter.CurrentPerson,StoryControl.SelectedStory, true);
                StoryControl.BringToFront();
            }
        }

        private BindingList<Person> GenerateEnemies(int count, int level)
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
              
                

                Person person = new Person(name, worldView, level, @class, body, mind, spirit);
                newEnemies.Add(person);
            }
            return newEnemies;
        }
    }
}
