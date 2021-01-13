using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroicClicker.View.Interfaces
{
    interface IFightControl : IControl
    {
        string NameOfFirstFigther { get; set; }
        string NameOfSecondFighter { get; set; }
        int HealthOfFirstFighter { get; set; }
        int HealthOfSecondFighter { get; set; }

        int FirstFighterMaxHealth { get; set; }
        int SecondFighterMaxHealth { get; set; }
        string Log { get; set; }

        string LogFirstFigher { get; set; }
        string LogSecondFigher { get; set; }
        string FightButtonText { get; set; }
        event Action FigthButtonClick;

    }
}
