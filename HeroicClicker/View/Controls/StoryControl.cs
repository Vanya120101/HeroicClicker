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
        public string SelectedStory
        {
            get { return this.ListOfStory.SelectedItem.ToString(); }
            set { this.ListOfStory.SelectedItem = value; }
        }
        public BindingList<string> Stories
        {
            set { this.ListOfStory.DataSource = value; }
        }

        public event Action StartStory;
        public event Action ContinueStory;

        
        public StoryControl()
        {
            InitializeComponent();
            Binding bindingSizeToSize = new Binding("Size", this.LayoutPanel, "Size");
            bindingSizeToSize.Format += BindingSizeToSize_Format;
            this.ListOfStory.DataBindings.Add(bindingSizeToSize);
        }

        private void BindingSizeToSize_Format(object sender, ConvertEventArgs e)
        {
            e.Value = new Size(LayoutPanel.Size.Width - 150, this.LayoutPanel.Size.Height / 2);
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage);
        }

        private void StartStoryButton_Click(object sender, EventArgs e)
        {
            if (StartStory != null)
            {
                StartStory.Invoke();
            }
        }

        private void ContinueStoryButton_Click(object sender, EventArgs e)
        {
            if (ContinueStory != null)
            {
                ContinueStory.Invoke();
            }
        }
    }
}
