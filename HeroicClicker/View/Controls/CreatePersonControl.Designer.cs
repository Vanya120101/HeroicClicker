
namespace HeroicClicker.View.Controls
{
    partial class CreatePersonControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePersonControl));
            this.CreatePersonLabel = new System.Windows.Forms.Label();
            this.PersonLabel = new System.Windows.Forms.Label();
            this.AvatarBox = new System.Windows.Forms.PictureBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AvatarLabel = new System.Windows.Forms.Label();
            this.PersonCreatePanel = new System.Windows.Forms.Panel();
            this.RandomButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.WorldviewLabel = new System.Windows.Forms.Label();
            this.WorldviewBox = new System.Windows.Forms.ComboBox();
            this.SpiritBox = new System.Windows.Forms.TextBox();
            this.InformationLabel = new System.Windows.Forms.Label();
            this.MindBox = new System.Windows.Forms.TextBox();
            this.BodyBox = new System.Windows.Forms.TextBox();
            this.LvlBox = new System.Windows.Forms.TextBox();
            this.SpiritLabel = new System.Windows.Forms.Label();
            this.MindLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.LvlLabel = new System.Windows.Forms.Label();
            this.ClassLabel = new System.Windows.Forms.Label();
            this.BodyLabel = new System.Windows.Forms.Label();
            this.LayounPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.InfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).BeginInit();
            this.PersonCreatePanel.SuspendLayout();
            this.LayounPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreatePersonLabel
            // 
            this.CreatePersonLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CreatePersonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreatePersonLabel.Location = new System.Drawing.Point(0, 0);
            this.CreatePersonLabel.Margin = new System.Windows.Forms.Padding(3);
            this.CreatePersonLabel.Name = "CreatePersonLabel";
            this.CreatePersonLabel.Size = new System.Drawing.Size(1387, 39);
            this.CreatePersonLabel.TabIndex = 0;
            this.CreatePersonLabel.Text = "Создание персонажа";
            this.CreatePersonLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // AvatarBox
            // 
            this.AvatarBox.Image = ((System.Drawing.Image)(resources.GetObject("AvatarBox.Image")));
            this.AvatarBox.Location = new System.Drawing.Point(23, 76);
            this.AvatarBox.Name = "AvatarBox";
            this.AvatarBox.Size = new System.Drawing.Size(173, 155);
            this.AvatarBox.TabIndex = 3;
            this.AvatarBox.TabStop = false;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(430, 78);
            this.NameBox.MaxLength = 15;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(287, 34);
            this.NameBox.TabIndex = 4;
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
            // PersonCreatePanel
            // 
            this.PersonCreatePanel.BackColor = System.Drawing.Color.White;
            this.PersonCreatePanel.Controls.Add(this.RandomButton);
            this.PersonCreatePanel.Controls.Add(this.CancelButton);
            this.PersonCreatePanel.Controls.Add(this.DownloadButton);
            this.PersonCreatePanel.Controls.Add(this.CreateButton);
            this.PersonCreatePanel.Controls.Add(this.ClassBox);
            this.PersonCreatePanel.Controls.Add(this.WorldviewLabel);
            this.PersonCreatePanel.Controls.Add(this.WorldviewBox);
            this.PersonCreatePanel.Controls.Add(this.SpiritBox);
            this.PersonCreatePanel.Controls.Add(this.InformationLabel);
            this.PersonCreatePanel.Controls.Add(this.MindBox);
            this.PersonCreatePanel.Controls.Add(this.BodyBox);
            this.PersonCreatePanel.Controls.Add(this.LvlBox);
            this.PersonCreatePanel.Controls.Add(this.SpiritLabel);
            this.PersonCreatePanel.Controls.Add(this.MindLabel);
            this.PersonCreatePanel.Controls.Add(this.NameLabel);
            this.PersonCreatePanel.Controls.Add(this.LvlLabel);
            this.PersonCreatePanel.Controls.Add(this.ClassLabel);
            this.PersonCreatePanel.Controls.Add(this.BodyLabel);
            this.PersonCreatePanel.Controls.Add(this.PersonLabel);
            this.PersonCreatePanel.Controls.Add(this.AvatarLabel);
            this.PersonCreatePanel.Controls.Add(this.AvatarBox);
            this.PersonCreatePanel.Controls.Add(this.NameBox);
            this.PersonCreatePanel.Location = new System.Drawing.Point(53, 53);
            this.PersonCreatePanel.Margin = new System.Windows.Forms.Padding(3, 3, 150, 3);
            this.PersonCreatePanel.Name = "PersonCreatePanel";
            this.PersonCreatePanel.Size = new System.Drawing.Size(720, 405);
            this.PersonCreatePanel.TabIndex = 7;
            // 
            // RandomButton
            // 
            this.RandomButton.AutoSize = true;
            this.RandomButton.FlatAppearance.BorderSize = 0;
            this.RandomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RandomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RandomButton.Location = new System.Drawing.Point(314, 365);
            this.RandomButton.Name = "RandomButton";
            this.RandomButton.Size = new System.Drawing.Size(101, 35);
            this.RandomButton.TabIndex = 24;
            this.RandomButton.Text = "Рандом";
            this.RandomButton.UseVisualStyleBackColor = true;
            this.RandomButton.Click += new System.EventHandler(this.RandomButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelButton.Location = new System.Drawing.Point(430, 365);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(101, 37);
            this.CancelButton.TabIndex = 23;
            this.CancelButton.Text = "Отмена";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DownloadButton
            // 
            this.DownloadButton.AutoSize = true;
            this.DownloadButton.FlatAppearance.BorderSize = 0;
            this.DownloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownloadButton.Location = new System.Drawing.Point(24, 232);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(173, 35);
            this.DownloadButton.TabIndex = 22;
            this.DownloadButton.Text = "Загрузить";
            this.DownloadButton.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            this.CreateButton.AutoSize = true;
            this.CreateButton.FlatAppearance.BorderSize = 0;
            this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.Location = new System.Drawing.Point(214, 365);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(101, 35);
            this.CreateButton.TabIndex = 8;
            this.CreateButton.Text = "Создать";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // ClassBox
            // 
            this.ClassBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(430, 183);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(287, 37);
            this.ClassBox.TabIndex = 21;
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
            // WorldviewBox
            // 
            this.WorldviewBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WorldviewBox.FormattingEnabled = true;
            this.WorldviewBox.Location = new System.Drawing.Point(430, 112);
            this.WorldviewBox.Name = "WorldviewBox";
            this.WorldviewBox.Size = new System.Drawing.Size(287, 37);
            this.WorldviewBox.TabIndex = 8;
            // 
            // SpiritBox
            // 
            this.SpiritBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SpiritBox.Location = new System.Drawing.Point(430, 288);
            this.SpiritBox.Name = "SpiritBox";
            this.SpiritBox.Size = new System.Drawing.Size(287, 34);
            this.SpiritBox.TabIndex = 19;
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
            // MindBox
            // 
            this.MindBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MindBox.Location = new System.Drawing.Point(430, 254);
            this.MindBox.Name = "MindBox";
            this.MindBox.Size = new System.Drawing.Size(287, 34);
            this.MindBox.TabIndex = 17;
            // 
            // BodyBox
            // 
            this.BodyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BodyBox.Location = new System.Drawing.Point(430, 220);
            this.BodyBox.MaxLength = 2;
            this.BodyBox.Name = "BodyBox";
            this.BodyBox.Size = new System.Drawing.Size(287, 34);
            this.BodyBox.TabIndex = 16;
            // 
            // LvlBox
            // 
            this.LvlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LvlBox.Location = new System.Drawing.Point(430, 149);
            this.LvlBox.Name = "LvlBox";
            this.LvlBox.Size = new System.Drawing.Size(287, 34);
            this.LvlBox.TabIndex = 14;
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
            // LayounPanel
            // 
            this.LayounPanel.AutoScroll = true;
            this.LayounPanel.BackColor = System.Drawing.Color.White;
            this.LayounPanel.Controls.Add(this.PersonCreatePanel);
            this.LayounPanel.Controls.Add(this.InfoLabel);
            this.LayounPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayounPanel.Location = new System.Drawing.Point(0, 39);
            this.LayounPanel.Name = "LayounPanel";
            this.LayounPanel.Padding = new System.Windows.Forms.Padding(50, 50, 50, 10);
            this.LayounPanel.Size = new System.Drawing.Size(1387, 999);
            this.LayounPanel.TabIndex = 22;
            // 
            // InfoLabel
            // 
            this.InfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InfoLabel.Location = new System.Drawing.Point(53, 461);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(746, 679);
            this.InfoLabel.TabIndex = 10;
            this.InfoLabel.Text = resources.GetString("InfoLabel.Text");
            // 
            // CreatePersonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LayounPanel);
            this.Controls.Add(this.CreatePersonLabel);
            this.Name = "CreatePersonControl";
            this.Size = new System.Drawing.Size(1387, 1038);
            ((System.ComponentModel.ISupportInitialize)(this.AvatarBox)).EndInit();
            this.PersonCreatePanel.ResumeLayout(false);
            this.PersonCreatePanel.PerformLayout();
            this.LayounPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label CreatePersonLabel;
        private System.Windows.Forms.Label PersonLabel;
        private System.Windows.Forms.PictureBox AvatarBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label AvatarLabel;
        private System.Windows.Forms.Panel PersonCreatePanel;
        private System.Windows.Forms.TextBox MindBox;
        private System.Windows.Forms.TextBox BodyBox;
        private System.Windows.Forms.TextBox LvlBox;
        private System.Windows.Forms.Label SpiritLabel;
        private System.Windows.Forms.Label MindLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label LvlLabel;
        private System.Windows.Forms.Label ClassLabel;
        private System.Windows.Forms.Label BodyLabel;
        private System.Windows.Forms.Label InformationLabel;
        private System.Windows.Forms.Label WorldviewLabel;
        private System.Windows.Forms.TextBox SpiritBox;
        private System.Windows.Forms.FlowLayoutPanel LayounPanel;
        private System.Windows.Forms.ComboBox ClassBox;
        private System.Windows.Forms.ComboBox WorldviewBox;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button RandomButton;
        private System.Windows.Forms.Label InfoLabel;
    }
}
