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
    public partial class StoryControl : UserControl, IStoryControl
    {
        public StoryControl()
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

        public void ShowError(string errorMessage)
        {
            throw new NotImplementedException();
        }
    }
}
