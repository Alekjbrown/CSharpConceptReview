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
    public partial class startupForm : Form
    {
        public startupForm()
        {
            InitializeComponent();
        }

        private void friendFileButton_Click(object sender, EventArgs e)
        {
            Form friendFile = new FriendNameForm();
            friendFile.Show();
        }

        private void form3Button_Click(object sender, EventArgs e)
        {
            Form payAndBonus = new PayBudgetForm();
            payAndBonus.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void arrayProcessingButton_Click(object sender, EventArgs e)
        {
            Form arrayProcessing = new ArrayProcessForm();
            arrayProcessing.Show();
        }

        private void binarySearchButton_Click(object sender, EventArgs e)
        {
            Form binarySearch = new BinarySearchForm();
            binarySearch.Show();
        }
    }
}
