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
    public partial class PersonDetails : Form
    {
        public PersonDetails()
        {
            InitializeComponent();
        }

        private void PersonDetails_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dd/MM/yyyy");
            CurrentData.Text = formattedDate;
            CurrentData.ReadOnly = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FriendsList friendslist = new FriendsList();
            this.Hide();
            friendslist.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите удалить элемент?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

            }
            else
            {

            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            EditInfo editinfo = new EditInfo();
            this.Hide();
            editinfo.Show();
        }
    }
}
