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
    public partial class EditInfo : Form
    {
        public EditInfo()
        {
            InitializeComponent();
        }

        private void EditInfo_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dd/MM/yyyy");
            CurrentData.Text = formattedDate;
            CurrentData.ReadOnly = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            PersonDetails persondetails = new PersonDetails();
            this.Hide();
            persondetails.Show();
        }
    }
}
