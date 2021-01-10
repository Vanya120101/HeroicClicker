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

    public partial class CreatePersonControl : UserControl, ICreatePersonControl
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
                if (value<0)
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
                if (value<0)
                {
                    SpiritBox.Clear();
                    return;
                }
                SpiritBox.Text = value.ToString(); 
            }
        }
        #endregion
        public event Action CreatePerson;
        public event Action RandomCreatePerson;
        public event Action CancelCreatePerson;

        public CreatePersonControl()
        {
            InitializeComponent();

            this.WorldviewBox.DataSource = Enum.GetValues(typeof(WorldView));
            this.WorldviewBox.SelectedItem = null;

            this.ClassBox.DataSource = Enum.GetValues(typeof(Class));
            this.ClassBox.SelectedItem = null;
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (CreatePerson != null)
            {
                CreatePerson.Invoke();
            }

        }

        private void RandomButton_Click(object sender, EventArgs e)
        {
            if (RandomCreatePerson != null)
            {
                RandomCreatePerson.Invoke();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (CancelCreatePerson != null)
            {
                CancelCreatePerson.Invoke();
            }
        }

        public void ShowError(string messageError)
        {
            MessageBox.Show(messageError);
        }


    }
}
