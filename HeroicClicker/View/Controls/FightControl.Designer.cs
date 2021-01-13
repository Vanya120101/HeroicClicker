
namespace HeroicClicker.View.Controls
{
    partial class FightControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FightControl));
            this.FightLabel = new System.Windows.Forms.Label();
            this.AvatarPanel = new System.Windows.Forms.Panel();
            this.EnemyPanel = new System.Windows.Forms.Panel();
            this.SecondFighterHealth = new System.Windows.Forms.Label();
            this.SecondFigtherNameLabel = new System.Windows.Forms.Label();
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.PersonPanel = new System.Windows.Forms.Panel();
            this.FirstFighterHealth = new System.Windows.Forms.Label();
            this.FirstFigtherNameLabel = new System.Windows.Forms.Label();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.FightButton = new System.Windows.Forms.Button();
            this.LogPanel = new System.Windows.Forms.Panel();
            this.LogFightStartLabel = new System.Windows.Forms.Label();
            this.FirstFigherLogLabel = new System.Windows.Forms.Label();
            this.SecondFighterLogLabel = new System.Windows.Forms.Label();
            this.AvatarPanel.SuspendLayout();
            this.EnemyPanel.SuspendLayout();
            this.PersonPanel.SuspendLayout();
            this.ActionPanel.SuspendLayout();
            this.LogPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FightLabel
            // 
            this.FightLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FightLabel.Location = new System.Drawing.Point(50, 0);
            this.FightLabel.Name = "FightLabel";
            this.FightLabel.Size = new System.Drawing.Size(803, 39);
            this.FightLabel.TabIndex = 0;
            this.FightLabel.Text = "Битва";
            this.FightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AvatarPanel
            // 
            this.AvatarPanel.Controls.Add(this.EnemyPanel);
            this.AvatarPanel.Controls.Add(this.PersonPanel);
            this.AvatarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AvatarPanel.Location = new System.Drawing.Point(50, 39);
            this.AvatarPanel.Name = "AvatarPanel";
            this.AvatarPanel.Size = new System.Drawing.Size(803, 80);
            this.AvatarPanel.TabIndex = 1;
            // 
            // EnemyPanel
            // 
            this.EnemyPanel.Controls.Add(this.SecondFighterHealth);
            this.EnemyPanel.Controls.Add(this.SecondFigtherNameLabel);
            this.EnemyPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.EnemyPanel.Location = new System.Drawing.Point(603, 0);
            this.EnemyPanel.Name = "EnemyPanel";
            this.EnemyPanel.Size = new System.Drawing.Size(200, 80);
            this.EnemyPanel.TabIndex = 1;
            // 
            // SecondFighterHealth
            // 
            this.SecondFighterHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondFighterHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondFighterHealth.Location = new System.Drawing.Point(0, 53);
            this.SecondFighterHealth.Name = "SecondFighterHealth";
            this.SecondFighterHealth.Size = new System.Drawing.Size(200, 27);
            this.SecondFighterHealth.TabIndex = 2;
            this.SecondFighterHealth.Text = "10/10";
            this.SecondFighterHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SecondFigtherNameLabel
            // 
            this.SecondFigtherNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.SecondFigtherNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondFigtherNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SecondFigtherNameLabel.ImageKey = "Person.png";
            this.SecondFigtherNameLabel.ImageList = this.Images;
            this.SecondFigtherNameLabel.Location = new System.Drawing.Point(0, 0);
            this.SecondFigtherNameLabel.Name = "SecondFigtherNameLabel";
            this.SecondFigtherNameLabel.Size = new System.Drawing.Size(200, 53);
            this.SecondFigtherNameLabel.TabIndex = 1;
            this.SecondFigtherNameLabel.Text = "User";
            this.SecondFigtherNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Evil.png");
            this.Images.Images.SetKeyName(1, "Person.png");
            // 
            // PersonPanel
            // 
            this.PersonPanel.Controls.Add(this.FirstFighterHealth);
            this.PersonPanel.Controls.Add(this.FirstFigtherNameLabel);
            this.PersonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PersonPanel.Location = new System.Drawing.Point(0, 0);
            this.PersonPanel.Name = "PersonPanel";
            this.PersonPanel.Size = new System.Drawing.Size(200, 80);
            this.PersonPanel.TabIndex = 0;
            // 
            // FirstFighterHealth
            // 
            this.FirstFighterHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstFighterHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstFighterHealth.Location = new System.Drawing.Point(0, 53);
            this.FirstFighterHealth.Name = "FirstFighterHealth";
            this.FirstFighterHealth.Size = new System.Drawing.Size(200, 27);
            this.FirstFighterHealth.TabIndex = 1;
            this.FirstFighterHealth.Text = "10/10";
            this.FirstFighterHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FirstFigtherNameLabel
            // 
            this.FirstFigtherNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.FirstFigtherNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstFigtherNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FirstFigtherNameLabel.ImageKey = "Person.png";
            this.FirstFigtherNameLabel.ImageList = this.Images;
            this.FirstFigtherNameLabel.Location = new System.Drawing.Point(0, 0);
            this.FirstFigtherNameLabel.Name = "FirstFigtherNameLabel";
            this.FirstFigtherNameLabel.Size = new System.Drawing.Size(200, 53);
            this.FirstFigtherNameLabel.TabIndex = 0;
            this.FirstFigtherNameLabel.Text = "User";
            this.FirstFigtherNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ActionPanel
            // 
            this.ActionPanel.BackColor = System.Drawing.Color.Maroon;
            this.ActionPanel.Controls.Add(this.FightButton);
            this.ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionPanel.Location = new System.Drawing.Point(50, 370);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(803, 100);
            this.ActionPanel.TabIndex = 2;
            // 
            // FightButton
            // 
            this.FightButton.AutoSize = true;
            this.FightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FightButton.FlatAppearance.BorderSize = 0;
            this.FightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FightButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FightButton.Location = new System.Drawing.Point(0, 0);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(803, 100);
            this.FightButton.TabIndex = 0;
            this.FightButton.Text = "Старт";
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // LogPanel
            // 
            this.LogPanel.AutoScroll = true;
            this.LogPanel.Controls.Add(this.SecondFighterLogLabel);
            this.LogPanel.Controls.Add(this.FirstFigherLogLabel);
            this.LogPanel.Controls.Add(this.LogFightStartLabel);
            this.LogPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogPanel.Location = new System.Drawing.Point(50, 119);
            this.LogPanel.Name = "LogPanel";
            this.LogPanel.Padding = new System.Windows.Forms.Padding(5);
            this.LogPanel.Size = new System.Drawing.Size(803, 251);
            this.LogPanel.TabIndex = 3;
            // 
            // LogFightStartLabel
            // 
            this.LogFightStartLabel.AutoSize = true;
            this.LogFightStartLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.LogFightStartLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogFightStartLabel.Location = new System.Drawing.Point(361, 0);
            this.LogFightStartLabel.Name = "LogFightStartLabel";
            this.LogFightStartLabel.Size = new System.Drawing.Size(0, 25);
            this.LogFightStartLabel.TabIndex = 0;
            this.LogFightStartLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FirstFigherLogLabel
            // 
            this.FirstFigherLogLabel.AutoEllipsis = true;
            this.FirstFigherLogLabel.AutoSize = true;
            this.FirstFigherLogLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.FirstFigherLogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstFigherLogLabel.Location = new System.Drawing.Point(121, 36);
            this.FirstFigherLogLabel.Name = "FirstFigherLogLabel";
            this.FirstFigherLogLabel.Size = new System.Drawing.Size(0, 25);
            this.FirstFigherLogLabel.TabIndex = 1;
            this.FirstFigherLogLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SecondFighterLogLabel
            // 
            this.SecondFighterLogLabel.AutoEllipsis = true;
            this.SecondFighterLogLabel.AutoSize = true;
            this.SecondFighterLogLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(250)))));
            this.SecondFighterLogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondFighterLogLabel.Location = new System.Drawing.Point(616, 36);
            this.SecondFighterLogLabel.Name = "SecondFighterLogLabel";
            this.SecondFighterLogLabel.Size = new System.Drawing.Size(0, 25);
            this.SecondFighterLogLabel.TabIndex = 2;
            this.SecondFighterLogLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LogPanel);
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.AvatarPanel);
            this.Controls.Add(this.FightLabel);
            this.Name = "FightControl";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 50);
            this.Size = new System.Drawing.Size(903, 520);
            this.AvatarPanel.ResumeLayout(false);
            this.EnemyPanel.ResumeLayout(false);
            this.PersonPanel.ResumeLayout(false);
            this.ActionPanel.ResumeLayout(false);
            this.ActionPanel.PerformLayout();
            this.LogPanel.ResumeLayout(false);
            this.LogPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FightLabel;
        private System.Windows.Forms.Panel AvatarPanel;
        private System.Windows.Forms.Panel EnemyPanel;
        private System.Windows.Forms.Label SecondFighterHealth;
        private System.Windows.Forms.Label SecondFigtherNameLabel;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.Panel PersonPanel;
        private System.Windows.Forms.Label FirstFighterHealth;
        private System.Windows.Forms.Label FirstFigtherNameLabel;
        private System.Windows.Forms.Panel ActionPanel;
        private System.Windows.Forms.Button FightButton;
        private System.Windows.Forms.Panel LogPanel;
        private System.Windows.Forms.Label LogFightStartLabel;
        private System.Windows.Forms.Label SecondFighterLogLabel;
        private System.Windows.Forms.Label FirstFigherLogLabel;
    }
}
