
namespace HeroicClicker.View
{
    partial class PersonInformationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonInformationForm));
            this.TopMenu = new System.Windows.Forms.Panel();
            this.CloseButton = new System.Windows.Forms.Button();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.PersonProfilPanel = new System.Windows.Forms.Panel();
            this.WorldViewBox = new System.Windows.Forms.Label();
            this.LevelBox = new System.Windows.Forms.Label();
            this.ClassBox = new System.Windows.Forms.Label();
            this.BodyBox = new System.Windows.Forms.Label();
            this.MindBox = new System.Windows.Forms.Label();
            this.SpiritBox = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.Label();
            this.WorldviewLabel = new System.Windows.Forms.Label();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.SpiritLabel = new System.Windows.Forms.Label();
            this.MindLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LvlLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.BodyLabel = new System.Windows.Forms.Label();
            this.PersonLabel = new System.Windows.Forms.Label();
            this.AvatarLabel = new System.Windows.Forms.Label();
            this.AvatarBox = new System.Windows.Forms.PictureBox();
            this.TopMenu.SuspendLayout();
            this.PersonProfilPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(76)))), ((int)(((byte)(63)))));
            this.TopMenu.Controls.Add(this.CloseButton);
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(1029, 100);
            this.TopMenu.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ImageKey = "Delete";
            this.CloseButton.ImageList = this.Images;
            this.CloseButton.Location = new System.Drawing.Point(923, 0);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(106, 100);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Delete");
            // 
            // PersonProfilPanel
            // 
            this.PersonProfilPanel.AutoSize = true;
            this.PersonProfilPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.PersonProfilPanel.Controls.Add(this.WorldViewBox);
            this.PersonProfilPanel.Controls.Add(this.LevelBox);
            this.PersonProfilPanel.Controls.Add(this.ClassBox);
            this.PersonProfilPanel.Controls.Add(this.BodyBox);
            this.PersonProfilPanel.Controls.Add(this.MindBox);
            this.PersonProfilPanel.Controls.Add(this.SpiritBox);
            this.PersonProfilPanel.Controls.Add(this.NameBox);
            this.PersonProfilPanel.Controls.Add(this.WorldviewLabel);
            this.PersonProfilPanel.Controls.Add(this.InformationLabel);
            this.PersonProfilPanel.Controls.Add(this.SpiritLabel);
            this.PersonProfilPanel.Controls.Add(this.MindLabel);
            this.PersonProfilPanel.Controls.Add(this.NameLabel);
            this.PersonProfilPanel.Controls.Add(this.LvlLabel);
            this.PersonProfilPanel.Controls.Add(this.ClassLabel);
            this.PersonProfilPanel.Controls.Add(this.BodyLabel);
            this.PersonProfilPanel.Controls.Add(this.PersonLabel);
            this.PersonProfilPanel.Controls.Add(this.AvatarLabel);
            this.PersonProfilPanel.Controls.Add(this.AvatarBox);
            this.PersonProfilPanel.Location = new System.Drawing.Point(28, 140);
            this.PersonProfilPanel.Margin = new System.Windows.Forms.Padding(3, 3, 150, 3);
            this.PersonProfilPanel.Name = "PersonProfilPanel";
            this.PersonProfilPanel.Size = new System.Drawing.Size(692, 325);
            this.PersonProfilPanel.TabIndex = 24;
            // 
            // WorldViewBox
            // 
            this.WorldViewBox.AutoSize = true;
            this.WorldViewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorldViewBox.Location = new System.Drawing.Point(531, 112);
            this.WorldViewBox.Name = "WorldViewBox";
            this.WorldViewBox.Size = new System.Drawing.Size(0, 29);
            this.WorldViewBox.TabIndex = 28;
            // 
            // LevelBox
            // 
            this.LevelBox.AutoSize = true;
            this.LevelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelBox.Location = new System.Drawing.Point(531, 149);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.Size = new System.Drawing.Size(0, 29);
            this.LevelBox.TabIndex = 27;
            // 
            // ClassBox
            // 
            this.ClassBox.AutoSize = true;
            this.ClassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassBox.Location = new System.Drawing.Point(531, 183);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(0, 29);
            this.ClassBox.TabIndex = 26;
            // 
            // BodyBox
            // 
            this.BodyBox.AutoSize = true;
            this.BodyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BodyBox.Location = new System.Drawing.Point(531, 220);
            this.BodyBox.Name = "BodyBox";
            this.BodyBox.Size = new System.Drawing.Size(0, 29);
            this.BodyBox.TabIndex = 25;
            // 
            // MindBox
            // 
            this.MindBox.AutoSize = true;
            this.MindBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MindBox.Location = new System.Drawing.Point(531, 254);
            this.MindBox.Name = "MindBox";
            this.MindBox.Size = new System.Drawing.Size(0, 29);
            this.MindBox.TabIndex = 24;
            // 
            // SpiritBox
            // 
            this.SpiritBox.AutoSize = true;
            this.SpiritBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpiritBox.Location = new System.Drawing.Point(531, 288);
            this.SpiritBox.Name = "SpiritBox";
            this.SpiritBox.Size = new System.Drawing.Size(0, 29);
            this.SpiritBox.TabIndex = 22;
            // 
            // NameBox
            // 
            this.NameBox.AutoSize = true;
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(531, 78);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(0, 29);
            this.NameBox.TabIndex = 21;
            // 
            // WorldviewLabel
            // 
            this.WorldviewLabel.AutoSize = true;
            this.WorldviewLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorldviewLabel.Location = new System.Drawing.Point(214, 112);
            this.WorldviewLabel.Name = "WorldviewLabel";
            this.WorldviewLabel.Size = new System.Drawing.Size(201, 29);
            this.WorldviewLabel.TabIndex = 20;
            this.WorldviewLabel.Text = "Мировоззрение";
            // 
            // InformationLabel
            // 
            this.InformationLabel.AutoSize = true;
            this.InformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationLabel.Location = new System.Drawing.Point(214, 48);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(181, 31);
            this.InformationLabel.TabIndex = 18;
            this.InformationLabel.Text = "Информация";
            // 
            // SpiritLabel
            // 
            this.SpiritLabel.AutoSize = true;
            this.SpiritLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpiritLabel.Location = new System.Drawing.Point(214, 288);
            this.SpiritLabel.Name = "SpiritLabel";
            this.SpiritLabel.Size = new System.Drawing.Size(51, 29);
            this.SpiritLabel.TabIndex = 12;
            this.SpiritLabel.Text = "Дух";
            // 
            // MindLabel
            // 
            this.MindLabel.AutoSize = true;
            this.MindLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MindLabel.Location = new System.Drawing.Point(214, 254);
            this.MindLabel.Name = "MindLabel";
            this.MindLabel.Size = new System.Drawing.Size(84, 29);
            this.MindLabel.TabIndex = 11;
            this.MindLabel.Text = "Разум";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameLabel.Location = new System.Drawing.Point(214, 78);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(63, 29);
            this.NameLabel.TabIndex = 10;
            this.NameLabel.Text = "Имя";
            // 
            // LvlLabel
            // 
            this.LvlLabel.AutoSize = true;
            this.LvlLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LvlLabel.Location = new System.Drawing.Point(214, 149);
            this.LvlLabel.Name = "LvlLabel";
            this.LvlLabel.Size = new System.Drawing.Size(113, 29);
            this.LvlLabel.TabIndex = 9;
            this.LvlLabel.Text = "Уровень";
            // 
            // ClassLabel
            // 
            this.ClassLabel.AutoSize = true;
            this.ClassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassLabel.Location = new System.Drawing.Point(214, 183);
            this.ClassLabel.Name = "ClassLabel";
            this.ClassLabel.Size = new System.Drawing.Size(81, 29);
            this.ClassLabel.TabIndex = 8;
            this.ClassLabel.Text = "Класс";
            // 
            // BodyLabel
            // 
            this.BodyLabel.AutoSize = true;
            this.BodyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BodyLabel.Location = new System.Drawing.Point(214, 220);
            this.BodyLabel.Name = "BodyLabel";
            this.BodyLabel.Size = new System.Drawing.Size(72, 29);
            this.BodyLabel.TabIndex = 7;
            this.BodyLabel.Text = "Тело";
            // 
            // PersonLabel
            // 
            this.PersonLabel.AutoSize = true;
            this.PersonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonLabel.Location = new System.Drawing.Point(18, 0);
            this.PersonLabel.Name = "PersonLabel";
            this.PersonLabel.Size = new System.Drawing.Size(178, 39);
            this.PersonLabel.TabIndex = 1;
            this.PersonLabel.Text = "Персонаж";
            // 
            // AvatarLabel
            // 
            this.AvatarLabel.AutoSize = true;
            this.AvatarLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvatarLabel.Location = new System.Drawing.Point(18, 48);
            this.AvatarLabel.Name = "AvatarLabel";
            this.AvatarLabel.Size = new System.Drawing.Size(103, 31);
            this.AvatarLabel.TabIndex = 6;
            this.AvatarLabel.Text = "Аватар";
            // 
            // AvatarBox
            // 
            this.AvatarBox.Image = ((System.Drawing.Image)(resources.GetObject("AvatarBox.Image")));
            this.AvatarBox.Location = new System.Drawing.Point(23, 76);
            this.AvatarBox.Name = "AvatarBox";
            this.AvatarBox.Size = new System.Drawing.Size(173, 155);
            this.AvatarBox.TabIndex = 3;
            this.AvatarBox.TabStop = false;
            // 
            // PersonInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1029, 600);
            this.Controls.Add(this.PersonProfilPanel);
            this.Controls.Add(this.TopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PersonInformationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PersonInformationForm";
            this.TopMenu.ResumeLayout(false);
            this.PersonProfilPanel.ResumeLayout(false);
            this.PersonProfilPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopMenu;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.Panel PersonProfilPanel;
        private System.Windows.Forms.Label WorldViewBox;
        private System.Windows.Forms.Label LevelBox;
        private System.Windows.Forms.Label ClassBox;
        private System.Windows.Forms.Label BodyBox;
        private System.Windows.Forms.Label MindBox;
        private System.Windows.Forms.Label SpiritBox;
        private System.Windows.Forms.Label NameBox;
        private System.Windows.Forms.Label WorldviewLabel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Label SpiritLabel;
        private System.Windows.Forms.Label MindLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LvlLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label BodyLabel;
        private System.Windows.Forms.Label PersonLabel;
        private System.Windows.Forms.Label AvatarLabel;
        private System.Windows.Forms.PictureBox AvatarBox;
    }
}