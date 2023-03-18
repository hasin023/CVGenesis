﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVGenesis.Properties
{
    public partial class Educational_Background : Form
    {
        public Educational_Background()
        {
            InitializeComponent();

            eduListBox.Items.Add("Degree\tInstitute\tSubjct\tEndYear\tResult");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void addDegree(string str)
        {
            string newUser = $@"C:\Hackathon\CVGenesis\CV Data\Education Details\{str}.txt";

            using (StreamWriter sw = System.IO.File.AppendText(newUser))
            {
                string s = $"{degreeTextBox.Text},{InstitutionTextBox.Text},{SubjectComboBox.Text},{yearTextBox.Text},{resultTextBox.Text}";
                sw.WriteLine(s);
            }

        }
        private void AddDegreeButton_Click(object sender, EventArgs e)
        {
            Degree _temp = new Degree(degreeTextBox.Text, InstitutionTextBox.Text, SubjectComboBox.Text, yearTextBox.Text,Convert.ToDouble(resultTextBox.Text));
            eduListBox.Items.Add(_temp.getDegree());
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            
            addDegree(GlobalUser._username);
            
            MessageBox.Show("Data saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Educational_Background_Load(object sender, EventArgs e)
        {
            
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Personal_Details().Show();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Training().Show();
        }
    }
}
