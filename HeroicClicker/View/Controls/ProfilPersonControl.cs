using HeroicClicker.Model;
using HeroicClicker.View.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroicClicker.View.Controls
{

    public partial class ProfilPersonControl : UserControl, IProfilPersonControl
    {
        #region Свойства
        public string NameOfPerson
        {
            get { return NameBox.Text; }
            set { NameBox.Text = value; }
        }

        public WorldView? WorldViewOfPerson
        {
            get
            {
                if (WorldviewBox.SelectedItem == null)
                {
                    return null;
                }
                else
                {
                    return (WorldView)WorldviewBox.SelectedItem;

                }
            }
            set { WorldviewBox.SelectedItem = value; }
        }

        public int LevelOfPerson
        {
            get
            {
                int result;
                if (Int32.TryParse(LvlBox.Text, out result))
                {
                    return result;

                }
                else
                {
                    return 0;
                }
            }
            set { LvlBox.Text = value.ToString(); }
        }

        public Class? ClassOfPerson
        {
            get
            {
                if (ClassBox.SelectedItem == null)
                {
                    return null;
                }
                else
                {
                    return (Class)ClassBox.SelectedItem;

                }
            }
            set { ClassBox.SelectedItem = value; }
        }
        public int BodyOfPerson
        {
            get
            {
                int result;
                if (Int32.TryParse(BodyBox.Text, out result))
                {
                    return result;

                }
                else
                {
                    return 0;
                }
            }
            set { BodyBox.Text = value.ToString(); }
        }
        public int MindOfPerson
        {
            get
            {
                int result;
                if (Int32.TryParse(MindBox.Text, out result))
                {
                    return result;

                }
                else
                {
                    return 0;
                }
            }
            set { MindBox.Text = value.ToString(); }
        }
        public int SpiritOfPerson
        {
            get
            {
                int result;
                if (Int32.TryParse(SpiritBox.Text, out result))
                {
                    return result;

                }
                else
                {
                    return 0;
                }
            }
            set { SpiritBox.Text = value.ToString(); }
        }

        public BindingList<Person> Persons { get; set; }

        public event Action CreateNewPerson;
        public event Action EditPerson;

        #endregion


        public ProfilPersonControl()
        {
            InitializeComponent();
            ClassBox.DataSource = Enum.GetValues(typeof(Class));
            WorldviewBox.DataSource = Enum.GetValues(typeof(WorldView));
            Persons = new BindingList<Person>();
            this.ListOfPersons.DataSource = Persons;

        }

        private void CreatePersonButton_Click(object sender, EventArgs e)
        {
            if (CreateNewPerson != null)
            {
                CreateNewPerson.Invoke();
            }
        }

        private void EditPersonButton_Click(object sender, EventArgs e)
        {
            if (EditPerson != null)
            {
                EditPerson.Invoke();
            }
        }
    }
}
