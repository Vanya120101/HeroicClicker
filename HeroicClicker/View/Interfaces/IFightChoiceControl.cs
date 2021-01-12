using HeroicClicker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroicClicker.View.Interfaces
{
    interface IFightChoiceControl : IControl
    {
        BindingList<Person> Enemies { set; }
        Person SelectedEnemy { get; }
        event Action FightButtonClick;
        event Action InformationButtonClick;
        event Action ChangeButtonClick;
    }
}
