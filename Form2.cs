using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FriendFileForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void friendFileButton_Click(object sender, EventArgs e)
        {
            Form friendFile = new Form1();
            friendFile.Show();
        }

        private void form3Button_Click(object sender, EventArgs e)
        {
            Form payAndBonus = new Form3();
            payAndBonus.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
