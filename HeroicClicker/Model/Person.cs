using HeroicClicker.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroicClicker.Model
{
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
            if (body<=0)
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
        }

        public override string ToString()
        {
            return $"{Name}, уровень: {Level}, класс: {Class}";
        }
    }
}
