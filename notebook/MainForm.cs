using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace notebook
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dd/MM/yyyy");
            CurrentData.Text = formattedDate;
            CurrentData.ReadOnly = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            StartForm startform = new StartForm();
            this.Hide();
            startform.Show();
        }

        private void AddFriendButton_Click(object sender, EventArgs e)
        {
            AddFriend addfriend = new AddFriend();
            this.Hide();
            addfriend.Show();
        }
    }
}
