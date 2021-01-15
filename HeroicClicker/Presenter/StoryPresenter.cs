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

        private void BattlePresenter_DoNextStepStory()
        {
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
            }
            if (StoryControl.SelectedStory == "Средняя")
            {
                step = 10;

            }
            if (StoryControl.SelectedStory == "Сложная")
            {
                step = 15;

            }
            count = 0;
            BeginStartStory();
        }
        private void BeginStartStory()
        {
            if (count<step)
            {
                BattlePresenter.StartFight(MainPresenter.CurrentPerson, Enemies[count], StoryControl);
                count++;
            }
            else
            {
                FightControl.ShowError("История пройдена");
                StoryControl.BringToFront();
            }
        }
    }
}
