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
            set
            {
                if (value == null)
                {
                    NameBox.Clear();
                    return;
                }
                NameBox.Text = value;
            }
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
            set
            {
                WorldviewBox.SelectedItem = value;
            }
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
            set
            {
                if (value < 0)
                {
                    LvlBox.Clear();
                    return;

                }
                LvlBox.Text = value.ToString();
            }
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
            set
            {
                if (value < 0)
                {
                    BodyBox.Clear();
                    return;
                }
                BodyBox.Text = value.ToString();
            }
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
            set
            {
                if (value < 0)
                {
                    MindBox.Clear();
                    return;
                }
                MindBox.Text = value.ToString();
            }
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
            set
            {
                if (value < 0)
                {
                    SpiritBox.Clear();
                    return;
                }
                SpiritBox.Text = value.ToString();
            }
        }
        #endregion
        public Person SelectedPerson
        {
            get { return this.ListOfPersons.SelectedItem as Person; }
            set { this.ListOfPersons.SelectedItem = value; }
        }
        //public BindingList<Person> Persons { get; set; }

        public BindingList<Person> Persons
        {
            
            set { this.ListOfPersons.DataSource = value; }
        }




        public event Action CreateNewPerson;
        public event Action DeletePerson;
        public event Action ChoosePerson;



        public ProfilPersonControl()
        {
            InitializeComponent();
            ClassBox.DataSource = Enum.GetValues(typeof(Class));
            ClassBox.SelectedItem = null;
            WorldviewBox.DataSource = Enum.GetValues(typeof(WorldView));
            WorldviewBox.SelectedItem = null;

        }

   

        private void CreatePersonButton_Click(object sender, EventArgs e)
        {
            if (CreateNewPerson != null)
            {
                CreateNewPerson.Invoke();
            }
        }



        private void DeletePersonButton_Click(object sender, EventArgs e)
        {
            if (DeletePerson != null)
            {
                DeletePerson.Invoke();
            }
        }

        private void ChoosePersonButton_Click(object sender, EventArgs e)
        {
            if (ChoosePerson != null)
            {
                ChoosePerson.Invoke();
            }
        }

        public void ShowError(string messageError)
        {
            MessageBox.Show(messageError);
        }
    }
}
