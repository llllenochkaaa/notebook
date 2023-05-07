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

namespace notebook
{
    public partial class FriendsList : Form
    {
        private List<Person> friendsList = new List<Person>();
        public FriendsList()
        {
            InitializeComponent();
            comboBox1.Items.Add("за алфавітом");
            comboBox1.Items.Add("за датою корегування");
            comboBox1.SelectedIndex = 0;
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

            string jsonString = File.ReadAllText("Person.json");

            friendsList = JsonSerializer.Deserialize<List<Person>>(jsonString);
        }
    }
}
