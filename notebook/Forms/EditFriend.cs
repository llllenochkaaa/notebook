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
            txtLastName.Text = person.LastName;
            txtName.Text = person.Name;
            txtSurname.Text = person.Surname;
            dtpDateOfBirth.Text = person.DateOfBirth;
            txtAddress.Text = person.Address;
            txtPhoneNumber.Text = person.PhoneNumber;
            txtPlaceOfWorkOrStudy.Text = person.PlaceOfWorkOrStudy;
            txtPosition.Text = person.Position;
            txtAcquaintance.Text = person.Acquaintance;
        }

        private bool isEditingCancelled = false;

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to cancel editing this person?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                isEditingCancelled = true;
                this.DialogResult = DialogResult.Cancel;
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Person.LastName = txtLastName.Text;
            Person.Name = txtName.Text;
            Person.Surname = txtSurname.Text;
            Person.DateOfBirth = dtpDateOfBirth.Text;
            Person.Address = txtAddress.Text;
            Person.PhoneNumber = txtPhoneNumber.Text;
            Person.PlaceOfWorkOrStudy = txtPlaceOfWorkOrStudy.Text;
            Person.Position = txtPosition.Text;
            Person.Acquaintance = txtAcquaintance.Text;

            Person.Date = DateTime.Now;

            if (!Validator.ValidateNotEmpty(txtLastName.Text))
            {
                MessageBox.Show("Enter last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateLastName(txtLastName.Text))
            {
                MessageBox.Show("This field cannot contain numbers and cannot be longer than 50 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateNotEmpty(txtName.Text))
            {
                MessageBox.Show("Enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateName(txtName.Text))
            {
                MessageBox.Show("This field cannot contain numbers and cannot be longer than 50 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateNotEmpty(txtSurname.Text))
            {
                MessageBox.Show("Enter surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateSurname(txtSurname.Text))
            {
                MessageBox.Show("This field cannot contain numbers and cannot be longer than 50 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateNotEmpty(dtpDateOfBirth.Text))
            {
                MessageBox.Show("Enter date of birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateDateOfBirth(dtpDateOfBirth.Text))
            {
                MessageBox.Show("Enter the correct date of birth in DD/MM/YY or DD/MM/YYYY format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateNotEmpty(txtAddress.Text))
            {
                MessageBox.Show("Enter the address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateAddress(txtAddress.Text))
            {
                MessageBox.Show("This field cannot be longer than 100 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateNotEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Enter a phone number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidatePhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Enter a valid phone number in the format +38XXXXXXXXXX", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateNotEmpty(txtPlaceOfWorkOrStudy.Text))
            {
                MessageBox.Show("Enter place of work/study", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidatePlaceOfWorkOrStudy(txtPlaceOfWorkOrStudy.Text))
            {
                MessageBox.Show("This field cannot be longer than 100 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateNotEmpty(txtPosition.Text))
            {
                MessageBox.Show("Enter the position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidatePosition(txtPosition.Text))
            {
                MessageBox.Show("This field cannot be longer than 100 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateNotEmpty(txtAcquaintance.Text))
            {
                MessageBox.Show("Enter the nature of the acquaintance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateAcquaintance(txtAcquaintance.Text))
            {
                MessageBox.Show("This field cannot be longer than 100 letters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            DialogResult confirmationResult = MessageBox.Show("Are you sure you want to save the changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmationResult == DialogResult.No)
            {
                return;
            }

            isSaveConfirmed = true;

            DialogResult = DialogResult.OK;
            MessageBox.Show("The data has been successfully edited!", "Success", MessageBoxButtons.OK);
        }

        private bool isSaveConfirmed = false;

        private void EditFriend_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isEditingCancelled)
            {
                return;
            }

            if (isSaveConfirmed)
            {
                Person.Date = DateTime.Now;
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure that you want to cancel editing this person?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}