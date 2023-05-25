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
        //private ListOfFriends listoffriends;

        public AddFriend(/*ListOfFriends listoffriends)*/)
        {
            InitializeComponent();
            //this.listoffriends = listoffriends;
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
                MessageBox.Show("Введіть ПІБ");
                return;
            }

            if (!Validator.ValidateFullName(txtFullName.Text))
            {
                MessageBox.Show("Введіть ПІБ коректно");
                return;
            }

            if (!Validator.ValidateNotEmpty(dtpDateOfBirth.Text))
            {
                MessageBox.Show("Введіть дату народження");
                return;
            }

            if (!Validator.ValidateDateOfBirth(dtpDateOfBirth.Text))
            {
                MessageBox.Show("Введіть коректну дату нарождения у форматі ДД/ММ/РР или ДД/ММ/РРРР");
                return;
            }

            if (!Validator.ValidateNotEmpty(txtAddress.Text))
            {
                MessageBox.Show("Введіть адрес");
                return;
            }

            if (!Validator.ValidateAddress(txtAddress.Text))
            {
                MessageBox.Show("Введіть коректні дані");
                return;
            }

            if (!Validator.ValidateNotEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Введіть номер телефону");
                return;
            }

            if (!Validator.ValidatePhoneNumber(txtPhoneNumber.Text))
            {
                MessageBox.Show("Введіть коректний номер телефону у форматі +38 (XXX) XXX-XX-XX");
                return;
            }

            if (!Validator.ValidateNotEmpty(txtPlaceOfWorkOrStudy.Text))
            {
                MessageBox.Show("Введіть місце роботи/навчання");
                return;
            }

            if (!Validator.ValidatePlaceOfWorkOrStudy(txtPlaceOfWorkOrStudy.Text))
            {
                MessageBox.Show("Введіть коректні дані");
                return;
            }

            if (!Validator.ValidateNotEmpty(txtPosition.Text))
            {
                MessageBox.Show("Введіть посаду");
                return;
            }

            if (!Validator.ValidatePosition(txtPosition.Text))
            {
                MessageBox.Show("Введіть коректні дані");
                return;
            }

            if (!Validator.ValidateNotEmpty(txtAcquaintance.Text))
            {
                MessageBox.Show("Введіть характер знайомства");
                return;
            }

            if (!Validator.ValidateAcquaintance(txtAcquaintance.Text))
            {
                MessageBox.Show("Введіть коректні дані");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
