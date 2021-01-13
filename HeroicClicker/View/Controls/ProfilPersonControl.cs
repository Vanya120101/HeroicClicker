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
                    NameBox.Text = null;
                    return;
                }
                NameBox.Text = value;
            }
        }

        public string WorldViewOfPerson
        {
            
            set
            {
                WorldViewBox.Text = value;
            }
        }

        public int LevelOfPerson
        {
            get
            {
                int result;
                if (Int32.TryParse(LevelBox.Text, out result))
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
                    LevelBox.Text = null;
                    return;
                }
                LevelBox.Text = value.ToString();
            }
        }

        public string ClassOfPerson
        {
            
            set { ClassBox.Text = value; }
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
                    BodyBox.Text = null;
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
                    MindBox.Text = null;
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
                    SpiritBox.Text = null;
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
