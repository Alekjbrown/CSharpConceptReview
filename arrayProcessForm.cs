using System;
using System.IO;
using System.Windows.Forms;

namespace FriendFileForm
{
    public partial class ArrayProcessForm : Form
    {
        public ArrayProcessForm()
        {
            InitializeComponent();
        }

        //The Average method accepts an int array argument and returns
        //the Average of the values in the array.
        private double Average(int[] iArray)
        {
            int total = 0; //Accumulatr, initialized to 0
            double average; //To hold the average

            //Step through the array, adding each element to the accumulator.
            for (int index = 0; index < iArray.Length; index++)
            {
                total += iArray[index];
            }

            //calculate the average
            average = (double)total / iArray.Length;

            //Return the average
            return average;
        }

        //The Highest method accepts an int array argument and returns
        // the highest value in that array.
        private int Highest(int[] iArray)
        {
            //Declare a variable to hold the highest value, and 
            //Initialize it with the first value in the array
            int highest = iArray[0];

            //Step through the rest of the array, beginning at element 1
            //When a value greater than highest is found, assign that value to highest.
            for (int index = 1; index < iArray.Length; index++)
            {
                if (iArray[index] > highest)
                {
                    highest = iArray[index];
                }
            }

            //Return the Highest Value.
            return highest;
        }

        //The Lowest method accepts an int array argument and returns
        //the lowest value in that array
        private int Lowest(int[] iArray)
        {
            //Declare a variable to hold the lowest value, and initialize
            //it with the first value in the array.
            int lowest = iArray[0];

            //Step through the rest of the array beginning at element 1
            //when a value less than lowest is found, assign that value to lowest.
            for (int index = 1; index < iArray.Length; index++)
            {
                if (iArray[index] < lowest)
                {
                    lowest = iArray[index];
                }
            }

            //Return the lowest value.
            return lowest;
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

        private void getScoresButton_Click(object sender, EventArgs e)
        {

            try
            {
                //Local variables
                const int SIZE = 5; //number of tests
                int[] scores = new int[SIZE]; //Array of test scores
                int index = 0; //Loop counter
                int highestScore; //To hold the highest score
                int lowestScore; //To hold the lowest score
                double averageScore; //To hold the average score
                string fileName; //To hold the file name for input
                StreamReader inputFile; //For file input

                //Open the file and get a StreamReader object.
                GetFileName(out fileName);

                if(fileName == "")
                {
                    MessageBox.Show("Operation Canceled");
                    return;
                }

                inputFile = File.OpenText(fileName);


                //Read the test scores into the array.
                while (!inputFile.EndOfStream && index < scores.Length)
                {
                    scores[index] = int.Parse(inputFile.ReadLine());
                    index++;
                }

                //Close the file
                inputFile.Close();

                //Display the test scores
                foreach (int value in scores)
                {
                    testScoresListBox.Items.Add(value);
                }

                //Get the highest, lowest, and avarage scores.(from methods written above)
                highestScore = Highest(scores);
                lowestScore = Lowest(scores);
                averageScore = Average(scores);

                //Display the values
                highScoreTextBox.Text = highestScore.ToString();
                lowScoreTextBox.Text = lowestScore.ToString();
                averageScoreTextBox.Text = averageScore.ToString("n1");
            }
            catch (Exception ex)
            {
                //Display an error message
                MessageBox.Show(ex.Message);
            }


        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
