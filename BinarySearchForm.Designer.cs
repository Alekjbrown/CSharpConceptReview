namespace FriendFileForm
{
    partial class BinarySearchForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.getScoresButton = new System.Windows.Forms.Button();
            this.averageScoreTextBox = new System.Windows.Forms.TextBox();
            this.lowScoreTextBox = new System.Windows.Forms.TextBox();
            this.highScoreTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.testScoresListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sortedScoresListBox = new System.Windows.Forms.ListBox();
            this.sortButton = new System.Windows.Forms.Button();
            this.indexOutLabel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(286, 215);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 19;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click_1);
            // 
            // getScoresButton
            // 
            this.getScoresButton.Location = new System.Drawing.Point(123, 215);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(75, 23);
            this.getScoresButton.TabIndex = 18;
            this.getScoresButton.Text = "Get Scores";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click_1);
            // 
            // averageScoreTextBox
            // 
            this.averageScoreTextBox.Enabled = false;
            this.averageScoreTextBox.Location = new System.Drawing.Point(312, 140);
            this.averageScoreTextBox.Name = "averageScoreTextBox";
            this.averageScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageScoreTextBox.TabIndex = 17;
            // 
            // lowScoreTextBox
            // 
            this.lowScoreTextBox.Enabled = false;
            this.lowScoreTextBox.Location = new System.Drawing.Point(312, 88);
            this.lowScoreTextBox.Name = "lowScoreTextBox";
            this.lowScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.lowScoreTextBox.TabIndex = 16;
            // 
            // highScoreTextBox
            // 
            this.highScoreTextBox.Enabled = false;
            this.highScoreTextBox.Location = new System.Drawing.Point(312, 39);
            this.highScoreTextBox.Name = "highScoreTextBox";
            this.highScoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.highScoreTextBox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(194, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Average Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lowest Score:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Highest Score:";
            // 
            // testScoresListBox
            // 
            this.testScoresListBox.FormattingEnabled = true;
            this.testScoresListBox.Location = new System.Drawing.Point(27, 40);
            this.testScoresListBox.Name = "testScoresListBox";
            this.testScoresListBox.Size = new System.Drawing.Size(133, 121);
            this.testScoresListBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Test Scores";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sorted Test Scores";
            // 
            // sortedScoresListBox
            // 
            this.sortedScoresListBox.FormattingEnabled = true;
            this.sortedScoresListBox.Location = new System.Drawing.Point(27, 282);
            this.sortedScoresListBox.Name = "sortedScoresListBox";
            this.sortedScoresListBox.Size = new System.Drawing.Size(133, 121);
            this.sortedScoresListBox.TabIndex = 21;
            this.sortedScoresListBox.SelectedIndexChanged += new System.EventHandler(this.sortedScoresListBox_SelectedIndexChanged);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(205, 215);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 22;
            this.sortButton.Text = "Sort Scores";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // indexOutLabel
            // 
            this.indexOutLabel.Enabled = false;
            this.indexOutLabel.Location = new System.Drawing.Point(234, 321);
            this.indexOutLabel.Name = "indexOutLabel";
            this.indexOutLabel.Size = new System.Drawing.Size(100, 20);
            this.indexOutLabel.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(218, 291);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Array Index of Selected Item:";
            // 
            // BinarySearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 446);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.indexOutLabel);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.sortedScoresListBox);
            this.Controls.Add(this.label5);
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
            this.Name = "BinarySearchForm";
            this.Text = "BinarySearchForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.TextBox averageScoreTextBox;
        private System.Windows.Forms.TextBox lowScoreTextBox;
        private System.Windows.Forms.TextBox highScoreTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox testScoresListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox sortedScoresListBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.TextBox indexOutLabel;
        private System.Windows.Forms.Label label6;
    }
}