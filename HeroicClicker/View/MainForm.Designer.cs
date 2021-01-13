
namespace HeroicClicker
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.LeftMenu = new System.Windows.Forms.Panel();
            this.IndicatorSelected = new System.Windows.Forms.Panel();
            this.AchievementButton = new System.Windows.Forms.Button();
            this.MenuImages = new System.Windows.Forms.ImageList(this.components);
            this.FightButton = new System.Windows.Forms.Button();
            this.StoryButton = new System.Windows.Forms.Button();
            this.PersonButton = new System.Windows.Forms.Button();
            this.TopMenu = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ResizeButton = new System.Windows.Forms.Button();
            this.QuestionButton = new System.Windows.Forms.Button();
            this.MenuButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.LeftMenu.SuspendLayout();
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftMenu
            // 
            this.LeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.LeftMenu.Controls.Add(this.IndicatorSelected);
            this.LeftMenu.Controls.Add(this.AchievementButton);
            this.LeftMenu.Controls.Add(this.FightButton);
            this.LeftMenu.Controls.Add(this.StoryButton);
            this.LeftMenu.Controls.Add(this.PersonButton);
            this.LeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenu.ForeColor = System.Drawing.Color.Coral;
            this.LeftMenu.Location = new System.Drawing.Point(0, 100);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(200, 505);
            this.LeftMenu.TabIndex = 0;
            // 
            // IndicatorSelected
            // 
            this.IndicatorSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.IndicatorSelected.Location = new System.Drawing.Point(0, 0);
            this.IndicatorSelected.Name = "IndicatorSelected";
            this.IndicatorSelected.Size = new System.Drawing.Size(5, 80);
            this.IndicatorSelected.TabIndex = 2;
            // 
            // AchievementButton
            // 
            this.AchievementButton.AutoSize = true;
            this.AchievementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AchievementButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AchievementButton.FlatAppearance.BorderSize = 0;
            this.AchievementButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AchievementButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AchievementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AchievementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AchievementButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AchievementButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AchievementButton.ImageKey = "Achievement.png";
            this.AchievementButton.ImageList = this.MenuImages;
            this.AchievementButton.Location = new System.Drawing.Point(0, 240);
            this.AchievementButton.Margin = new System.Windows.Forms.Padding(0);
            this.AchievementButton.Name = "AchievementButton";
            this.AchievementButton.Size = new System.Drawing.Size(200, 80);
            this.AchievementButton.TabIndex = 3;
            this.AchievementButton.Text = "Достижения";
            this.AchievementButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AchievementButton.UseVisualStyleBackColor = true;
            this.AchievementButton.Click += new System.EventHandler(this.AchievementButton_Click);
            // 
            // MenuImages
            // 
            this.MenuImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MenuImages.ImageStream")));
            this.MenuImages.TransparentColor = System.Drawing.Color.Transparent;
            this.MenuImages.Images.SetKeyName(0, "Compress.png");
            this.MenuImages.Images.SetKeyName(1, "Expand.png");
            this.MenuImages.Images.SetKeyName(2, "Menu.png");
            this.MenuImages.Images.SetKeyName(3, "Search.png");
            this.MenuImages.Images.SetKeyName(4, "Close.png");
            this.MenuImages.Images.SetKeyName(5, "Minus.png");
            this.MenuImages.Images.SetKeyName(6, "Person.png");
            this.MenuImages.Images.SetKeyName(7, "Book.png");
            this.MenuImages.Images.SetKeyName(8, "Fight.png");
            this.MenuImages.Images.SetKeyName(9, "Achievement.png");
            // 
            // FightButton
            // 
            this.FightButton.AutoSize = true;
            this.FightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FightButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.FightButton.FlatAppearance.BorderSize = 0;
            this.FightButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.FightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.FightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FightButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FightButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FightButton.ImageKey = "Fight.png";
            this.FightButton.ImageList = this.MenuImages;
            this.FightButton.Location = new System.Drawing.Point(0, 160);
            this.FightButton.Margin = new System.Windows.Forms.Padding(0);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(200, 80);
            this.FightButton.TabIndex = 2;
            this.FightButton.Text = "Битвы";
            this.FightButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // StoryButton
            // 
            this.StoryButton.AutoSize = true;
            this.StoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StoryButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StoryButton.FlatAppearance.BorderSize = 0;
            this.StoryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.StoryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.StoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StoryButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StoryButton.ImageKey = "Book.png";
            this.StoryButton.ImageList = this.MenuImages;
            this.StoryButton.Location = new System.Drawing.Point(0, 80);
            this.StoryButton.Margin = new System.Windows.Forms.Padding(0);
            this.StoryButton.Name = "StoryButton";
            this.StoryButton.Size = new System.Drawing.Size(200, 80);
            this.StoryButton.TabIndex = 1;
            this.StoryButton.Text = "История";
            this.StoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StoryButton.UseVisualStyleBackColor = true;
            this.StoryButton.Click += new System.EventHandler(this.StoryButton_Click);
            // 
            // PersonButton
            // 
            this.PersonButton.AutoSize = true;
            this.PersonButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PersonButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PersonButton.FlatAppearance.BorderSize = 0;
            this.PersonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.PersonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.PersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PersonButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonButton.ImageKey = "Person.png";
            this.PersonButton.ImageList = this.MenuImages;
            this.PersonButton.Location = new System.Drawing.Point(0, 0);
            this.PersonButton.Margin = new System.Windows.Forms.Padding(0);
            this.PersonButton.Name = "PersonButton";
            this.PersonButton.Size = new System.Drawing.Size(200, 80);
            this.PersonButton.TabIndex = 0;
            this.PersonButton.Text = "Персонаж";
            this.PersonButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PersonButton.UseVisualStyleBackColor = true;
            this.PersonButton.Click += new System.EventHandler(this.PersonButton_Click);
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.TopMenu.Controls.Add(this.MinimizeButton);
            this.TopMenu.Controls.Add(this.CancelButton);
            this.TopMenu.Controls.Add(this.ResizeButton);
            this.TopMenu.Controls.Add(this.QuestionButton);
            this.TopMenu.Controls.Add(this.MenuButton);
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(1103, 100);
            this.TopMenu.TabIndex = 1;
            this.TopMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMenu_MouseDown);
            this.TopMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopMenu_MouseMove);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ImageKey = "Minus.png";
            this.MinimizeButton.ImageList = this.MenuImages;
            this.MinimizeButton.Location = new System.Drawing.Point(791, 3);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(100, 100);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ImageKey = "Close.png";
            this.CancelButton.ImageList = this.MenuImages;
            this.CancelButton.Location = new System.Drawing.Point(1003, 0);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(100, 100);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ResizeButton
            // 
            this.ResizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ResizeButton.AutoSize = true;
            this.ResizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResizeButton.FlatAppearance.BorderSize = 0;
            this.ResizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.ResizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.ResizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResizeButton.ImageKey = "Compress.png";
            this.ResizeButton.ImageList = this.MenuImages;
            this.ResizeButton.Location = new System.Drawing.Point(897, 3);
            this.ResizeButton.Name = "ResizeButton";
            this.ResizeButton.Size = new System.Drawing.Size(100, 100);
            this.ResizeButton.TabIndex = 2;
            this.ResizeButton.UseVisualStyleBackColor = true;
            this.ResizeButton.Click += new System.EventHandler(this.ResizeButton_Click);
            // 
            // QuestionButton
            // 
            this.QuestionButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.QuestionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuestionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuestionButton.FlatAppearance.BorderSize = 0;
            this.QuestionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.QuestionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.QuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionButton.ImageKey = "Search.png";
            this.QuestionButton.ImageList = this.MenuImages;
            this.QuestionButton.Location = new System.Drawing.Point(671, 3);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(100, 100);
            this.QuestionButton.TabIndex = 3;
            this.QuestionButton.UseVisualStyleBackColor = true;
            // 
            // MenuButton
            // 
            this.MenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MenuButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MenuButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuButton.FlatAppearance.BorderSize = 0;
            this.MenuButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.MenuButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.MenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MenuButton.ImageKey = "Menu.png";
            this.MenuButton.ImageList = this.MenuImages;
            this.MenuButton.Location = new System.Drawing.Point(0, 0);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(200, 100);
            this.MenuButton.TabIndex = 0;
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.ForeColor = System.Drawing.Color.Black;
            this.ContentPanel.Location = new System.Drawing.Point(200, 100);
            this.ContentPanel.MinimumSize = new System.Drawing.Size(554, 405);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(903, 505);
            this.ContentPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1103, 620);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.LeftMenu);
            this.Controls.Add(this.TopMenu);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.LeftMenu.ResumeLayout(false);
            this.LeftMenu.PerformLayout();
            this.TopMenu.ResumeLayout(false);
            this.TopMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftMenu;
        private System.Windows.Forms.Panel TopMenu;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.ImageList MenuImages;
        private System.Windows.Forms.Button PersonButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ResizeButton;
        private System.Windows.Forms.Button QuestionButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button AchievementButton;
        private System.Windows.Forms.Button FightButton;
        private System.Windows.Forms.Button StoryButton;
        private System.Windows.Forms.Panel IndicatorSelected;
        private System.Windows.Forms.Panel ContentPanel;
    }
}

