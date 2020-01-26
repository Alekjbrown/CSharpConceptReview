namespace FriendFileForm
{
    partial class ArrayProcessForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.highScoreTextBox = new System.Windows.Forms.TextBox();
            this.lowScoreTextBox = new System.Windows.Forms.TextBox();
            this.averageScoreTextBox = new System.Windows.Forms.TextBox();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Test Scores";
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.Location = new System.Drawing.Point(38, 40);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(133, 121);
            this.testScoresListBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Highest Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lowest Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Average Score:";
            // 
            // highScoreTextBox
            // 
            this.highScoreTextBox.Enabled = false;
            this.highScoreTextBox.Location = new System.Drawing.Point(343, 40);
            this.highScoreTextBox.Name = "highScoreTextBox";
            this.highScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.highScoreTextBox.TabIndex = 5;
            // 
            // lowScoreTextBox
            // 
            this.lowScoreTextBox.Enabled = false;
            this.lowScoreTextBox.Location = new System.Drawing.Point(343, 89);
            this.lowScoreTextBox.Name = "lowScoreTextBox";
            this.lowScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.lowScoreTextBox.TabIndex = 6;
            // 
            // averageScoreTextBox
            // 
            this.averageScoreTextBox.Enabled = false;
            this.averageScoreTextBox.Location = new System.Drawing.Point(343, 141);
            this.averageScoreTextBox.Name = "averageScoreTextBox";
            this.averageScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageScoreTextBox.TabIndex = 7;
            // 
            // getScoresButton
            // 
            this.getScoresButton.Location = new System.Drawing.Point(134, 215);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(75, 23);
            this.getScoresButton.TabIndex = 8;
            this.getScoresButton.Text = "Get Scores";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(276, 215);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ArrayProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 270);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.getScoresButton);
            this.Controls.Add(this.averageScoreTextBox);
            this.Controls.Add(this.lowScoreTextBox);
            this.Controls.Add(this.highScoreTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.testScoresListBox);
            this.Controls.Add(this.label1);
            this.Name = "ArrayProcessForm";
            this.Text = "arrayProcessForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox highScoreTextBox;
        private System.Windows.Forms.TextBox lowScoreTextBox;
        private System.Windows.Forms.TextBox averageScoreTextBox;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button closeButton;
    }
}