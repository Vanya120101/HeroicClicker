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
    public partial class FightControl : UserControl, IFightControl
    {
        public string NameOfFirstFigther
        {
            get { return this.FirstFigtherNameLabel.Text; }
            set { this.FirstFigtherNameLabel.Text = value; }
        }

        public string NameOfSecondFighter
        {
            get { return this.SecondFigtherNameLabel.Text; }
            set { this.SecondFigtherNameLabel.Text = value; }
        }
        public int HealthOfFirstFighter
        {
            get 
            {
                int index = this.FirstFighterHealth.Text.IndexOf('/');
                string health = this.FirstFighterHealth.Text.Substring(0, index); return int.Parse(health);
            }
            set
            {
                if (value <= 0)
                {
                    value = 0;
                }
                this.FirstFighterHealth.Text = string.Format("{0}/{1}", value, FirstFighterMaxHealth);
            }
        }
        public int HealthOfSecondFighter
        {
            get
            {
                int index = this.SecondFighterHealth.Text.IndexOf('/');
                string health = this.SecondFighterHealth.Text.Substring(0, index);
                return int.Parse(health);
            }
            set
            {
                if(value <= 0)
                {
                    value = 0;
                }
                this.SecondFighterHealth.Text = string.Format("{0}/{1}", value, SecondFighterMaxHealth);
            }
        }

        public string FightButtonText
        {
            get { return this.FightButton.Text; }
            set { this.FightButton.Text = value; }
        }


        public string Log
        {
            get { return this.LogFightStartLabel.Text; }
            set { this.LogFightStartLabel.Text = value; }
        }

        public string LogFirstFigher
        {
            get { return this.FirstFigherLogLabel.Text; }
            set { this.FirstFigherLogLabel.Text = value; }
        }
        public string LogSecondFigher
        {
            get { return this.SecondFighterLogLabel.Text; }
            set { this.SecondFighterLogLabel.Text = value; }
        }

        public int FirstFighterMaxHealth { get; set; }
        public int SecondFighterMaxHealth { get; set; }

        public event Action FigthButtonClick;


        public FightControl()
        {
            InitializeComponent();

            Binding bindingSizeToLocation = new Binding("Location", this.LogPanel, "Size");
            bindingSizeToLocation.Format += BindingSizeToLocation_Format;
            this.LogFightStartLabel.DataBindings.Add(bindingSizeToLocation);

            Binding bindingSizeToLocationFirstFighter = new Binding("Location", this.LogPanel, "Size");
            bindingSizeToLocationFirstFighter.Format += BindingSizeToLocationFirstFighter_Format;
            this.FirstFigherLogLabel.DataBindings.Add(bindingSizeToLocationFirstFighter);

            Binding bindingSizeToLocationSecondFighter = new Binding("Location", this.LogPanel, "Size");
            bindingSizeToLocationSecondFighter.Format += BindingSizeToLocationSecondFighter_Format;
            this.SecondFighterLogLabel.DataBindings.Add(bindingSizeToLocationSecondFighter);


        }

        private void BindingSizeToLocationSecondFighter_Format(object sender, ConvertEventArgs e)
        {
            Point size = new Point(this.Size.Width - 400, 90);
            e.Value = size;
        }

        private void BindingSizeToLocationFirstFighter_Format(object sender, ConvertEventArgs e)
        {
            Point size = new Point(100, 90);
            e.Value = size;
        }

        private void BindingSizeToLocation_Format(object sender, ConvertEventArgs e)
        {
            Point size = new Point(this.Size.Width/2 - 180,10);
            e.Value = size;
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            if (FigthButtonClick != null)
            {
                FigthButtonClick.Invoke();
            }
        }

        
    }
}
