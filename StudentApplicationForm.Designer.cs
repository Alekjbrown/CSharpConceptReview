namespace FriendFileForm
{
    partial class StudentApplicationForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.getHoursButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.requiredHoursLabel = new System.Windows.Forms.TextBox();
            this.infoSystemsRadioButton = new System.Windows.Forms.RadioButton();
            this.softwareEngineeringRadioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.softwareEngineeringRadioButton);
            this.groupBox1.Controls.Add(this.infoSystemsRadioButton);
            this.groupBox1.Controls.Add(this.requiredHoursLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 250);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Data";
            // 
            // getHoursButton
            // 
            this.getHoursButton.Location = new System.Drawing.Point(58, 282);
            this.getHoursButton.Name = "getHoursButton";
            this.getHoursButton.Size = new System.Drawing.Size(86, 49);
            this.getHoursButton.TabIndex = 1;
            this.getHoursButton.Text = "Get Required Hours";
            this.getHoursButton.UseVisualStyleBackColor = true;
            this.getHoursButton.Click += new System.EventHandler(this.getHoursButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(183, 282);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(86, 49);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(140, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(130, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(140, 81);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(130, 20);
            this.idTextBox.TabIndex = 1;
            // 
            // requiredHoursLabel
            // 
            this.requiredHoursLabel.Location = new System.Drawing.Point(140, 190);
            this.requiredHoursLabel.Name = "requiredHoursLabel";
            this.requiredHoursLabel.ReadOnly = true;
            this.requiredHoursLabel.Size = new System.Drawing.Size(130, 20);
            this.requiredHoursLabel.TabIndex = 2;
            // 
            // infoSystemsRadioButton
            // 
            this.infoSystemsRadioButton.AutoSize = true;
            this.infoSystemsRadioButton.Location = new System.Drawing.Point(140, 122);
            this.infoSystemsRadioButton.Name = "infoSystemsRadioButton";
            this.infoSystemsRadioButton.Size = new System.Drawing.Size(124, 17);
            this.infoSystemsRadioButton.TabIndex = 3;
            this.infoSystemsRadioButton.TabStop = true;
            this.infoSystemsRadioButton.Text = "Informations Systems";
            this.infoSystemsRadioButton.UseVisualStyleBackColor = true;
            // 
            // softwareEngineeringRadioButton
            // 
            this.softwareEngineeringRadioButton.AutoSize = true;
            this.softwareEngineeringRadioButton.Location = new System.Drawing.Point(140, 154);
            this.softwareEngineeringRadioButton.Name = "softwareEngineeringRadioButton";
            this.softwareEngineeringRadioButton.Size = new System.Drawing.Size(130, 17);
            this.softwareEngineeringRadioButton.TabIndex = 4;
            this.softwareEngineeringRadioButton.TabStop = true;
            this.softwareEngineeringRadioButton.Text = "Software Engeneering";
            this.softwareEngineeringRadioButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Acedemic Track:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Required Hours:";
            // 
            // StudentApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 350);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.getHoursButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "StudentApplicationForm";
            this.Text = "Computer Science Student";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button getHoursButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.RadioButton infoSystemsRadioButton;
        private System.Windows.Forms.TextBox requiredHoursLabel;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.RadioButton softwareEngineeringRadioButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}