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
    public partial class StudentApplicationForm : Form
    {
        public StudentApplicationForm()
        {
            InitializeComponent();
        }

        private void getHoursButton_Click(object sender, EventArgs e)
        {
            //Variables to hold input
            string name, id, track;

            //get the student's name and id
            name = nameTextBox.Text;
            id = idTextBox.Text;

            //Get student's acedemic track
            if (infoSystemsRadioButton.Checked)
            {
                track = "Information Systems";
            }
            else
            {
                track = "Software Engineering";
            }

            //Create a CompSciStudent object.
            CompSciStudent csStudent = new CompSciStudent(name, id, track);

            //Display the student's required hours
            requiredHoursLabel.Text = csStudent.RequiredHours.ToString("n1");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
