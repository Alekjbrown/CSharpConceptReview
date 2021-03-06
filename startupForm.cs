﻿using System;
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

        private void passwordValidationButton_Click(object sender, EventArgs e)
        {
            Form passwordValidation = new PasswordValidationForm();
            passwordValidation.Show();
        }

        private void formatTelephoneButton_Click(object sender, EventArgs e)
        {
            Form formatTelephone = new FormatTelephoneForm();
            formatTelephone.Show();
        }

        private void telephoneBookButton_Click(object sender, EventArgs e)
        {
            Form phonebookForm = new PhonebookForm();
            phonebookForm.Show();
        }

        private void colorSpectrumButton_Click(object sender, EventArgs e)
        {
            Form colorSpectrum = new ColorSpectrumForm();
            colorSpectrum.Show();
        }

        private void coinTossButton_Click(object sender, EventArgs e)
        {
            Form coinToss = new CoinTossForm();
            coinToss.Show();
        }

        private void cellPhoneTestButton_Click(object sender, EventArgs e)
        {
            Form cellTest = new CellPhoneTestForm();
            cellTest.Show();
        }

        private void accountSimulatorButton_Click(object sender, EventArgs e)
        {
            AccountSimulatorForm accountSim = new AccountSimulatorForm();
            accountSim.ShowDialog();
        }

        private void polymorphismButton_Click(object sender, EventArgs e)
        {
            PolymorphismDemo polyDemo = new PolymorphismDemo();
            polyDemo.ShowDialog();
        }

        private void studentApplicationButton_Click(object sender, EventArgs e)
        {
            StudentApplicationForm studentApp = new StudentApplicationForm();
            studentApp.ShowDialog();
        }

        private void cellPhoneInventoryButton_Click(object sender, EventArgs e)
        {
            CellPhoneInventoryForm cellPhone = new CellPhoneInventoryForm();
            cellPhone.ShowDialog();
        }
    }
}
