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
    public partial class Training : Form
    {
        public int count = 1;
        public Training()
        {
            InitializeComponent();

            trainingListBox.Items.Add("Title\tOrganization\tStart Year\tEnd Year");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Educational_Background().Show();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Work_Experience().Show();
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Work_Experience().Show();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            addTraining(GlobalUser._username);

            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void addTraining(string str)
        {
            string newUser = $@"C:\Hackathon\CVGenesis\CV Data\Training\{str}.txt";

            using (StreamWriter sw = System.IO.File.AppendText(newUser))
            {
                string s = $"{count}.{titleTextBox.Text},{OrgTextBox.Text},{dateComboBox1.Text+"-"+monthComboBox1.Text+"-"+yearComboBox1.Text},{dateComboBox2.Text + "-" + monthComboBox2.Text + "-" + yearComboBox2.Text}";
                sw.WriteLine(s);
                count++;
            }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            TrainingData _temp = new TrainingData(titleTextBox.Text,OrgTextBox.Text, dateComboBox1.Text + "-" + monthComboBox1.Text + "-" + yearComboBox1.Text, dateComboBox2.Text + "-" + monthComboBox2.Text + "-" + yearComboBox2.Text);
            trainingListBox.Items.Add(_temp.getTraining());
        }
    }
}
