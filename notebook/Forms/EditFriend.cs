using DocuSign.eSign.Model;
using notebook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notebook.Forms
{
    public partial class EditFriend : Form
    {
        public Person Person;
        ListOfFriends listoffriends;

        public EditFriend(Person person, ListOfFriends friendsList)
        {
            InitializeComponent();
            listoffriends = friendsList;

            Person = person;
            txtFullName.Text = person.FullName;
            dtpDateOfBirth.Text = person.DateOfBirth;
            txtAddress.Text = person.Address;
            txtPhoneNumber.Text = person.PhoneNumber;
            txtPlaceOfWorkOrStudy.Text = person.PlaceOfWorkOrStudy;
            txtPosition.Text = person.Position;
            txtAcquaintance.Text = person.Acquaintance;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Person.FullName = txtFullName.Text;
            Person.DateOfBirth = dtpDateOfBirth.Text;
            Person.Address = txtAddress.Text;
            Person.PhoneNumber = txtPhoneNumber.Text;
            Person.PlaceOfWorkOrStudy = txtPlaceOfWorkOrStudy.Text;
            Person.Position = txtPosition.Text;
            Person.Acquaintance = txtAcquaintance.Text;

            if (!Validator.ValidateNotEmpty(txtFullName.Text))
            {
                MessageBox.Show("Enter full name");
                return;
            }

            if (!Validator.ValidateFullName(txtFullName.Text))
            {
                MessageBox.Show("Enter the data correctly");
                return;
            }

            if (!Validator.ValidateNotEmpty(dtpDateOfBirth.Text))
            {
                MessageBox.Show("Enter date of birth");
                return;
            }

            if (!Validator.ValidateDateOfBirth(dtpDateOfBirth.Text))
            {
                MessageBox.Show("Enter the correct date of birth in DD/MM/YY or DD/MM/YYYY format");
                return;
            }

            if (!Validator.ValidateNotEmpty(txtAddress.Text))
            {
                MessageBox.Show("Enter the address");
                return;
            }

            if (!Validator.ValidateAddress(txtAddress.Text))
            {
                MessageBox.Show("Enter the data correctly");
                return;
            }

            if (!Validator.ValidateNotEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Enter a phone number");
                return;
            }

            if (!Validator.ValidatePhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Enter a valid phone number in the format +38XXXXXXXXXX");
                return;
            }

            if (!Validator.ValidateNotEmpty(txtPlaceOfWorkOrStudy.Text))
            {
                MessageBox.Show("Enter place of work/study");
                return;
            }

            if (!Validator.ValidatePlaceOfWorkOrStudy(txtPlaceOfWorkOrStudy.Text))
            {
                MessageBox.Show("Enter the data correctly");
                return;
            }

            if (!Validator.ValidateNotEmpty(txtPosition.Text))
            {
                MessageBox.Show("Enter the position");
                return;
            }

            if (!Validator.ValidatePosition(txtPosition.Text))
            {
                MessageBox.Show("Enter the data correctly");
                return;
            }

            if (!Validator.ValidateNotEmpty(txtAcquaintance.Text))
            {
                MessageBox.Show("Enter the nature of the acquaintance");
                return;
            }

            if (!Validator.ValidateAcquaintance(txtAcquaintance.Text))
            {
                MessageBox.Show("Enter the data correctly");
                return;
            }

            if (!Validator.ValidateExistingPerson(listoffriends, Person))
            {
                return;
            }

            if (!Validator.ValidateUniquePhoneNumber(listoffriends, Person))
            {
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to change the data?", "Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            DialogResult = DialogResult.OK;
            MessageBox.Show("The data has been successfully edited!");
        }
    }
}
