namespace FriendFileForm
{
    partial class AccountSimulatorForm
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
            this.balanceLabel = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.depositTextBox = new System.Windows.Forms.TextBox();
            this.depositButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.withdrawButton = new System.Windows.Forms.Button();
            this.withdrawTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Balance:";
            // 
            // balanceLabel
            // 
            this.balanceLabel.Location = new System.Drawing.Point(205, 45);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.ReadOnly = true;
            this.balanceLabel.Size = new System.Drawing.Size(100, 20);
            this.balanceLabel.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.depositButton);
            this.groupBox1.Controls.Add(this.depositTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(33, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make a Deposit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Amount:";
            // 
            // depositTextBox
            // 
            this.depositTextBox.Location = new System.Drawing.Point(70, 32);
            this.depositTextBox.Name = "depositTextBox";
            this.depositTextBox.Size = new System.Drawing.Size(100, 20);
            this.depositTextBox.TabIndex = 1;
            // 
            // depositButton
            // 
            this.depositButton.Location = new System.Drawing.Point(54, 58);
            this.depositButton.Name = "depositButton";
            this.depositButton.Size = new System.Drawing.Size(75, 23);
            this.depositButton.TabIndex = 2;
            this.depositButton.Text = "Deposit";
            this.depositButton.UseVisualStyleBackColor = true;
            this.depositButton.Click += new System.EventHandler(this.depositButton_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.withdrawButton);
            this.groupBox2.Controls.Add(this.withdrawTextBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(252, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Make a Withdrawal";
            // 
            // withdrawButton
            // 
            this.withdrawButton.Location = new System.Drawing.Point(57, 61);
            this.withdrawButton.Name = "withdrawButton";
            this.withdrawButton.Size = new System.Drawing.Size(75, 23);
            this.withdrawButton.TabIndex = 5;
            this.withdrawButton.Text = "Withdraw";
            this.withdrawButton.UseVisualStyleBackColor = true;
            this.withdrawButton.Click += new System.EventHandler(this.withdrawButton_Click);
            // 
            // withdrawTextBox
            // 
            this.withdrawTextBox.Location = new System.Drawing.Point(73, 35);
            this.withdrawTextBox.Name = "withdrawTextBox";
            this.withdrawTextBox.Size = new System.Drawing.Size(100, 20);
            this.withdrawTextBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Amount:";
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(205, 234);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // AccountSimulatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 298);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.balanceLabel);
            this.Controls.Add(this.label1);
            this.Name = "AccountSimulatorForm";
            this.Text = "Account Simulator";
            this.Load += new System.EventHandler(this.AccountSimulatorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox balanceLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button depositButton;
        private System.Windows.Forms.TextBox depositTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button withdrawButton;
        private System.Windows.Forms.TextBox withdrawTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button closeButton;
    }
}