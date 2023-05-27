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
            //listoffriends.List();

            personBindingSource.DataSource = listoffriends.Persons;

            Shown += MainForm_Shown;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Save(listoffriends);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Load(listoffriends);
            personBindingSource.DataSource = listoffriends.Persons;
            personBindingSource.ResetBindings(true);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to clear your friends list?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listoffriends.Persons.Clear();
                personBindingSource.ResetBindings(false);
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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to remove the friend from the list?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var selectedPerson = personBindingSource.Current as Person;
                if (selectedPerson != null)
                {
                    listoffriends.Persons.Remove(selectedPerson);
                    personBindingSource.ResetBindings(true);
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

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!listoffriends.IsDirty)
            {
                return;
            }

            var res = MessageBox.Show("Do you want to save changes?", "Confirmation", MessageBoxButtons.YesNoCancel);
            switch (res)
            {
                case DialogResult.Yes:
                    DataAccess.Save(listoffriends);
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
            }
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            List<Person> result = listoffriends.SearchFriends(searchBox.Text.ToLower());
            personBindingSource.DataSource = result;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchBox_TextChanged(null, null);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sortComboBox.Items.Insert(0, "Alphabet");
            sortComboBox.Items.Add("Last edit date");

            sortComboBox.SelectedIndex = 0;
            sortComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            //listoffriends = new ListOfFriends();
            DataAccess.Load(listoffriends);
            personBindingSource.DataSource = listoffriends.Persons;

            friendslist.ClearSelection();
            friendslist.AllowUserToAddRows = false;

            birthdayTextBox.ReadOnly = true;

            UpdateBirthdayMessage();
            //CheckBirthdays(listoffriends);
            //if (friendslist.Rows.Count > 0 && friendslist.Rows[0].IsNewRow)
            //{
            //    friendslist.Rows.RemoveAt(0);
            //}
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedSort = sortComboBox.SelectedItem.ToString();

            if (selectedSort == "Alphabet")
            {
                personBindingSource.DataSource = listoffriends.Persons.OrderBy(p => p.FullName).ToList();
            }
            //else if (selectedSort == "Last edit date")
            //{
            //    personBindingSource.DataSource = listoffriends.Persons.OrderByDescending(p => p.LastAddedDate).ToList();
            //}
        }

        public static string CheckBirthdays(ListOfFriends listOfFriends)
        {
            DateTime today = DateTime.Today;
            StringBuilder sb = new StringBuilder();

            foreach (Person person in listOfFriends.Persons)
            {
                DateTime dateOfBirth;
                if (DateTime.TryParseExact(person.DateOfBirth, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateOfBirth))
                {
                    if (dateOfBirth.Month == today.Month && dateOfBirth.Day == today.Day)
                    {
                        sb.AppendLine($"Happy birthday, {person.FullName}! I wish you happiness, health, and a lot of money!");
                    }
                }
            }

            if (listOfFriends.Persons.Count == 0)
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
    }
}