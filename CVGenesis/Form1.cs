using CVGenesis.Properties;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVGenesis
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void CVGenesis_Load(object sender, EventArgs e)
        {
            passTextBox.UseSystemPasswordChar = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                passTextBox.UseSystemPasswordChar = false;
            }
            else
            {
                passTextBox.UseSystemPasswordChar = true;
            }
        }

        public void checkUser(string str)
        {
            string user = $@"C:\Hackathon\CVGenesis\Users\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string u in users)
                {
                    if (u.Contains("username:"))
                    {
                        if (userTextBox.Text == u.Remove(0, 9))
                        {
                            foreach (string p in users)
                            {
                                if (p.Contains("password:"))
                                {
                                    if (passTextBox.Text == p.Remove(0, 9))
                                    {
                                        GlobalUser._username = u.Remove(0, 9);

                                        this.Hide();
                                        new Personal_Details().Show();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Incorrect Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Account does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            checkUser(userTextBox.Text);
        }

        private void nameText_Enter(object sender, EventArgs e)
        {
            if(userTextBox.Text == "Username")
            {
                userTextBox.Text = "";

                userTextBox.ForeColor= Color.Black;
            }
        }

        private void nametext_leave(object sender, EventArgs e)
        {
            if (userTextBox.Text == "")
            {
                userTextBox.Text = "Username";

                userTextBox.ForeColor = Color.Silver;
            }
        }

        private void passEnter(object sender, EventArgs e)
        {
            if (passTextBox.Text == "Password")
            {
                passTextBox.Text = "";

                passTextBox.ForeColor = Color.Black;
            }
        }

        private void pass_leave(object sender, EventArgs e)
        {
            if (passTextBox.Text == "")
            {
                passTextBox.Text = "Password";

                passTextBox.ForeColor = Color.Silver;
            }
        }
    }
}
