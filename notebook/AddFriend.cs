using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace notebook
{
    public partial class AddFriend : Form
    {
        public AddFriend()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            MainForm mainform = new MainForm();
            this.Hide();
            mainform.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Вітаю, Ви успішно додали друга");
        }
    }
}
