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

namespace notebook
{
    public partial class AddFriend : Form
    {
        private List<Person> friendsList = new List<Person>();

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
            Person newFriend = new Person()
            {
                FullName = txtFullName.Text,
                DateOfBirth = dtpDateOfBirth.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
                PlaceOfWorkOrStudy = txtPlaceOfWorkOrStudy.Text,
                Position = txtPosition.Text,
                Acquaintance = txtAcquaintance.Text
            };

            friendsList.Add(newFriend);
            SaveFriendsListToJson();
        }
        private void SaveFriendsListToJson()
        {
            string friendsJson = JsonSerializer.Serialize(friendsList);
            File.WriteAllText("Person.json", friendsJson);
        }

        private void AddFriend_Load(object sender, EventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dd/MM/yyyy");
            CurrentData.Text = formattedDate;
            CurrentData.ReadOnly = true;
        }
    }
}
