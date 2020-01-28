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
    public partial class CellPhoneInventoryForm : Form
    {
        //List to hold CellPhone object
        List<Cellphone> phoneList = new List<Cellphone>();

        public CellPhoneInventoryForm()
        {
            InitializeComponent();
        }

        //The GetPhoneData method accepts a CellPhone object as an argument
        //it assigns the data entered by the user to the object's properties
        private void GetPhoneData(Cellphone phone)
        {
            //Temp variable to hold the price.
            decimal price;

            //Get the phone's brand
            phone.Brand = brandTextBox.Text;

            //Get the phone's model
            phone.Model = modelTextBox.Text;

            //get the phone's price
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

        private void addPhoneButton_Click(object sender, EventArgs e)
        {
            //Create a cellphone object
            Cellphone myPhone = new Cellphone();

            //Get the phone data
            GetPhoneData(myPhone);

            //Add the cellphone object to the list
            phoneList.Add(myPhone);

            //Add the cellphone object to the list box
            phoneListBox.Items.Add(myPhone.Brand + " " + myPhone.Model);

            //clear the TextBox Controls
            brandTextBox.Clear();
            modelTextBox.Clear();
            priceTextBox.Clear();

            //Reset the focus
            brandTextBox.Focus();
        }


        private void phoneListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the index of the selected item
            int index = phoneListBox.SelectedIndex;

            //Display the selected item's price
            MessageBox.Show(phoneList[index].Price.ToString("c"));
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
