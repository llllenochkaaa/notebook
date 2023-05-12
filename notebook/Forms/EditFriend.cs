using DocuSign.eSign.Model;
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

        public EditFriend(Person person)
        {
            InitializeComponent();

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

            DialogResult = DialogResult.OK;
        }
    }
}
