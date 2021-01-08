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
    public partial class CreatePersonControl : UserControl
    {
   


        public CreatePersonControl()
        {
            InitializeComponent();

            //Binding bindinSizeToLocationLabel = new Binding("Location", this, "Size", false, DataSourceUpdateMode.OnPropertyChanged);
            //bindinSizeToLocationLabel.Format += SizeToLocationLabel_Format;
            //this.CreatePersonLabel.DataBindings.Add(bindinSizeToLocationLabel);


            //Binding bindinSizeToLocationPanel = new Binding("Size", this, "Size", false, DataSourceUpdateMode.OnPropertyChanged);
            //bindinSizeToLocationPanel.Format += SizeToLocationPanel_Format;
            //this.LayounPanel.DataBindings.Add(bindinSizeToLocationPanel);

            





        }

        //private void SizeToLocationPanel_Format(object sender, ConvertEventArgs e)
        //{
        //    Size size = (Size)e.Value;

        //    e.Value = new Size(size.Width - 50, size.Height - 20);
        //}

        //private void SizeToLocationLabel_Format(object sender, ConvertEventArgs e)
        //{
        //    Size size = (Size)e.Value;

        //    e.Value = new Point((size.Width - 284) / 2, 30);
        //}

    }
}
