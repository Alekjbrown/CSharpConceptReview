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
    public partial class Form3 : Form
    {

        //Constant field for the contribution rate
        private const decimal CONTRIB_RATE = 0.05m;

        public Form3()
        {
            InitializeComponent();
        }

        //The InputIsValid method converts the user input and stores it in the arguments (passed by reference).
        //If the conversion is successful, the method returns true. otherwise it returns false.
        private bool InputIsValid(ref decimal pay, ref decimal bonus)
        {
            //Flag variable to indicate whether the input is good
            bool inputGood = false;

            //Try to convert both inputs to decimal.
            if (decimal.TryParse(grossPayTextBox.Text, out pay))
            {
                if(decimal.TryParse(bonusTextBox.Text, out bonus))
                {
                    //both inputs are good.
                    inputGood = true;
                }
                else
                {
                    //Display error message for bonus
                    MessageBox.Show("Bonus amount is invalid.");
                }
            }
            else
            {
                //Display an error message for gross pay.
                MessageBox.Show("Gross pay is invalid.");
            }

            //return the result
            return inputGood;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //variables for gross pay, bonus, and contributions
            decimal grossPay = 0m, bonus = 0m, contributions = 0m;

            if(InputIsValid(ref grossPay, ref bonus))
            {
                //Calculate the amount of contribution.
                contributions = (grossPay + bonus) * CONTRIB_RATE;

                //Display the contribution
                contributionLabel.Text = contributions.ToString("c");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            //close the form
            this.Close();
        }
    }
}
