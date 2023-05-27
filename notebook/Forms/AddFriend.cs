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
                FullName = txtFullName.Text,
                DateOfBirth = dtpDateOfBirth.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
                PlaceOfWorkOrStudy = txtPlaceOfWorkOrStudy.Text,
                Position = txtPosition.Text,
                Acquaintance = txtAcquaintance.Text,
                //LastAddedDate = DateTime.Now
            };

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

            this.DialogResult = DialogResult.OK;
            MessageBox.Show("A new friend has been added!");
        }
    }
}