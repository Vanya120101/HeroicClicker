using HeroicClicker.Model;
using HeroicClicker.View.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroicClicker.Presenter
{
    class PersonPresenter
    {

        Person CurrentPerson;
        ICreatePersonControl CreatePersonControl;
        IProfilPersonControl ProfilPersonControl;
        public PersonPresenter(ICreatePersonControl createPersonControl, IProfilPersonControl profilPersonControl)
        {

            CreatePersonControl = createPersonControl;
            CreatePersonControl.CreatePerson += CreatePerson;
            CreatePersonControl.RandomCreatePerson += PersonCreateRandom;
            CreatePersonControl.CancelCreatePerson += CancelCreatePersonControl;

            ProfilPersonControl = profilPersonControl;
            ProfilPersonControl.CreateNewPerson += ShowCreatPersonPanel;


        }

        private void CreatePerson()
        {
            StringBuilder log = new StringBuilder();
            if (string.IsNullOrEmpty(CreatePersonControl.NameOfPerson))
            {
                log.Append("Имя персонажа не может быть пустым");
                log.AppendLine();
            }
            if (CreatePersonControl.WorldViewOfPerson == null)
            {
                log.Append("Мировоззрение персонажа не может пустым");
                log.AppendLine();
            }
            if (CreatePersonControl.LevelOfPerson <=0)
            {
                log.Append("Уровень персонажа не может быть равным нулю или меньше");
                log.AppendLine();
            }
            if (CreatePersonControl.ClassOfPerson == null)
            {
                log.Append("Класс персонажа не может пустым");
                log.AppendLine();
            }
            if (CreatePersonControl.BodyOfPerson<=0)
            {
                log.Append("Тело персонажа не может быть равным нулю или меньше");
                log.AppendLine();
            }
            if (CreatePersonControl.MindOfPerson <= 0)
            {
                log.Append("Разум персонажа не может быть равным нулю или меньше");
                log.AppendLine();
            }
            if (CreatePersonControl.SpiritOfPerson <= 0)
            {
                log.Append("Дух персонажа не может быть равным нулю или меньше");
                log.AppendLine();
            }
            if (log.Length>0)
            {
                CreatePersonControl.ShowError(log.ToString());
                return;
            }

            Person person = new Person(CreatePersonControl.NameOfPerson, CreatePersonControl.WorldViewOfPerson, CreatePersonControl.LevelOfPerson,
                                        CreatePersonControl.ClassOfPerson, CreatePersonControl.BodyOfPerson, CreatePersonControl.MindOfPerson,
                                        CreatePersonControl.SpiritOfPerson);

            CurrentPerson = person;
            ProfilPersonControl.Persons.Add(CurrentPerson);

            SetCharacteristic();
            ProfilPersonControl.BringToFront();
            

        }

        private void PersonCreateRandom()
        {
            CreatePersonControl.NameOfPerson = "Vanya";
            CreatePersonControl.WorldViewOfPerson = WorldView.Злой;
            CreatePersonControl.LevelOfPerson = 12;
            CreatePersonControl.ClassOfPerson = Class.Маг;
            CreatePersonControl.BodyOfPerson = 12;
            CreatePersonControl.MindOfPerson = 13;
            CreatePersonControl.SpiritOfPerson = 13;
        }

        private void CancelCreatePersonControl()
        {
            ProfilPersonControl.BringToFront();
        }

        private void ShowCreatPersonPanel()
        {
            CreatePersonControl.BringToFront();
        }
        private void SetCharacteristic()
        {
            if (CurrentPerson == null)
            {
                return;
            }

            ProfilPersonControl.NameOfPerson = CurrentPerson.Name;
            ProfilPersonControl.WorldViewOfPerson = CurrentPerson.WorldView;
            ProfilPersonControl.LevelOfPerson = CurrentPerson.Level;
            ProfilPersonControl.ClassOfPerson = CurrentPerson.Class;
            ProfilPersonControl.BodyOfPerson = CurrentPerson.Body;
            ProfilPersonControl.MindOfPerson = CurrentPerson.Mind;
            ProfilPersonControl.SpiritOfPerson = CurrentPerson.Spirit;
        }
    }
}
