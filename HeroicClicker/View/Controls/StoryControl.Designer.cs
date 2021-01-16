
namespace HeroicClicker.View.Controls
{
    partial class StoryControl
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
            this.ChoiceStoryPanel = new System.Windows.Forms.Label();
            this.LayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LayoutButton = new System.Windows.Forms.FlowLayoutPanel();
            this.StartStoryButton = new System.Windows.Forms.Button();
            this.ListOfStory = new System.Windows.Forms.ListBox();
            this.LayoutPanel.SuspendLayout();
            this.LayoutButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChoiceStoryPanel
            // 
            this.ChoiceStoryPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ChoiceStoryPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChoiceStoryPanel.Location = new System.Drawing.Point(0, 0);
            this.ChoiceStoryPanel.Name = "ChoiceStoryPanel";
            this.ChoiceStoryPanel.Size = new System.Drawing.Size(903, 39);
            this.ChoiceStoryPanel.TabIndex = 0;
            this.ChoiceStoryPanel.Text = "Выбор истории";
            this.ChoiceStoryPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LayoutPanel
            // 
            this.LayoutPanel.AutoScroll = true;
            this.LayoutPanel.BackColor = System.Drawing.Color.White;
            this.LayoutPanel.Controls.Add(this.LayoutButton);
            this.LayoutPanel.Controls.Add(this.ListOfStory);
            this.LayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.LayoutPanel.Location = new System.Drawing.Point(0, 39);
            this.LayoutPanel.Name = "LayoutPanel";
            this.LayoutPanel.Size = new System.Drawing.Size(903, 481);
            this.LayoutPanel.TabIndex = 1;
            this.LayoutPanel.WrapContents = false;
            // 
            // LayoutButton
            // 
            this.LayoutButton.AutoSize = true;
            this.LayoutButton.BackColor = System.Drawing.Color.White;
            this.LayoutButton.Controls.Add(this.StartStoryButton);
            this.LayoutButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.LayoutButton.Location = new System.Drawing.Point(100, 30);
            this.LayoutButton.Margin = new System.Windows.Forms.Padding(100, 30, 3, 100);
            this.LayoutButton.Name = "LayoutButton";
            this.LayoutButton.Size = new System.Drawing.Size(552, 106);
            this.LayoutButton.TabIndex = 1;
            // 
            // StartStoryButton
            // 
            this.StartStoryButton.AutoSize = true;
            this.StartStoryButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartStoryButton.FlatAppearance.BorderSize = 0;
            this.StartStoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartStoryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StartStoryButton.Location = new System.Drawing.Point(10, 3);
            this.StartStoryButton.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.StartStoryButton.Name = "StartStoryButton";
            this.StartStoryButton.Size = new System.Drawing.Size(256, 100);
            this.StartStoryButton.TabIndex = 0;
            this.StartStoryButton.Text = "Начать";
            this.StartStoryButton.UseVisualStyleBackColor = true;
            this.StartStoryButton.Click += new System.EventHandler(this.StartStoryButton_Click);
            // 
            // ListOfStory
            // 
            this.ListOfStory.BackColor = System.Drawing.Color.White;
            this.ListOfStory.Dock = System.Windows.Forms.DockStyle.Left;
            this.ListOfStory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ListOfStory.FormattingEnabled = true;
            this.ListOfStory.ItemHeight = 31;
            this.ListOfStory.Location = new System.Drawing.Point(100, 236);
            this.ListOfStory.Margin = new System.Windows.Forms.Padding(100, 0, 50, 100);
            this.ListOfStory.MinimumSize = new System.Drawing.Size(505, 345);
            this.ListOfStory.Name = "ListOfStory";
            this.ListOfStory.Size = new System.Drawing.Size(505, 345);
            this.ListOfStory.TabIndex = 2;
            // 
            // StoryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LayoutPanel);
            this.Controls.Add(this.ChoiceStoryPanel);
            this.Name = "StoryControl";
            this.Size = new System.Drawing.Size(903, 520);
            this.LayoutPanel.ResumeLayout(false);
            this.LayoutPanel.PerformLayout();
            this.LayoutButton.ResumeLayout(false);
            this.LayoutButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ChoiceStoryPanel;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanel;
        private System.Windows.Forms.FlowLayoutPanel LayoutButton;
        private System.Windows.Forms.Button StartStoryButton;
        private System.Windows.Forms.ListBox ListOfStory;
    }
}
