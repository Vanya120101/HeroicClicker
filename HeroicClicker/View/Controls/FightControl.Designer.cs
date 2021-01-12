
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
            this.Images = new System.Windows.Forms.ImageList(this.components);
            this.PersonNameLabel = new System.Windows.Forms.Label();
            this.PersonPanel = new System.Windows.Forms.Panel();
            this.PersonHealth = new System.Windows.Forms.Label();
            this.EnemyPanel = new System.Windows.Forms.Panel();
            this.EnemyNameLabel = new System.Windows.Forms.Label();
            this.HealthEnemy = new System.Windows.Forms.Label();
            this.ActionPanel = new System.Windows.Forms.Panel();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.AvatarPanel.SuspendLayout();
            this.PersonPanel.SuspendLayout();
            this.EnemyPanel.SuspendLayout();
            this.ActionPanel.SuspendLayout();
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
            // Images
            // 
            this.Images.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("Images.ImageStream")));
            this.Images.TransparentColor = System.Drawing.Color.Transparent;
            this.Images.Images.SetKeyName(0, "Evil.png");
            this.Images.Images.SetKeyName(1, "Person.png");
            // 
            // PersonNameLabel
            // 
            this.PersonNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PersonNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonNameLabel.ImageKey = "Person.png";
            this.PersonNameLabel.ImageList = this.Images;
            this.PersonNameLabel.Location = new System.Drawing.Point(0, 0);
            this.PersonNameLabel.Name = "PersonNameLabel";
            this.PersonNameLabel.Size = new System.Drawing.Size(200, 53);
            this.PersonNameLabel.TabIndex = 0;
            this.PersonNameLabel.Text = "User";
            this.PersonNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PersonPanel
            // 
            this.PersonPanel.Controls.Add(this.PersonHealth);
            this.PersonPanel.Controls.Add(this.PersonNameLabel);
            this.PersonPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.PersonPanel.Location = new System.Drawing.Point(0, 0);
            this.PersonPanel.Name = "PersonPanel";
            this.PersonPanel.Size = new System.Drawing.Size(200, 80);
            this.PersonPanel.TabIndex = 0;
            // 
            // PersonHealth
            // 
            this.PersonHealth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PersonHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonHealth.Location = new System.Drawing.Point(0, 53);
            this.PersonHealth.Name = "PersonHealth";
            this.PersonHealth.Size = new System.Drawing.Size(200, 27);
            this.PersonHealth.TabIndex = 1;
            this.PersonHealth.Text = "10/10";
            this.PersonHealth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EnemyPanel
            // 
            this.EnemyPanel.Controls.Add(this.HealthEnemy);
            this.EnemyPanel.Controls.Add(this.EnemyNameLabel);
            this.EnemyPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.EnemyPanel.Location = new System.Drawing.Point(603, 0);
            this.EnemyPanel.Name = "EnemyPanel";
            this.EnemyPanel.Size = new System.Drawing.Size(200, 80);
            this.EnemyPanel.TabIndex = 1;
            // 
            // EnemyNameLabel
            // 
            this.EnemyNameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.EnemyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnemyNameLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EnemyNameLabel.ImageKey = "Person.png";
            this.EnemyNameLabel.ImageList = this.Images;
            this.EnemyNameLabel.Location = new System.Drawing.Point(0, 0);
            this.EnemyNameLabel.Name = "EnemyNameLabel";
            this.EnemyNameLabel.Size = new System.Drawing.Size(200, 53);
            this.EnemyNameLabel.TabIndex = 1;
            this.EnemyNameLabel.Text = "User";
            this.EnemyNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HealthEnemy
            // 
            this.HealthEnemy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HealthEnemy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HealthEnemy.Location = new System.Drawing.Point(0, 53);
            this.HealthEnemy.Name = "HealthEnemy";
            this.HealthEnemy.Size = new System.Drawing.Size(200, 27);
            this.HealthEnemy.TabIndex = 2;
            this.HealthEnemy.Text = "10/10";
            this.HealthEnemy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ActionPanel
            // 
            this.ActionPanel.BackColor = System.Drawing.Color.Maroon;
            this.ActionPanel.Controls.Add(this.ActionLabel);
            this.ActionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ActionPanel.Location = new System.Drawing.Point(50, 370);
            this.ActionPanel.Name = "ActionPanel";
            this.ActionPanel.Size = new System.Drawing.Size(803, 100);
            this.ActionPanel.TabIndex = 2;
            // 
            // ActionLabel
            // 
            this.ActionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ActionLabel.Location = new System.Drawing.Point(0, 0);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(803, 100);
            this.ActionLabel.TabIndex = 0;
            this.ActionLabel.Text = "label1";
            this.ActionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FightControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ActionPanel);
            this.Controls.Add(this.AvatarPanel);
            this.Controls.Add(this.FightLabel);
            this.Name = "FightControl";
            this.Padding = new System.Windows.Forms.Padding(50, 0, 50, 50);
            this.Size = new System.Drawing.Size(903, 520);
            this.AvatarPanel.ResumeLayout(false);
            this.PersonPanel.ResumeLayout(false);
            this.EnemyPanel.ResumeLayout(false);
            this.ActionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label FightLabel;
        private System.Windows.Forms.Panel AvatarPanel;
        private System.Windows.Forms.Panel EnemyPanel;
        private System.Windows.Forms.Label HealthEnemy;
        private System.Windows.Forms.Label EnemyNameLabel;
        private System.Windows.Forms.ImageList Images;
        private System.Windows.Forms.Panel PersonPanel;
        private System.Windows.Forms.Label PersonHealth;
        private System.Windows.Forms.Label PersonNameLabel;
        private System.Windows.Forms.Panel ActionPanel;
        private System.Windows.Forms.Label ActionLabel;
    }
}
