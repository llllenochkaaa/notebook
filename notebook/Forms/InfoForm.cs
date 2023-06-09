﻿using notebook.Models;
using System;
using System.Windows.Forms;

namespace notebook.Forms
{
    public partial class InfoForm : Form
    {
        public Person Person;
        ListOfFriends listoffriends;

        public InfoForm(Person person, ListOfFriends friendsList)
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

        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
