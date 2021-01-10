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
    public delegate void ButtonEvent(object sender, EventArgs e);
    class MainPresenter
    {
        IMainForm MainForm;
        ICreatePersonControl CreatePersonControl;
        IProfilPersonControl ProfilPersonControl;
        IStoryControl StoryControl;
        IFightcontrol FightControl;
        IAchievementControl AchievementControl;

        PersonPresenter PersonPresenter;
        public MainPresenter(IMainForm mainForm)
        {
            MainForm = mainForm;
            CreateControls();

            PersonPresenter = new PersonPresenter(CreatePersonControl, ProfilPersonControl);

            MainForm.PersonButtonClick += PersonButtonClick;
            MainForm.StoryButtonClick += StoryButtonClick;
            MainForm.FightButtonClick += FightButtonClick;
            MainForm.AchievementButtonClick += AchievementButtonClick;

            PersonButtonClick(this, null);
        }

        private void AchievementButtonClick(object sender, EventArgs e)
        {
            AchievementControl.BringToFront();
        }

        private void FightButtonClick(object sender, EventArgs e)
        {
            FightControl.BringToFront();
        }


        private void StoryButtonClick(object sender, EventArgs e)
        {
            StoryControl.BringToFront();
        }
        private void PersonButtonClick(object sender, EventArgs e)
        {
            if (PersonPresenter.CountOfPersons == 0)
            {
                CreatePersonControl.BringToFront();
            }
            else
            {
                ProfilPersonControl.BringToFront();
            }
        }

        /// <summary>
        /// Создание контроллов.
        /// </summary>
        private void CreateControls()
        {
            CreatePersonControl = new CreatePersonControl();
            ProfilPersonControl = new ProfilPersonControl();
            StoryControl = new StoryControl();
            FightControl = new FightControl();
            AchievementControl = new AchievementControl();

            AdjustControls(CreatePersonControl,ProfilPersonControl, StoryControl, FightControl, AchievementControl);
        }
        /// <summary>
        /// Настройка контроллов.
        /// </summary>
        /// <param name="controls"></param>
        private void AdjustControls(params IControl[] controls)
        {
            foreach (Control control in controls)
            {
                control.Dock = DockStyle.Fill;
                MainForm.ControlsOfContentPanel.Add(control);
            }
        }


    }
}
