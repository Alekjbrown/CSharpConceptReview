using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

/** this form uses structures and passing them as arguments and lists **/

namespace FriendFileForm
{

    struct PhoneBookEntry
    {
        public string name;
        public string phone;
    }

    public partial class PhonebookForm : Form
    {

        //Field to hold a list of PhoneBookEntry objects
        private List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();

        public PhonebookForm()
        {
            InitializeComponent();
        }

        //The readfile method read the contents of the PhoneList.txt
        //file and stores it as PhoneBookEntry objects in the phoneList.
        private void ReadFile()
        {
            try
            {
                StreamReader inputFile; //to read the file
                string line; //to hold a line from the file

                //create an instance of the PhoneBookEntry structure
                PhoneBookEntry entry = new PhoneBookEntry();

                //Create delimiter array
                char[] delim = { ',' };

                //open the PhoneList file
                inputFile = File.OpenText("PhoneList.txt");

                //Read the lines from the file.
                while (!inputFile.EndOfStream)
                {
                    //Read a line from the file.
                    line = inputFile.ReadLine();

                    //Tokenize the line
                    string[] tokens = line.Split(delim);

                    //Store the tokens in the entry object.
                    entry.name = tokens[0];
                    entry.phone = tokens[1];

                    //add the entry object to the list.
                    phoneList.Add(entry);
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //The DisplayNames method displays the list of names in the namesListBox control
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name);
            }
        }

        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //get the index of the selected item
            int index = nameListBox.SelectedIndex;

            //Display the corresponding phone number
            phoneLabel.Text = phoneList[index].phone;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PhonebookForm_Load(object sender, EventArgs e)
        {
            //Read the PhoneList.txtfile.
            ReadFile();

            //Display the names.
            DisplayNames();
        }
    }
}
