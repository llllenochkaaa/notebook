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

namespace notebook
{
    public partial class MainForm : Form
    {
        ListOfFriends listoffriends;

        public MainForm()
        {
            InitializeComponent();

            listoffriends = new ListOfFriends();
            listoffriends.List();

            personBindingSource.DataSource = listoffriends.Persons;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Save(listoffriends);
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataAccess.Load(listoffriends);
            personBindingSource.ResetBindings(true);
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listoffriends.Persons.Clear();
            personBindingSource.ResetBindings(true);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddFriend form = new AddFriend();
            var result = form.ShowDialog();
            if (result == DialogResult.OK)
            {
                listoffriends.Persons.Add(form.Person);
                personBindingSource.ResetBindings(true);
            }

            friendslist.CurrentCell = friendslist.Rows[friendslist.Rows.Count - 1].Cells[0];
        }

        //private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        //private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    personBindingSource.RemoveCurrent();
        //}

        //private void editToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    var selectedRow = friendslist.CurrentRow;

        //    if (selectedRow == null)
        //    {
        //        return;
        //    }

        //    var selectedPerson = selectedRow.DataBoundItem as Person;

        //    if (selectedPerson == null)
        //    {
        //        return;
        //    }

        //    EditFriend form = new EditFriend(selectedPerson);

        //    if (form.ShowDialog() == DialogResult.OK)
        //    {
        //        personBindingSource.ResetBindings(true);
        //    }


        //}
    }
}
