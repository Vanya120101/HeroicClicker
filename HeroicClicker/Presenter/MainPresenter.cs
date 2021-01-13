using HeroicClicker.Model;
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
        IFightChoiceControl FightChoiceControl;
        IFightControl FightControl;
        IAchievementControl AchievementControl;

        PersonPresenter PersonPresenter;
        FightPresenter FightPresenter;

        public Person CurrentPerson
        {
            get { return PersonPresenter.CurrentPerson; }
        }
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

            FightPresenter = new FightPresenter(this, FightChoiceControl, FightControl);
            
        }

        private void AchievementButtonClick(object sender, EventArgs e)
        {
            if (CurrentPerson == null)
            {
                MainForm.ShowError("Персонаж не выбран");
                return;
            }
            AchievementControl.BringToFront();
        }

        private void FightButtonClick(object sender, EventArgs e)
        {
            if (CurrentPerson == null)
            {
                MainForm.ShowError("Персонаж не выбран");
                return;
            }
            FightChoiceControl.BringToFront();
        }


        private void StoryButtonClick(object sender, EventArgs e)
        {
            if (CurrentPerson == null)
            {
                MainForm.ShowError("Персонаж не выбран");
                return;
            }
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
            AchievementControl = new AchievementControl();
            FightChoiceControl = new FightChoiceControl();
            FightControl = new FightControl();


            AdjustControls(CreatePersonControl,ProfilPersonControl, StoryControl, FightChoiceControl, FightControl, AchievementControl);
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
