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

namespace CVGenesis.Properties
{
    public partial class signup : Form
    {
        public signup()
        {
            InitializeComponent();
        }

        public void regUser(string str)
        {
            string newUser = $@"C:\Hackathon\CVGenesis\Users\{str}.txt";

            GlobalUser._username = userTextBox.Text;

            using (StreamWriter writer = new StreamWriter(newUser))
            {
                writer.WriteLine("username:" + userTextBox.Text);
                if (passTextBox.Text.Count() >= 6)
                {
                    if (passTextBox.Text == conPassTextBox.Text)
                    {
                        writer.WriteLine("password:" + conPassTextBox.Text);
                    }
                    else
                    {
                        MessageBox.Show("Passwords do not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Password must be at least 6 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                writer.WriteLine("email:" + emailTextBox.Text);

            }
        }


        private void regButton_Click(object sender, EventArgs e)
        {
            if (passTextBox.Text.Count() >= 6)
            {
                if (passTextBox.Text == conPassTextBox.Text)
                {
                    regUser(userTextBox.Text);
                    GlobalUser._username = userTextBox.Text;
                    MessageBox.Show("Account successfully created!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Login().Show();
                }
                else
                {
                    MessageBox.Show("Passwords do not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password must be at least 6 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void regButton_Click_1(object sender, EventArgs e)
        {
            if (passTextBox.Text.Count() >= 6)
            {
                if (passTextBox.Text == conPassTextBox.Text)
                {
                    regUser(userTextBox.Text);
                    GlobalUser._username = userTextBox.Text;
                    MessageBox.Show("Account successfully created!!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    new Login().Show();
                }
                else
                {
                    MessageBox.Show("Passwords do not Match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Password must be at least 6 characters!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void guestLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            GlobalUser._username = "Guest";
            new Personal_Details().Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                passTextBox.UseSystemPasswordChar = false;
                conPassTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passTextBox.UseSystemPasswordChar = true;
                conPassTextBox.UseSystemPasswordChar = true;
            }
        }

        private void signup_Load(object sender, EventArgs e)
        {
            passTextBox.UseSystemPasswordChar = true;
            conPassTextBox.UseSystemPasswordChar = true;
        }
    }
}
