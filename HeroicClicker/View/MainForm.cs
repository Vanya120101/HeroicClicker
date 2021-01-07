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
        private Point moveStart;

        private const int cGrip = 16;
        private const int cCaption = 32;   
        public MainForm()
        {
            InitializeComponent();
            this.LeftMenu.BackColor = ColorTranslator.FromHtml("#FAFAFA");
            this.TopMenu.BackColor = ColorTranslator.FromHtml("#DB4C3F");

            //this.MenuButton.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#DB4C3F");
            //this.MenuButton.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#DB4C3F");


            SetSettings(this.MenuButton, this.QuestionButton, this.ResizeButton, this.CancelButton);
            this.LeftMenu.Width = 200;

            this.FormBorderStyle = FormBorderStyle.None;
            //this.DoubleBuffered = true; //Мешает меню.
            this.SetStyle(ControlStyles.ResizeRedraw, true);

        }

        /// <summary>
        /// Установка параметров.
        /// </summary>
        /// <param name="buttons"></param>
        private void SetSettings(params Button[] buttons)
        {
            foreach (Button button in buttons)
            {
                button.FlatAppearance.MouseDownBackColor = ColorTranslator.FromHtml("#DB4C3F");
                button.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#DB4C3F");
            }
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

        /// <summary>
        /// Перемещение приложения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopMenu_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point deltaPos = new Point(e.X - moveStart.X, e.Y - moveStart.Y);
                this.Location = new Point(this.Location.X + deltaPos.X, this.Location.Y + deltaPos.Y);
            }
        }
        /// <summary>
        /// Событие для получения стартовой позиции перемещения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopMenu_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                moveStart = new Point(e.X, e.Y);

            }
        }


        /// <summary>
        /// Рисование треугольника в левом нижнем углу.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(this.ClientSize.Width - cGrip, this.ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, this.BackColor, rc);
            rc = new Rectangle(0, 0, this.ClientSize.Width, cCaption);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);
        }

        /// <summary>
        /// Перемещение формы.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.ResizeButton.ImageIndex = 2;

            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Закрыть приложение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Развернуть/Вернуть приложение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState !=FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                this.ResizeButton.ImageIndex = 1;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.ResizeButton.ImageIndex = 2;

            }
        }

        /// <summary>
        /// Свернуть приложение.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

