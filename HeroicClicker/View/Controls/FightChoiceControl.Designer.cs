
namespace HeroicClicker.View.Controls
{
    partial class FightChoiceControl
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
            this.FightChoiceLabel = new System.Windows.Forms.Label();
            this.LayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LayoutButton = new System.Windows.Forms.FlowLayoutPanel();
            this.FightButton = new System.Windows.Forms.Button();
            this.InformatioButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.ListOfEnemies = new System.Windows.Forms.ListBox();
            this.LayoutPanel.SuspendLayout();
            this.LayoutButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // FightChoiceLabel
            // 
            this.FightChoiceLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FightChoiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FightChoiceLabel.Location = new System.Drawing.Point(0, 0);
            this.FightChoiceLabel.Name = "FightChoiceLabel";
            this.FightChoiceLabel.Size = new System.Drawing.Size(903, 39);
            this.FightChoiceLabel.TabIndex = 0;
            this.FightChoiceLabel.Text = "Выбор битвы";
            this.FightChoiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.AutoScroll = true;
            this.LayoutPanel.Controls.Add(this.LayoutButton);
            this.LayoutPanel.Controls.Add(this.ListOfEnemies);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 39);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(903, 466);
            this.LayoutPanel.TabIndex = 1;
            this.LayoutPanel.WrapContents = false;
            // 
            // LayoutButton
            // 
            this.LayoutButton.AutoSize = true;
            this.LayoutButton.BackColor = System.Drawing.Color.White;
            this.LayoutButton.Controls.Add(this.FightButton);
            this.LayoutButton.Controls.Add(this.InformatioButton);
            this.LayoutButton.Controls.Add(this.ChangeButton);
            this.LayoutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayoutButton.Location = new System.Drawing.Point(100, 30);
            this.LayoutButton.Margin = new System.Windows.Forms.Padding(100, 30, 3, 100);
            this.LayoutButton.Name = "LayoutButton";
            this.LayoutButton.Size = new System.Drawing.Size(552, 212);
            this.LayoutButton.TabIndex = 0;
            // 
            // FightButton
            // 
            this.FightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FightButton.FlatAppearance.BorderSize = 0;
            this.FightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FightButton.Location = new System.Drawing.Point(10, 3);
            this.FightButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(256, 100);
            this.FightButton.TabIndex = 0;
            this.FightButton.Text = "Битва";
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // InformatioButton
            // 
            this.InformatioButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InformatioButton.FlatAppearance.BorderSize = 0;
            this.InformatioButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InformatioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformatioButton.Location = new System.Drawing.Point(286, 3);
            this.InformatioButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.InformatioButton.Name = "InformatioButton";
            this.InformatioButton.Size = new System.Drawing.Size(256, 100);
            this.InformatioButton.TabIndex = 1;
            this.InformatioButton.Text = "Информация";
            this.InformatioButton.UseVisualStyleBackColor = true;
            this.InformatioButton.Click += new System.EventHandler(this.InformatioButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeButton.FlatAppearance.BorderSize = 0;
            this.ChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(10, 109);
            this.ChangeButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(256, 100);
            this.ChangeButton.TabIndex = 2;
            this.ChangeButton.Text = "Поменять";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ListOfEnemies
            // 
            this.ListOfEnemies.BackColor = System.Drawing.Color.White;
            this.ListOfEnemies.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListOfEnemies.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfEnemies.FormattingEnabled = true;
            this.ListOfEnemies.ItemHeight = 31;
            this.ListOfEnemies.Location = new System.Drawing.Point(100, 342);
            this.ListOfEnemies.Margin = new System.Windows.Forms.Padding(100, 0, 50, 100);
            this.ListOfEnemies.MinimumSize = new System.Drawing.Size(505, 345);
            this.ListOfEnemies.Name = "ListOfEnemies";
            this.ListOfEnemies.Size = new System.Drawing.Size(505, 345);
            this.ListOfEnemies.TabIndex = 1;
            // 
            // FightChoiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.FightChoiceLabel);
            this.Name = "FightChoiceControl";
            this.Size = new System.Drawing.Size(903, 505);
            this.LayoutPanel.ResumeLayout(false);
            this.LayoutPanel.PerformLayout();
            this.LayoutButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FightChoiceLabel;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel LayoutButton;
        private System.Windows.Forms.ListBox ListOfEnemies;
        private System.Windows.Forms.Button FightButton;
        private System.Windows.Forms.Button InformatioButton;
        private System.Windows.Forms.Button ChangeButton;
    }
}
