
namespace HeroicClicker.View.Controls
{
    partial class AchievementControl
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
            this.AchievementLabel = new System.Windows.Forms.Label();
            this.LayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.AchievementList = new System.Windows.Forms.ListBox();
            this.LayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AchievementLabel
            // 
            this.AchievementLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.AchievementLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AchievementLabel.Location = new System.Drawing.Point(0, 0);
            this.AchievementLabel.Name = "AchievementLabel";
            this.AchievementLabel.Size = new System.Drawing.Size(903, 40);
            this.AchievementLabel.TabIndex = 0;
            this.AchievementLabel.Text = "Достижения";
            this.AchievementLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.Controls.Add(this.AchievementList);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 40);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(903, 480);
            this.LayoutPanel.TabIndex = 1;
            // 
            // AchievementList
            // 
            this.AchievementList.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AchievementList.FormattingEnabled = true;
            this.AchievementList.ItemHeight = 38;
            this.AchievementList.Location = new System.Drawing.Point(50, 50);
            this.AchievementList.Margin = new System.Windows.Forms.Padding(50, 50, 3, 3);
            this.AchievementList.Name = "AchievementList";
            this.AchievementList.Size = new System.Drawing.Size(778, 384);
            this.AchievementList.TabIndex = 0;
            // 
            // AchievementControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.AchievementLabel);
            this.Name = "AchievementControl";
            this.Size = new System.Drawing.Size(903, 520);
            this.LayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label AchievementLabel;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel;
        private System.Windows.Forms.ListBox AchievementList;
    }
}
