using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeroicClicker
{
    public partial class MainForm : Form
    {
        private bool isOpenedMenu = true;
        public MainForm()
        {
            InitializeComponent();
            this.LeftMenu.BackColor = ColorTranslator.FromHtml("#FAFAFA"); 
            this.TopMenu.BackColor = ColorTranslator.FromHtml("#DB4C3F");

            this.MenuButton.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#DB4C3F");
            this.MenuButton.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#DB4C3F");

            this.LeftMenu.Width = 200;
        }

        /// <summary>
        /// Событие сворачивания, разворачивания меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuButton_Click(object sender, EventArgs e)
        {
            //TODO: сделать его асинхронно
            if (isOpenedMenu)
            {
                for (int i = 0; i <= 40; i++)
                {
                    LeftMenu.Width = 200 - (i * 5);
                }
            }
            else
            {
                for (int i = 0; i <= 40; i++)
                {
                    LeftMenu.Width = i * 5;
                }
            }
            isOpenedMenu = !isOpenedMenu;

        }
    }
}
