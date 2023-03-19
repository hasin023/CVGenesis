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
    public partial class Skills : Form
    {
        public Skills()
        {
            InitializeComponent();

            skillListBox.Items.Add("Language\t\tDigital\tOther");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void addOther_Click(object sender, EventArgs e)
        {
            SkillData _temp = new SkillData(langComboBox.Text, digitalComboBox.Text, otherSkillTextBox.Text);
            skillListBox.Items.Add(_temp.getSkill());
        }

        public void addSkill(string str)
        {
            string newUser = $@"C:\Hackathon\CVGenesis\CV Data\Skills\{str}.txt";

            using (StreamWriter sw = System.IO.File.AppendText(newUser))
            {
                string s = $"{langComboBox.Text},{digitalComboBox.Text},{otherSkillTextBox.Text}";
                sw.WriteLine(s);
            }

        }
        private void saveOther_Click(object sender, EventArgs e)
        {
            addSkill(GlobalUser._username);
            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void skipButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Honours_Awards().Show();

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (GlobalUser._username == "Guest")
            {
                if (langComboBox.Text == "" || digitalComboBox.Text == "" || otherSkillTextBox.Text == "")
                {
                    MessageBox.Show("Invalid Input", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    this.Hide();
                    new Preview().Show();
                }
            }
            else
            {
                this.Hide();
                new Preview().Show();
            }

        }
    }
}
