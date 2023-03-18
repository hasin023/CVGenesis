using System;
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
    public partial class Preview : Form
    {
        public Preview()
        {
            InitializeComponent();
        }

        private void profCVButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Professional_Template().Show();
        }

        private void academicCVButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Academic_Template().Show();
        }
    }
}
