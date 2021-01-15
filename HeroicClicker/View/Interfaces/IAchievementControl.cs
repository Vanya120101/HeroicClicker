using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroicClicker.View.Interfaces
{
    interface IAchievementControl : IControl
    {
        BindingList<string> ListOfAchievements { set; }
    }
}
