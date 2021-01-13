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
    public partial class FightChoiceControl : UserControl, IFightChoiceControl
    {
        public BindingList<Person> Enemies
        {
            set { this.ListOfEnemies.DataSource = value; }
        }
        public Person SelectedEnemy 
        { 
            get
            { return this.ListOfEnemies.SelectedItem as Person; }
        }

        public event Action FightButtonClick;
        public event Action InformationButtonClick;
        public event Action ChangeButtonClick;
        public FightChoiceControl()
        {
            InitializeComponent();
            Binding bindingSizeToSize = new Binding("Size", this.LayoutPanel, "Size");
            bindingSizeToSize.Format += BindingSizeToSize_Format;
            this.ListOfEnemies.DataBindings.Add(bindingSizeToSize);
            
        }

        private void BindingSizeToSize_Format(object sender, ConvertEventArgs e)
        {
            e.Value = new Size(LayoutPanel.Size.Width - 150, this.LayoutPanel.Size.Height / 2);
        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            if (FightButtonClick != null)
            {
                FightButtonClick.Invoke();
            }
        }

        private void InformatioButton_Click(object sender, EventArgs e)
        {
            if (InformationButtonClick != null)
            {
                InformationButtonClick.Invoke();
            }
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            if (ChangeButtonClick != null)
            {
                ChangeButtonClick.Invoke();
            }
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }
    }
}
