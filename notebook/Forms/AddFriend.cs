using System.IO;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Asn1.X509.SigI;
using notebook.Models;

namespace notebook
{
    public partial class AddFriend : Form
    {
        public Person Person;
        ListOfFriends listoffriends;

        public AddFriend(ListOfFriends friendsList)
        {
            InitializeComponent();
            this.listoffriends = friendsList;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void okButton_Click(object sender, EventArgs e)
        {

            Person = new Person
            {
                LastName = txtLastName.Text,
                Name = txtName.Text,
                Surname = txtSurname.Text,
                DateOfBirth = dtpDateOfBirth.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
                PlaceOfWorkOrStudy = txtPlaceOfWorkOrStudy.Text,
                Position = txtPosition.Text,
                Acquaintance = txtAcquaintance.Text,
                //LastAddedDate = DateTime.Now
            };

            Person.Date = DateTime.Now;

            if (!Validator.ValidateNotEmpty(txtLastName.Text))
            {
                MessageBox.Show("Enter last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateLastName(txtLastName.Text))
            {
                MessageBox.Show("Enter the data correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateNotEmpty(txtName.Text))
            {
                MessageBox.Show("Enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateName(txtName.Text))
            {
                MessageBox.Show("Enter the data correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateNotEmpty(txtSurname.Text))
            {
                MessageBox.Show("Enter surname", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateSurname(txtSurname.Text))
            {
                MessageBox.Show("Enter the data correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Enter the data correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Enter the data correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateNotEmpty(txtPosition.Text))
            {
                MessageBox.Show("Enter the position", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidatePosition(txtPosition.Text))
            {
                MessageBox.Show("Enter the data correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateNotEmpty(txtAcquaintance.Text))
            {
                MessageBox.Show("Enter the nature of the acquaintance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!Validator.ValidateAcquaintance(txtAcquaintance.Text))
            {
                MessageBox.Show("Enter the data correctly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            this.DialogResult = DialogResult.OK;
            MessageBox.Show("A new friend has been added!");
        }
    }
}