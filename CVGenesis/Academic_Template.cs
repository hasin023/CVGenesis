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
            readEduData(GlobalUser._username);
            readTrainingData(GlobalUser._username);
            readWorkData(GlobalUser._username);
            readCertiData(GlobalUser._username);
            readSkillData(GlobalUser._username);
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
           
            string user = $@"C:\Hackathon\CVGenesis\CV Data\Education Details\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach(string s in users) 
                {
                    if(s.Contains("1."))
                    {
                        s.Remove(0,2);
                        string[] k = null;
                        k = s.Split(',');
                    
                        degreeLabel1.Text = k[0];
                        InsLabel1.Text = k[1];
                        subLabel1.Text = k[2];
                        yearLabel1.Text = k[3];
                        resLabel1.Text = k[4];

                    }

                   else  if (s.Contains("2."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        degreeLabel2.Text = k[0];
                        InsLabel2.Text = k[1];
                        subLabel2.Text = k[2];
                        yearLabel2.Text = k[3];
                        resLabel2.Text = k[4];

                    }

                    else if (s.Contains("3."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        degreeLabel3.Text = k[0];
                        InsLabel3.Text = k[1];
                        subLabel3.Text = k[2];
                        yearLabel3.Text = k[3];
                        resLabel3.Text = k[4];

                    }

                }
            }




        }

        public void readTrainingData(string str)
        {

            string user = $@"C:\Hackathon\CVGenesis\CV Data\Training\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string s in users)
                {
                    if (s.Contains("1."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        quaLabel.Text = k[0];
                        orgLabel.Text = k[1];
                        fromLabel.Text = k[2];
                        toLabel.Text = k[3];
                        

                    }

                    else if (s.Contains("2."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        quaLabel2.Text = k[0];
                        orgLabel2.Text = k[1];
                        formLabel2.Text = k[2];
                        toLabel2.Text = k[3];
                        

                    }

                    

                }
            }




        }

        public void readWorkData(string str)
        {

            string user = $@"C:\Hackathon\CVGenesis\CV Data\WorkExp\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string s in users)
                {
                    if (s.Contains("1."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        ocLabel1.Text = k[0];
                        emLabel1.Text = k[1];
                        conLabel1.Text = k[2];
                        fromLabel3.Text = k[3];
                        toLabel3.Text = k[4];

                    }

                    else if (s.Contains("2."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        occLabel2.Text = k[0];
                        emLabel2.Text = k[1];
                        conLabel2.Text = k[2];
                        fromLabel4.Text = k[3];
                        toLabel4.Text = k[4];

                    }



                }
            }




        }

        public void readCertiData(string str)
        {

            string user = $@"C:\Hackathon\CVGenesis\CV Data\Awards\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string s in users)
                {
                    if (s.Contains("1."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        titleLabel1.Text = k[0];
                        eventLabel1.Text = k[1];
                        cinsLabel1.Text = k[2];
                        DOWLabel1.Text = k[3];
                        
                    }

                    else if (s.Contains("2."))
                    {
                        s.Remove(0, 2);
                        string[] k = null;
                        k = s.Split(',');

                        titleLabel2.Text = k[0];
                        eventLabel2.Text = k[1];
                        cinsLabel2.Text = k[2];
                        DOWLabel2.Text = k[3];
                       
                    }



                }
            }




        }

        public void readSkillData(string str)
        {

            string user = $@"C:\Hackathon\CVGenesis\CV Data\Skills\{str}.txt";

            if (File.Exists(user))
            {
                string[] users = File.ReadAllLines(user);

                foreach (string s in users)
                {
                   
                     
                        string[] k = null;
                        k = s.Split(',');

                    lanskillLabel.Text = k[0];
                    digitalskillLabel.Text = k[1];
                    otherskillLabel.Text = k[2];
                        

                   



                }
            }




        }

        private void label57_Click(object sender, EventArgs e)
        {

        }

        private void yearLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toLabel3_Click(object sender, EventArgs e)
        {

        }

        private void toLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
