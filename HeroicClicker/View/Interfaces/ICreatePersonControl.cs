using HeroicClicker.View.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroicClicker.View.Interfaces
{

    interface ICreatePersonControl
    {
        string NameOfPerson { get; set; }
        WorldView? WorldViewOfPerson { get; set; }
        int LevelOfPerson { get; set; }
        Class? ClassOfPerson { get; set; }
        int BodyOfPerson { get; set; }
        int MindOfPerson { get; set; }
        int SpiritOfPerson { get; set; }

        event Action CreatePerson;
        event Action RandomCreatePerson;
        event Action CancelCreatePerson;

        void ShowError(string messageError);
        void BringToFront();
    }

    public enum WorldView
    {
        Добрый = 1,
        Нейтральный = 2,
        Злой = 3
    }

    public enum Class
    {
        Воин = 1,
        Хилл = 2,
        Маг = 3
    }
}
