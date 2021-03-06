﻿using HeroicClicker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroicClicker.View.Interfaces
{
    interface IProfilPersonControl : IControl
    {
        string NameOfPerson { get; set; }
        string WorldViewOfPerson { set; }
        int LevelOfPerson { get; set; }
        string ClassOfPerson { set; }
        int BodyOfPerson { get; set; }
        int MindOfPerson { get; set; }
        int SpiritOfPerson { get; set; }
        BindingList<Person> Persons { set; }
        Person SelectedPerson { get; set; }
        event Action CreateNewPerson;
        event Action DeletePerson;
        event Action ChoosePerson;


    }
}
