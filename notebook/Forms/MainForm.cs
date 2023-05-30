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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using notebook.Models;
using notebook.Data;
using System.Web.UI.WebControls;
using DocuSign.eSign.Model;
using notebook.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Globalization;

namespace notebook
{
    public partial class MainForm : Form
    {
        ListOfFriends listoffriends;

        public MainForm()
        {
            InitializeComponent();

            listoffriends = new ListOfFriends();
            filteredFriends = new List<Person>();

            personBindingSource.DataSource = listoffriends.Persons;

            Shown += MainForm_Shown;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to save the data?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataAccess.Save(listoffriends);
                MessageBox.Show("Data saved successfully.", "Success", MessageBoxButtons.OK);
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to load previous data? This will overwrite any unsaved changes.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DataAccess.Load(listoffriends);
                personBindingSource.ResetBindings(true);
                personBindingSource.DataSource = listoffriends.Persons;

                UpdateBirthdayMessage();
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to clear your friends list?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                listoffriends.Persons.Clear();

                personBindingSource.Clear();

                personBindingSource.ResetBindings(false);

                UpdateBirthdayMessage();
            }
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFriend form = new AddFriend(listoffriends);
            var result = form.ShowDialog();

            if (result == DialogResult.OK)
            {
                listoffriends.Persons.Add(form.Person);
                personBindingSource.ResetBindings(true);
                listoffriends.IsDirty = true;

                UpdateBirthdayMessage();
            }
        }

        private bool shouldExit;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure that you want to exit the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                shouldExit = true;
                Close();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to remove the friend from the list?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var selectedPerson = personBindingSource.Current as Person;
                if (selectedPerson != null)
                {
                    filteredFriends.Remove(selectedPerson);
                    listoffriends.Persons.Remove(selectedPerson);
                    personBindingSource.ResetBindings(false);

                    listoffriends.IsDirty = true;

                    UpdateBirthdayMessage();
                }
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = friendslist.CurrentRow;

            if (selectedRow == null)
            {
                return;
            }

            var selectedPerson = selectedRow.DataBoundItem as Person;

            if (selectedPerson == null)
            {
                return;
            }

            EditFriend form = new EditFriend(selectedPerson, listoffriends);

            if (form.ShowDialog() == DialogResult.OK)
            {
                personBindingSource.ResetBindings(true);
                listoffriends.IsDirty = true;

                UpdateBirthdayMessage();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (listoffriends.IsDirty)
            {
                var saveChangesResult = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                switch (saveChangesResult)
                {
                    case DialogResult.Yes:
                        DataAccess.Save(listoffriends);
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                }
            }

            if (!shouldExit)
            {
                DialogResult exitResult = MessageBox.Show("Are you sure that you want to exit the program?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (exitResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private List<Person> filteredFriends;

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            filteredFriends = listoffriends.SearchFriends(searchBox.Text.ToLower());
            personBindingSource.DataSource = filteredFriends;
            personBindingSource.ResetBindings(false);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataAccess.Load(listoffriends);
            personBindingSource.ResetBindings(true);
            personBindingSource.DataSource = listoffriends.Persons;

            friendslist.ClearSelection();
            friendslist.AllowUserToAddRows = false;

            birthdayTextBox.ReadOnly = true;

            UpdateBirthdayMessage();
        }

        public static string CheckBirthdays(ListOfFriends listOfFriends)
        {
            DateTime today = DateTime.Today;
            StringBuilder sb = new StringBuilder();
            bool hasBirthdays = false;

            foreach (Person person in listOfFriends.Persons)
            {
                DateTime dateOfBirth;
                if (DateTime.TryParseExact(person.DateOfBirth, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirth))
                {
                    if (dateOfBirth.Month == today.Month && dateOfBirth.Day == today.Day)
                    {
                        sb.AppendLine($"Happy birthday, {person.LastName} {person.Name} {person.Surname}! I wish you happiness, health, and a lot of money!");
                        hasBirthdays = true;
                    }
                }
            }

            if (listOfFriends.Persons.Count == 0 || !hasBirthdays)
            {
                sb.AppendLine("Today is not anyone's birthday. Have a great day!");
            }

            return sb.ToString();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            string birthdayMessage = CheckBirthdays(listoffriends);
            if (!string.IsNullOrEmpty(birthdayMessage))
            {
                Clipboard.SetText(birthdayMessage);
                birthdayTextBox.Text = birthdayMessage;
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            string birthdayMessage = CheckBirthdays(listoffriends);
            if (!string.IsNullOrEmpty(birthdayMessage))
            {
                Clipboard.SetText(birthdayMessage);
                MessageBox.Show("The text was successfully copied to the clipboard!");
            }
        }

        private void UpdateBirthdayMessage()
        {
            string message = CheckBirthdays(listoffriends);
            birthdayTextBox.Text = message;
        }

        private void viewInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selectedRow = friendslist.CurrentRow;

            if (selectedRow == null)
            {
                return;
            }

            var selectedPerson = selectedRow.DataBoundItem as Person;

            if (selectedPerson == null)
            {
                return;
            }

            InfoForm form = new InfoForm(selectedPerson, listoffriends);
            form.Show();
        }

        private void alphabetSortButton_Click(object sender, EventArgs e)
        {
            var sortedList = listoffriends.Persons.OrderBy(p => p.LastName).ToList();
            listoffriends.Persons = sortedList;
            personBindingSource.DataSource = sortedList;
            personBindingSource.ResetBindings(false);
        }

        private void dateSortButton_Click(object sender, EventArgs e)
        {
            var sortedList = listoffriends.Persons.OrderByDescending(p => p.Date).ToList();
            listoffriends.Persons = sortedList;
            personBindingSource.DataSource = sortedList;
            personBindingSource.ResetBindings(false);
        }
    }
}