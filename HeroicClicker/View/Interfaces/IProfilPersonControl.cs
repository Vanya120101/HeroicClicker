using HeroicClicker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroicClicker.View.Interfaces
{
    interface IProfilPersonControl
    {
        string NameOfPerson { get; set; }
        WorldView? WorldViewOfPerson { get; set; }
        int LevelOfPerson { get; set; }
        Class? ClassOfPerson { get; set; }
        int BodyOfPerson { get; set; }
        int MindOfPerson { get; set; }
        int SpiritOfPerson { get; set; }
        BindingList<Person> Persons { get; set; }
        event Action CreateNewPerson;
        event Action EditPerson;

        void BringToFront();
    }
}
