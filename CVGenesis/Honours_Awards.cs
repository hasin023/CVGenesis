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
    public partial class Honours_Awards : Form
    {
        public int count = 1;
        public Honours_Awards()
        {
            InitializeComponent();

            awardsListBox.Items.Add("Title\tEvent\tIntstitue\tYear");
        }


        public void addAward(string str)
        {
            string newUser = $@"C:\Hackathon\CVGenesis\CV Data\Awards\{str}.txt";

            using (StreamWriter sw = System.IO.File.AppendText(newUser))
            {
                string s = $"{count}.{titleTextBox.Text},{eventTextBox.Text},{awardTextBox.Text},{dateComboBox1.Text + "-" + monthComboBox1.Text + "-" + yearComboBox1.Text}";
                sw.WriteLine(s);
                count++;
            }

        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            addAward(GlobalUser._username);
            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Work_Experience().Show();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Skills().Show();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Awards _temp = new Awards(titleTextBox.Text, eventTextBox.Text, awardTextBox.Text, dateComboBox1.Text + "-" + monthComboBox1.Text + "-" + yearComboBox1.Text);
            awardsListBox.Items.Add(_temp.getAward());
        }
    }
}
