using HeroicClicker.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroicClicker.View
{
    public partial class PersonInformationForm : Form
    {
        public PersonInformationForm(Person person)
        {
            InitializeComponent();
            NameBox.Text = person.Name;
            WorldViewBox.Text = person.WorldView.ToString();
            LevelBox.Text = person.Level.ToString();
            ClassBox.Text = person.Class.ToString();
            BodyBox.Text = person.Body.ToString();
            MindBox.Text = person.Mind.ToString();
            SpiritBox.Text = person.Spirit.ToString();

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
