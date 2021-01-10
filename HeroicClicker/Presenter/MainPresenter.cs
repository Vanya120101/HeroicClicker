using HeroicClicker.View.Controls;
using HeroicClicker.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroicClicker.Presenter
{
    class MainPresenter
    {
        IMainForm MainForm;
        public MainPresenter(IMainForm mainForm)
        {
            MainForm = mainForm;

            ICreatePersonControl createPersonControl = (ICreatePersonControl)MainForm.ListOfControls[4];
            IProfilPersonControl profilPersonControl = (IProfilPersonControl)MainForm.ListOfControls[5];
            PersonPresenter personPresenter = new PersonPresenter(createPersonControl, profilPersonControl);

        }

        


    }
}
