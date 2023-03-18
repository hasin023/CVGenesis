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
    public partial class Academic_Template : Form
    {
        public Academic_Template()
        {
            InitializeComponent();

            readUser(GlobalUser._username);
        }

        public void readUser(string str)
        {
            string user = $@"C:\Hackathon\CVGenesis\CV Data\Personal Details\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);
                foreach(string u in users)
                {
                    if(u.Contains("FirstName:"))
                    {
                        firstnameLabel.Text = u.Remove(0,10);
                    }
                    else if(u.Contains("LastName:"))
                    {
                        lastnameLabel.Text= u.Remove(0,9);
                    }
                    else if(u.Contains("DOB:"))
                    {
                        DOBLabel.Text = u.Remove(0,4);
                    }
                    else if(u.Contains("POB:"))
                    {
                        POBLabel.Text= u.Remove(0,4);
                    }
                    else if(u.Contains("Nationality:"))
                    {
                        nationLabel.Text = u.Remove(0,12);
                    }
                    else if(u.Contains("Gender:"))
                    {
                        genderLabel.Text = u.Remove(0, 7);
                    }
                    else if(u.Contains("Address:"))
                    {
                        addressLabel.Text= u.Remove(0, 8);
                    }
                    else if(u.Contains("Email:"))
                    {
                        mailLabel.Text = u.Remove(0, 6);
                    }
                    else if(u.Contains("Phone:"))
                    {
                        mobileLabel.Text = u.Remove(0,6);
                    }
                }

            }
        }
        public void readEduData(string str)
        {
            string degree;
            string institution;
            string subject;
            string year;
            string result;
            string user = $@"C:\Hackathon\CVGenesis\CV Data\Education Details\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach(string s in users) 
                {
                    string[] k = null;
                    k = s.Split(',');
                    degree= k[0];
                    institution= k[1];
                    subject = k[2];
                    year = k[3];
                    result = k[4];

                }
            }
            
        }

        private void label57_Click(object sender, EventArgs e)
        {

        }
    }
}
