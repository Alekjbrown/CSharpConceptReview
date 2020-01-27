using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/** this form calls a class Cellphone to create a cellphone object and show its properties **/

namespace FriendFileForm
{
    public partial class CellPhoneTestForm : Form
    {
        public CellPhoneTestForm()
        {
            InitializeComponent();
        }

        //The GetPhoneData method accepts a CellPhone object as an argument
        //it assigns the data entered by the user to the object's properties
        private void GetPhoneData(Cellphone phone)
        {
            //Temporary variable to hold the price.
            decimal price;

            //Get the phone's brand.
            phone.Brand = brandTextBox.Text;

            //Get the phone's model.
            phone.Model = modelTextBox.Text;

            //Get the phone's price.
            if (decimal.TryParse(priceTextBox.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                //Display error message
                MessageBox.Show("Invalid Price");
            }
        }

        private void createObjectButton_Click(object sender, EventArgs e)
        {
            //Create a CellPhone object.
            Cellphone myPhone = new Cellphone();

            //Get the phone data
            GetPhoneData(myPhone);

            //Display the phone data
            brandLabel.Text = myPhone.Brand;
            modelLabel.Text = myPhone.Model;
            priceLabel.Text = myPhone.Price.ToString("c");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
