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

namespace notebook
{
    public partial class FriendsList : Form
    {
        ListOfFriends listoffriends;
        public FriendsList()
        {
            InitializeComponent();

            comboBox1.Items.Add("за алфавітом");
            comboBox1.Items.Add("за датою корегування");
            comboBox1.SelectedIndex = 0;

            listoffriends = new ListOfFriends();
            listoffriends.GenTestData(20);

            personBindingSource.DataSource = listoffriends.Persons;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            this.Hide();
            mainform.Show();
        }

        private void FriendsList_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dd/MM/yyyy");
            CurrentData.Text = formattedDate;
            CurrentData.ReadOnly = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Save(listoffriends);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Load(listoffriends);
            personBindingSource.DataSource = listoffriends.Persons;
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listoffriends.Persons.Clear();
            personBindingSource.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            personBindingSource.RemoveCurrent();
        }
    }
}
