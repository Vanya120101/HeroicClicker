using HeroicClicker.View.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroicClicker.Presenter
{
    class AchievementPresenter
    {
        MainPresenter MainPresenter;
        IAchievementControl AchievementControl;
        public AchievementPresenter(MainPresenter mainPresenter, IAchievementControl achievementControl)
        {
            MainPresenter = mainPresenter;
            AchievementControl = achievementControl; 
        }

        public void Update()
        {
           AchievementControl.ListOfAchievements = MainPresenter.CurrentPerson.Achievements;
        }
    }
}
