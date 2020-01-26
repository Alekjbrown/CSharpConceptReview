using System;
using System.IO;
using System.Windows.Forms;

namespace FriendFileForm
{
    public partial class FriendNameForm : Form
    {
        public FriendNameForm()
        {
            InitializeComponent();
        }

        //method for getting file name modularized
        //"out" keyword specefies method will return the string in question to outside the variable
        private void GetFileName(out string selectedFile)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            // add \ before existing \ to ignore the needed \ as an escape character
            openFile.InitialDirectory = "F:\\VSWorkspace\\FriendFileForm\\bin\\Debug";

            //let user pick file if statement tests file selection while remembering selection through the FileName property
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //Open file and ger StreamReader object
                selectedFile = openFile.FileName; //files without specified path with always be in bin\debug
            }
            else
            {
                selectedFile = "";
            }
        }

        private void nameButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("Friend.txt"))
            {
                try
                {
                    //Declare a StreamWriter variable
                    StreamWriter outputFile;

                    //Open existing file and get a StreamWriter object.
                    outputFile = File.AppendText("Friend.txt");

                    //Write the friend's name to the file.
                    outputFile.WriteLine(nameTextBox.Text);

                    //Close the file
                    outputFile.Close();

                    //Let the user know the name was written.
                    MessageBox.Show("The name was written to existing file.");
                }
                catch (Exception ex)
                {
                    //Display an error message.
                    MessageBox.Show(ex.Message);
                }

            }
            else
            {
                try
                {
                    //Declare a StreamWriter variable
                    StreamWriter outputFile;

                    //Create a file and get a StreamWriter object.
                    outputFile = File.CreateText("Friend.txt");

                    //Write the friend's name to the file.
                    outputFile.WriteLine(nameTextBox.Text);

                    //Close the file
                    outputFile.Close();

                    //Let the user know the name was written.
                    MessageBox.Show("The name was written to a new file.");
                }
                catch (Exception ex)
                {
                    //Display an error message.
                    MessageBox.Show(ex.Message);
                }
            }

            //Clear nameTextBox
            nameTextBox.Text = "";

            //Return focus to nameTextBox;
            nameTextBox.Focus();

        }

        private void readNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare a variable to hold item from file
                string friendName;

                //added to call method for getting file name
                string fileName;
                GetFileName(out fileName);

                //Declare a StreamReader variable
                StreamReader inputFile = null;

                /* do not need this as it was moved to its own method: called right above new streamreader^^
                //call new OpenFileDialog
                OpenFileDialog openFile = new OpenFileDialog();
                //let user pick file if statement tests file selection while remembering selection through the FileName property
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    //Open file and ger StreamReader object
                    inputFile = File.OpenText(openFile.FileName); //files without specified path with always be in bin\debug
                }
                else //if cancel show operation canceled and return statement overrides rest of click event handler
                {
                    MessageBox.Show("operation canceled");
                    return;
                }
                */
                if (fileName != "")
                {
                    //set inputFile to open file from GetFileName
                    inputFile = File.OpenText(fileName);

                    while (!inputFile.EndOfStream)
                    {
                        //Read and display the first name until there are no more.
                        friendName = inputFile.ReadLine();

                        /*dont need this when evaluating stream in while loop
                        //check if nexline is empty before print and break loop if it is
                        if (friendName == null)
                        {
                            break;
                        }
                        */

                        MessageBox.Show(friendName);
                    }

                    //close the file
                    inputFile.Close();
                }
                else
                {
                    MessageBox.Show("Operation Canceled");
                    return;
                }
            }
            catch (Exception ex)
            {
                //Display error message
                MessageBox.Show(ex.Message);
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

