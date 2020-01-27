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
    public partial class CoinTossForm : Form
    {
        public CoinTossForm()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            //Create a coin object
            Coin myCoin = new Coin();

            //clear the ListBox
            outputListBox.Items.Clear();

            //toss the coin five times
            for (int count = 0; count < 5; count++)
            {
                //Toss the coin
                myCoin.Toss();

                //Display the side that is up
                outputListBox.Items.Add(myCoin.GetSideUp());
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
