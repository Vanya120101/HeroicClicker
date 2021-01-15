using HeroicClicker.View.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HeroicClicker.Model
{
    [Serializable]
    public class Person
    {
        #region Свойства
        public string Name { get; set; }
        public WorldView? WorldView { get; set; }
        public int Level { get; set; }

        public Class? Class { get; set; }
        public int Body { get; set; }


        public int Mind { get; set; }
  
        public int Spirit { get; set; }

        public BindingList<string> Achievements { get; set; }

        int Experience { get; set; }

        public int Id { get; }
        #endregion




        public Person(string name, WorldView? worldView, int level, Class? @class, int body, int mind, int spirit)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("name", "Имя персонажа не может быть пустым");
            }
            if (worldView == null)
            {
                throw new ArgumentNullException("worldView", "Мировоззрение персонажа не может быть пустым");
            }
            if (level <= 0)
            {
                throw new ArgumentNullException("level", "Уровень персонажа не может быть равным нулю или меньше");
            }
            if (@class == null)
            {
                throw new ArgumentNullException("class", "Класс персонажа не может быть пустым");
            }
            if (body <= 0)
            {
                throw new ArgumentNullException("body", "Тело персонажа не может быть равным нулю или меньше");
            }
            if (mind <= 0)
            {
                throw new ArgumentNullException("mind", "Разум персонажа не может быть равным нулю или меньше");
            }
            if (spirit <= 0)
            {
                throw new ArgumentNullException("spirit", "Дух персонажа не может быть равным нулю или меньше");
            }

            Name = name;
            WorldView = worldView;
            Level = level;
            Class = @class;
            Body = body;
            Mind = mind;
            Spirit = spirit;
            Experience = Level * 10 - 10;
            LevelUp();

            Random random = new Random();
            Id = random.Next();

            Achievements = new BindingList<string>();
        }

        public void GiveExperience(int exp)
        {

            this.Experience += exp;
            LevelUp();
        }
        private void LevelUp()
        {
            Level = Experience / 10 + 1;
            if (Level > 1)
            {
                UpdateCharacteristics();
            }
        }
        private void UpdateCharacteristics()
        {
            this.Body = (int)(Body + Body  * 0.2);
            this.Mind = (int)(Mind + Mind  * 0.2);
            this.Spirit = (int)(Spirit + Spirit * 0.2);
        }
        public override string ToString()
        {
            return $"{Name}, уровень: {Level}, класс: {Class}";
        }
    }
}
