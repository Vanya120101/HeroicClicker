
namespace HeroicClicker.View.Controls
{
    partial class ProfilPersonControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfilPersonControl));
            this.ProfilPersonLabel = new System.Windows.Forms.Label();
            this.LayounPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.PersonProfilPanel = new System.Windows.Forms.Panel();
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ListOfPersons = new System.Windows.Forms.ListBox();
            this.ChoosePersonButton = new System.Windows.Forms.Button();
            this.CreatePersonButton = new System.Windows.Forms.Button();
            this.DeletePersonButton = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.Label();
            this.SpiritBox = new System.Windows.Forms.Label();
            this.MindBox = new System.Windows.Forms.Label();
            this.BodyBox = new System.Windows.Forms.Label();
            this.ClassBox = new System.Windows.Forms.Label();
            this.LevelBox = new System.Windows.Forms.Label();
            this.WorldViewBox = new System.Windows.Forms.Label();
            this.LayounPanel.SuspendLayout();
            this.PersonProfilPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProfilPersonLabel
            // 
            this.ProfilPersonLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ProfilPersonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProfilPersonLabel.Location = new System.Drawing.Point(0, 0);
            this.ProfilPersonLabel.Margin = new System.Windows.Forms.Padding(3);
            this.ProfilPersonLabel.Name = "ProfilPersonLabel";
            this.ProfilPersonLabel.Size = new System.Drawing.Size(1387, 39);
            this.ProfilPersonLabel.TabIndex = 0;
            this.ProfilPersonLabel.Text = "Профиль персонажа";
            this.ProfilPersonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LayounPanel
            // 
            this.LayounPanel.AutoScroll = true;
            this.LayounPanel.BackColor = System.Drawing.Color.White;
            this.LayounPanel.Controls.Add(this.PersonProfilPanel);
            this.LayounPanel.Controls.Add(this.flowLayoutPanel1);
            this.LayounPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayounPanel.Location = new System.Drawing.Point(0, 39);
            this.LayounPanel.Name = "LayounPanel";
            this.LayounPanel.Padding = new System.Windows.Forms.Padding(50, 50, 50, 10);
            this.LayounPanel.Size = new System.Drawing.Size(1387, 999);
            this.LayounPanel.TabIndex = 22;
            // 
            // PersonProfilPanel
            // 
            this.PersonProfilPanel.BackColor = System.Drawing.Color.White;
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
            this.PersonProfilPanel.Location = new System.Drawing.Point(53, 53);
            this.PersonProfilPanel.Margin = new System.Windows.Forms.Padding(3, 3, 150, 3);
            this.PersonProfilPanel.Name = "PersonProfilPanel";
            this.PersonProfilPanel.Size = new System.Drawing.Size(711, 325);
            this.PersonProfilPanel.TabIndex = 23;
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
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ListOfPersons);
            this.flowLayoutPanel1.Controls.Add(this.ChoosePersonButton);
            this.flowLayoutPanel1.Controls.Add(this.CreatePersonButton);
            this.flowLayoutPanel1.Controls.Add(this.DeletePersonButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(80, 411);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(30, 30, 3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(551, 516);
            this.flowLayoutPanel1.TabIndex = 26;
            // 
            // ListOfPersons
            // 
            this.ListOfPersons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfPersons.FormattingEnabled = true;
            this.ListOfPersons.ItemHeight = 25;
            this.ListOfPersons.Location = new System.Drawing.Point(3, 3);
            this.ListOfPersons.Name = "ListOfPersons";
            this.ListOfPersons.Size = new System.Drawing.Size(517, 279);
            this.ListOfPersons.Sorted = true;
            this.ListOfPersons.TabIndex = 24;
            // 
            // ChoosePersonButton
            // 
            this.ChoosePersonButton.AutoSize = true;
            this.ChoosePersonButton.FlatAppearance.BorderSize = 0;
            this.ChoosePersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoosePersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoosePersonButton.Location = new System.Drawing.Point(3, 288);
            this.ChoosePersonButton.Name = "ChoosePersonButton";
            this.ChoosePersonButton.Size = new System.Drawing.Size(275, 35);
            this.ChoosePersonButton.TabIndex = 29;
            this.ChoosePersonButton.Text = "Выбрать персонажа";
            this.ChoosePersonButton.UseVisualStyleBackColor = true;
            this.ChoosePersonButton.Click += new System.EventHandler(this.ChoosePersonButton_Click);
            // 
            // CreatePersonButton
            // 
            this.CreatePersonButton.AutoSize = true;
            this.CreatePersonButton.FlatAppearance.BorderSize = 0;
            this.CreatePersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreatePersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatePersonButton.Location = new System.Drawing.Point(3, 329);
            this.CreatePersonButton.Name = "CreatePersonButton";
            this.CreatePersonButton.Size = new System.Drawing.Size(275, 35);
            this.CreatePersonButton.TabIndex = 28;
            this.CreatePersonButton.Text = "Создать персонажа";
            this.CreatePersonButton.UseVisualStyleBackColor = true;
            this.CreatePersonButton.Click += new System.EventHandler(this.CreatePersonButton_Click);
            // 
            // DeletePersonButton
            // 
            this.DeletePersonButton.AutoSize = true;
            this.DeletePersonButton.FlatAppearance.BorderSize = 0;
            this.DeletePersonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeletePersonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletePersonButton.Location = new System.Drawing.Point(3, 370);
            this.DeletePersonButton.Name = "DeletePersonButton";
            this.DeletePersonButton.Size = new System.Drawing.Size(275, 35);
            this.DeletePersonButton.TabIndex = 30;
            this.DeletePersonButton.Text = "Удалить персонажа";
            this.DeletePersonButton.UseVisualStyleBackColor = true;
            this.DeletePersonButton.Click += new System.EventHandler(this.DeletePersonButton_Click);
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
            // SpiritBox
            // 
            this.SpiritBox.AutoSize = true;
            this.SpiritBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpiritBox.Location = new System.Drawing.Point(531, 288);
            this.SpiritBox.Name = "SpiritBox";
            this.SpiritBox.Size = new System.Drawing.Size(0, 29);
            this.SpiritBox.TabIndex = 22;
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
            // BodyBox
            // 
            this.BodyBox.AutoSize = true;
            this.BodyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BodyBox.Location = new System.Drawing.Point(531, 220);
            this.BodyBox.Name = "BodyBox";
            this.BodyBox.Size = new System.Drawing.Size(0, 29);
            this.BodyBox.TabIndex = 25;
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
            // LevelBox
            // 
            this.LevelBox.AutoSize = true;
            this.LevelBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LevelBox.Location = new System.Drawing.Point(531, 149);
            this.LevelBox.Name = "LevelBox";
            this.LevelBox.Size = new System.Drawing.Size(0, 29);
            this.LevelBox.TabIndex = 27;
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
            // ProfilPersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LayounPanel);
            this.Controls.Add(this.ProfilPersonLabel);
            this.Name = "ProfilPersonControl";
            this.Size = new System.Drawing.Size(1387, 1038);
            this.LayounPanel.ResumeLayout(false);
            this.PersonProfilPanel.ResumeLayout(false);
            this.PersonProfilPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ProfilPersonLabel;
        private System.Windows.Forms.FlowLayoutPanel LayounPanel;
        private System.Windows.Forms.Panel PersonProfilPanel;
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
        private System.Windows.Forms.ListBox ListOfPersons;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ChoosePersonButton;
        private System.Windows.Forms.Button CreatePersonButton;
        private System.Windows.Forms.Button DeletePersonButton;
        private System.Windows.Forms.Label WorldViewBox;
        private System.Windows.Forms.Label LevelBox;
        private System.Windows.Forms.Label ClassBox;
        private System.Windows.Forms.Label BodyBox;
        private System.Windows.Forms.Label MindBox;
        private System.Windows.Forms.Label SpiritBox;
        private System.Windows.Forms.Label NameBox;
    }
}
