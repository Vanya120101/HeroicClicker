using HeroicClicker.Presenter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroicClicker.View.Interfaces
{
    interface IMainForm
    {

        Control.ControlCollection ControlsOfContentPanel { get;}

        event ButtonEvent PersonButtonClick;
        event ButtonEvent StoryButtonClick;
        event ButtonEvent FightButtonClick;
        event ButtonEvent AchievementButtonClick;





    }
}
