namespace FriendFileForm
{
    partial class Form1
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.nameButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.readNameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a friend\'s name: ";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(177, 90);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(72, 142);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 2;
            this.nameButton.Text = "Write Name";
            this.nameButton.UseVisualStyleBackColor = true;
            this.nameButton.Click += new System.EventHandler(this.nameButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(191, 142);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // readNameButton
            // 
            this.readNameButton.Location = new System.Drawing.Point(72, 181);
            this.readNameButton.Name = "readNameButton";
            this.readNameButton.Size = new System.Drawing.Size(75, 42);
            this.readNameButton.TabIndex = 4;
            this.readNameButton.Text = "Read Names";
            this.readNameButton.UseVisualStyleBackColor = true;
            this.readNameButton.Click += new System.EventHandler(this.readNameButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.nameButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 375);
            this.Controls.Add(this.readNameButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Friend File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button readNameButton;
    }
}

