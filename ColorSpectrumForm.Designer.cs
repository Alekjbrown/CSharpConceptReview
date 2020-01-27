namespace FriendFileForm
{
    partial class ColorSpectrumForm
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
            this.redLabel = new System.Windows.Forms.TextBox();
            this.orangeLabel = new System.Windows.Forms.TextBox();
            this.yellowLabel = new System.Windows.Forms.TextBox();
            this.greenLabel = new System.Windows.Forms.TextBox();
            this.blueLabel = new System.Windows.Forms.TextBox();
            this.indigoLabel = new System.Windows.Forms.TextBox();
            this.violetLabel = new System.Windows.Forms.TextBox();
            this.colorLabel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // redLabel
            // 
            this.redLabel.BackColor = System.Drawing.Color.Red;
            this.redLabel.Location = new System.Drawing.Point(11, 25);
            this.redLabel.Name = "redLabel";
            this.redLabel.ReadOnly = true;
            this.redLabel.Size = new System.Drawing.Size(100, 20);
            this.redLabel.TabIndex = 0;
            this.redLabel.Click += new System.EventHandler(this.redLabel_Click);
            // 
            // orangeLabel
            // 
            this.orangeLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.orangeLabel.Location = new System.Drawing.Point(117, 25);
            this.orangeLabel.Name = "orangeLabel";
            this.orangeLabel.ReadOnly = true;
            this.orangeLabel.Size = new System.Drawing.Size(100, 20);
            this.orangeLabel.TabIndex = 1;
            this.orangeLabel.Click += new System.EventHandler(this.orangeLabel_Click);
            // 
            // yellowLabel
            // 
            this.yellowLabel.BackColor = System.Drawing.Color.Yellow;
            this.yellowLabel.Location = new System.Drawing.Point(223, 25);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.ReadOnly = true;
            this.yellowLabel.Size = new System.Drawing.Size(100, 20);
            this.yellowLabel.TabIndex = 2;
            this.yellowLabel.Click += new System.EventHandler(this.yellowLabel_Click);
            // 
            // greenLabel
            // 
            this.greenLabel.BackColor = System.Drawing.Color.Lime;
            this.greenLabel.Location = new System.Drawing.Point(329, 25);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.ReadOnly = true;
            this.greenLabel.Size = new System.Drawing.Size(100, 20);
            this.greenLabel.TabIndex = 3;
            this.greenLabel.Click += new System.EventHandler(this.greenLabel_Click);
            // 
            // blueLabel
            // 
            this.blueLabel.BackColor = System.Drawing.Color.Aqua;
            this.blueLabel.Location = new System.Drawing.Point(435, 25);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.ReadOnly = true;
            this.blueLabel.Size = new System.Drawing.Size(100, 20);
            this.blueLabel.TabIndex = 4;
            this.blueLabel.Click += new System.EventHandler(this.blueLabel_Click);
            // 
            // indigoLabel
            // 
            this.indigoLabel.BackColor = System.Drawing.Color.Blue;
            this.indigoLabel.Location = new System.Drawing.Point(541, 25);
            this.indigoLabel.Name = "indigoLabel";
            this.indigoLabel.ReadOnly = true;
            this.indigoLabel.Size = new System.Drawing.Size(100, 20);
            this.indigoLabel.TabIndex = 5;
            this.indigoLabel.Click += new System.EventHandler(this.indigoLabel_Click);
            // 
            // violetLabel
            // 
            this.violetLabel.BackColor = System.Drawing.Color.Fuchsia;
            this.violetLabel.Location = new System.Drawing.Point(647, 25);
            this.violetLabel.Name = "violetLabel";
            this.violetLabel.ReadOnly = true;
            this.violetLabel.Size = new System.Drawing.Size(100, 20);
            this.violetLabel.TabIndex = 6;
            this.violetLabel.Click += new System.EventHandler(this.violetLabel_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.Location = new System.Drawing.Point(329, 51);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.ReadOnly = true;
            this.colorLabel.Size = new System.Drawing.Size(100, 20);
            this.colorLabel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select a color of the spectrum";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(329, 77);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(100, 23);
            this.closeButton.TabIndex = 9;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // ColorSpectrumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 106);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.violetLabel);
            this.Controls.Add(this.indigoLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.orangeLabel);
            this.Controls.Add(this.redLabel);
            this.Name = "ColorSpectrumForm";
            this.Text = "Color Spectrum";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox redLabel;
        private System.Windows.Forms.TextBox orangeLabel;
        private System.Windows.Forms.TextBox yellowLabel;
        private System.Windows.Forms.TextBox greenLabel;
        private System.Windows.Forms.TextBox blueLabel;
        private System.Windows.Forms.TextBox indigoLabel;
        private System.Windows.Forms.TextBox violetLabel;
        private System.Windows.Forms.TextBox colorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeButton;
    }
}