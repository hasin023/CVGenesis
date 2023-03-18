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
    public partial class Work_Experience : Form
    {
        public int count = 1;
        public Work_Experience()
        {
            InitializeComponent();

            workExpListBox.Items.Add("Occupation\tEmployer\tCountry\tStart Year\tEnd Year");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GlobalUser._username == "Guest")
            {
                if (occupationTextBox.Text == "" || employeerTextBox.Text == "" || countryComboBox.Text == "")
                {
                    MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    this.Hide();
                    new Honours_Awards().Show();
                }
            }
            else
            {
                this.Hide();
                new Honours_Awards().Show();
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Training().Show();
        }

        public void addWork(string str)
        {
            string newUser = $@"C:\Hackathon\CVGenesis\CV Data\WorkExp\{str}.txt";

            using (StreamWriter sw = System.IO.File.AppendText(newUser))
            {
                string s = $"{count}.{occupationTextBox.Text},{employeerTextBox.Text},{countryComboBox.Text},{dateComboBox1.Text + "-" + monthComboBox1.Text + "-" + yearComboBox1.Text},{dateComboBox2.Text + "-" + monthComboBox2.Text + "-" + yearComboBox2.Text}";
                sw.WriteLine(s);
                count++;
            }

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            addWork(GlobalUser._username);

            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            WorkExp _temp = new WorkExp(occupationTextBox.Text, employeerTextBox.Text, countryComboBox.Text, dateComboBox1.Text + "-" + monthComboBox1.Text + "-" + yearComboBox1.Text, dateComboBox2.Text + "-" + monthComboBox2.Text + "-" + yearComboBox2.Text);
            workExpListBox.Items.Add(_temp.getWork());
        }
    }
}
