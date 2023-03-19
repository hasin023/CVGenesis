using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVGenesis.Properties
{
    public partial class Intro : Form
    {
        public Intro()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void loginLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void createCVButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new signup().Show();
        }

        private void Intro_Load(object sender, EventArgs e)
        {

        }
    }
}
