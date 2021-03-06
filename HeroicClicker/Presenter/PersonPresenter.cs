﻿using HeroicClicker.Model;
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

        public Person CurrentPerson { get; set; }

        BindingList<Person> Persons;
        public int CountOfPersons
        {
            get { return Persons.Count; }
        }
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
            ProfilPersonControl.DeletePerson += DeletePerson;
            ProfilPersonControl.ChoosePerson += ChoosePerson;

            Persons = BasePresenter.Load("Persons");
    
            Persons.ListChanged += Persons_ListChanged;
            ProfilPersonControl.Persons = Persons;

        }

        private void Persons_ListChanged(object sender, ListChangedEventArgs e)
        {
            Save();
        }

        public void Save()
        {
            BasePresenter.Save(Persons, "Persons");
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
            if (CreatePersonControl.LevelOfPerson <= 0)
            {
                log.Append("Уровень персонажа не может быть равным нулю или меньше");
                log.AppendLine();
            }
            if (CreatePersonControl.ClassOfPerson == null)
            {
                log.Append("Класс персонажа не может пустым");
                log.AppendLine();
            }
            if (CreatePersonControl.SpiritOfPerson <= 4)
            {
                log.Append("Дух персонажа не может быть меньше 5");
                log.AppendLine();
            }
            if (CreatePersonControl.MindOfPerson <= 4)
            {
                log.Append("Разум персонажа не может быть меньше 5");
                log.AppendLine();
            }
            if (CreatePersonControl.BodyOfPerson <= 4)
            {
                log.Append("Тело персонажа не может быть меньше 5");
                log.AppendLine();
            }
            if (CreatePersonControl.BodyOfPerson + CreatePersonControl.MindOfPerson + CreatePersonControl.SpiritOfPerson > 20)
            {
                log.Append("Сумма параметров персонажа не может превышать 20");
                log.AppendLine();
            }
            if (log.Length > 0)
            {
                CreatePersonControl.ShowError(log.ToString());
                return;
            }


            Person person = new Person(CreatePersonControl.NameOfPerson, CreatePersonControl.WorldViewOfPerson, CreatePersonControl.LevelOfPerson,
                                        CreatePersonControl.ClassOfPerson, CreatePersonControl.BodyOfPerson, CreatePersonControl.MindOfPerson,
                                        CreatePersonControl.SpiritOfPerson);
            CurrentPerson = person;

            Persons.Add(CurrentPerson);

            ClearFilesCreatePersonControl();
            Update();

            ProfilPersonControl.BringToFront();


        }

        private void PersonCreateRandom()
        {
            Random random = new Random();


            CreatePersonControl.ClassOfPerson = (Class)random.Next(1, 4);
            CreatePersonControl.WorldViewOfPerson = (WorldView)random.Next(1, 4);

            string name;
            switch (random.Next(1, 7))
            {
                case 1:
                    name = "Алиса";
                    break;
                case 2:
                    name = "Беатрисс";
                    break;
                case 3:
                    name = "Венди";
                    break;
                case 4:
                    name = "Розвель";
                    break;
                case 5:
                    name = "Питер";
                    break;
                case 6:
                    name = "Джерар";
                    break;
                default:
                    name = "Неизвестный";
                    break;
            }
            CreatePersonControl.NameOfPerson = name;
            int result = 0;
            while (result != 20)
            {
                CreatePersonControl.BodyOfPerson = random.Next(5, 11);
                CreatePersonControl.MindOfPerson = random.Next(5, 11);
                CreatePersonControl.SpiritOfPerson = random.Next(5, 11);
                result = CreatePersonControl.BodyOfPerson + CreatePersonControl.MindOfPerson + CreatePersonControl.SpiritOfPerson;
            }

            CreatePersonControl.LevelOfPerson = 1;

        }

        private void CancelCreatePersonControl()
        {
            ProfilPersonControl.BringToFront();
        }

        private void ShowCreatPersonPanel()
        {
            CreatePersonControl.BringToFront();
        }
        public void Update()
        {
            if (CurrentPerson == null)
            {
                return;
            }

            ProfilPersonControl.NameOfPerson = CurrentPerson.Name;
            ProfilPersonControl.WorldViewOfPerson = CurrentPerson.WorldView.ToString();
            ProfilPersonControl.LevelOfPerson = CurrentPerson.Level;
            ProfilPersonControl.ClassOfPerson = CurrentPerson.Class.ToString();
            ProfilPersonControl.BodyOfPerson = CurrentPerson.Body;
            ProfilPersonControl.MindOfPerson = CurrentPerson.Mind;
            ProfilPersonControl.SpiritOfPerson = CurrentPerson.Spirit;
        }
        private void DeletePerson()
        {
            if (ProfilPersonControl.SelectedPerson == null)
            {
                ProfilPersonControl.ShowError("Персонаж для удаления не выбран");
                return;
            }
            if (ProfilPersonControl.SelectedPerson == CurrentPerson)
            {
                ClearFilesProfilPersonControl();
                CurrentPerson = null;
            }
            // ProfilPersonControl.Persons.Remove(ProfilPersonControl.SelectedPerson);
            Persons.Remove(ProfilPersonControl.SelectedPerson);
            //if (ProfilPersonControl.Persons.Count > 0)
            //{
            //    ProfilPersonControl.SelectedPerson = ProfilPersonControl.Persons[0];

            //}
            if (Persons.Count > 0)
            {
                ProfilPersonControl.SelectedPerson = Persons[0];
            }
        }

        private void ChoosePerson()
        {
            if (ProfilPersonControl.SelectedPerson == null)
            {
                ProfilPersonControl.ShowError("Персонаж для установки не выбран");
                return;
            }

            CurrentPerson = ProfilPersonControl.SelectedPerson;
            Update();
        }

        private void ClearFilesCreatePersonControl()
        {
            CreatePersonControl.NameOfPerson = null;
            CreatePersonControl.WorldViewOfPerson = null;
            CreatePersonControl.ClassOfPerson = null;
            CreatePersonControl.BodyOfPerson = -1;
            CreatePersonControl.MindOfPerson = -1;
            CreatePersonControl.SpiritOfPerson = -1;
        }

        private void ClearFilesProfilPersonControl()
        {
            ProfilPersonControl.NameOfPerson = null;
            ProfilPersonControl.WorldViewOfPerson = null;
            ProfilPersonControl.LevelOfPerson = -1;
            ProfilPersonControl.ClassOfPerson = null;
            ProfilPersonControl.BodyOfPerson = -1;
            ProfilPersonControl.MindOfPerson = -1;
            ProfilPersonControl.SpiritOfPerson = -1;
        }

        public void AddAchievement(Person person, string achievementPart, bool isStory = false)
        {
            string achievementString;
            if (isStory)
            {
                achievementString = string.Format("{0} покорил {1} историю", person.Name, achievementPart);
            }
            else
            {
                achievementString = string.Format("Покоритель {0}", achievementPart);
            }
            AddAchievement(person, achievementString);

            Save();

        }

        private void AddAchievement(Person person, string achievementString)
        {
            bool consist = false;

            foreach (string achievement in person.Achievements)
            {
                if (achievement == achievementString)
                {
                    consist = true;
                }
            }


            if (!consist)
            {
                person.Achievements.Add(achievementString);
            }

        }
    }
}
