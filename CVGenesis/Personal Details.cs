using CVGenesis.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVGenesis
{
    public partial class Personal_Details : Form
    {
        public Personal_Details()
        {
            InitializeComponent();
        }

        public void addPersonal(string str)
        {
            string newUser = $@"C:\Hackathon\CVGenesis\CV Data\Personal Details\{str}.txt";

            using (StreamWriter writer = new StreamWriter(newUser))
            {
                writer.WriteLine("FirstName:" + firstTextBox.Text);
                writer.WriteLine("LastName:" + lastTextBox.Text);
                writer.WriteLine("Email:" + emailTextBox.Text);
                writer.WriteLine("Phone:" + phoneTextBox.Text);
                writer.WriteLine("Address:" + addressTextBox.Text);
                writer.WriteLine("POB:" + placeOfTextBox.Text);
                writer.WriteLine("Gender:" + genderComboBox.Text);
                writer.WriteLine("Nationality:" + nationComboBox.Text);
                writer.WriteLine("Marital:" + marryComboBox.Text);
                writer.Write("DOB:" + dateComboBox.Text + "-" + monthComboBox.Text + "-" + yearComboBox.Text);
            }
        }

        private void Personal_Details_Load(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            addPersonal(GlobalUser._username);
            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Educational_Background().Show();
        }
    }
}
