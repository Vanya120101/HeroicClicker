using HeroicClicker.Presenter;
using HeroicClicker.View;
using HeroicClicker.View.Controls;
using HeroicClicker.View.Interfaces;
using System;
using System.Collections;
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
    public partial class MainForm : Form, IMainForm
    {

        #region Переменные
        private bool isOpenedMenu = true;
        private Point moveStart;

        private const int cGrip = 16;
        private const int cCaption = 32;
        #endregion

        public List<Control> ListOfControls { get; set; }


        public MainForm()
        {
            InitializeComponent();

            ListOfControls = new List<Control>();

            CreateControls();

            this.LeftMenu.Width = 200;
            this.FormBorderStyle = FormBorderStyle.None;
           // this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        public UserControl GetControl(string controlName)
        {
            Control[] controls = ContentPanel.Controls.Find(controlName, false);
            foreach (Control control in controls)
            {
                return control as UserControl;
            }

            return null;
        }

        /// <summary>
        /// Создание контролов.
        /// </summary>
        private void CreateControls()
        {
            PersonControl personControl = new PersonControl();
            StoryControl storyControl = new StoryControl();
            FightControl fightControl = new FightControl();
            AchievementControl achievementControl = new AchievementControl();
            CreatePersonControl createPersonControl = new CreatePersonControl();
            ProfilPersonControl profilPersonControl = new ProfilPersonControl();

            AdjustControls(personControl, storyControl, fightControl, achievementControl, createPersonControl, profilPersonControl);
        }
        /// <summary>
        /// Настраивание контролов.
        /// </summary>
        /// <param name="controls"></param>
        private void AdjustControls(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.Dock = DockStyle.Fill;
                ListOfControls.Add(control);
                ContentPanel.Controls.Add(control);
            }
        }

        /// <summary>
        /// Выделение выбранной кнопки.
        /// </summary>
        /// <param name="sender"></param>
        private void ClickButton(object sender)
        {
            Button selectedButton = (sender as Button);
            Button[] buttons = new Button[4] { this.PersonButton, this.StoryButton, this.FightButton, this.AchievementButton };
            foreach (Button button in buttons)
            {
                button.BackColor = Color.FromArgb(250, 250, 250);
            }
            selectedButton.BackColor = Color.White;
            IndicatorSelected.Top = selectedButton.Top;
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
                for (int i = 0; i <= 10; i++)
                {
                    LeftMenu.Width = 200 - (i * 20);
                }
            }
            else
            {
                for (int i = 0; i <= 10; i++)
                {
                    LeftMenu.Width = i * 20;
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
        /// Изменение размера формы.
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
                this.ResizeButton.ImageKey = "Expand.png";

            }

            //Control[] controls = ContentPanel.Controls.Find("CreatePersonControl", false);
            //foreach (var control in controls)
            //{
            //    Control[] controls2 = control.Controls.Find("CreatePersonLabel", false);
            //    foreach (var control2 in controls2)
            //    {
            //        control2.Location = new Point(ContentPanel.Width / 2 - 100, control2.Location.Y);

            //    }

            //}
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
            if (this.WindowState != FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Maximized;
                this.ResizeButton.ImageKey = "Compress.png";
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
                this.ResizeButton.ImageKey = "Expand.png";

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

        /// <summary>
        /// Нажатие на кнопку персонажа в меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PersonButton_Click(object sender, EventArgs e)
        {
            Control[] controls = ContentPanel.Controls.Find("CreatePersonControl", false);
            foreach (Control control in controls)
            {
                control.BringToFront();
            }
            ClickButton(sender);
        }

        /// <summary>
        /// Нажатие на кнопку "история" в меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StoryButton_Click(object sender, EventArgs e)
        {
            Control[] controls = ContentPanel.Controls.Find("StoryControl", false);
            foreach (Control control in controls)
            {
                control.BringToFront();
            }
            ClickButton(sender);

            
                
        }

        /// <summary>
        /// Нажатие на кнопку "Битвы" в меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FightButton_Click(object sender, EventArgs e)
        {
            Control[] controls = ContentPanel.Controls.Find("FightControl", false);
            foreach (Control control in controls)
            {
                control.BringToFront();
            }
            ClickButton(sender);
        }

        /// <summary>
        /// Нажатие на кнопку "Достижения" в меню.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AchievementButton_Click(object sender, EventArgs e)
        {
            Control[] controls = ContentPanel.Controls.Find("AchievementControl", false);
            foreach (Control control in controls)
            {
                control.BringToFront();
            }
            ClickButton(sender);
        }


    }
}

