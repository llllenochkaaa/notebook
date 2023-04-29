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
            string value1 = textBox1.Text;
            string value2 = textBox2.Text;
            string value3 = textBox3.Text;
            string value4 = textBox4.Text;
            string value5 = textBox5.Text;
            string value6 = textBox6.Text;
            string value7 = textBox7.Text;

            if (string.IsNullOrEmpty(value1) || string.IsNullOrEmpty(value2) || string.IsNullOrEmpty(value3) || string.IsNullOrEmpty(value4) || string.IsNullOrEmpty(value5) || string.IsNullOrEmpty(value6) || string.IsNullOrEmpty(value7))
            {
                MessageBox.Show("Ви маєте заповнити усі поля!");
                return;
            }
            MessageBox.Show("Вітаю, Ви успішно додали друга");
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dd/MM/yyyy");
            CurrentData.Text = formattedDate;
            CurrentData.ReadOnly = true;
        }
    }
}
