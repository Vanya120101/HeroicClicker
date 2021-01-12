using HeroicClicker.Model;
using HeroicClicker.View.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HeroicClicker.Presenter
{
    static class BasePresenter
    {
        public static void Save(BindingList<Person> Persons, string path)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Persons);
            }
        }

        public static BindingList<Person> Load(string path)
        {

            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                if (fs.Length > 0 && formatter.Deserialize(fs) is BindingList<Person> persons)
                {
                    return persons;
                }
                else
                {
                    return new BindingList<Person>();
                }
            }



        }
    }
}
