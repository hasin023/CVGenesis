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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

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
            SkillData _temp = new SkillData(langComboBox.Text, digitalComboBox.Text, sgcomboBox.Text);
            skillListBox.Items.Add(_temp.getSkill());
        }

        public void addSkill(string str)
        {
            string newUser = $@"C:\Hackathon\CVGenesis\CV Data\Skills\{str}.txt";

            using (StreamWriter sw = System.IO.File.AppendText(newUser))
            {
                string s = $"{langComboBox.Text},{digitalComboBox.Text},{sgcomboBox.Text}";
                sw.WriteLine(s);
            }

        }
        private void saveOther_Click(object sender, EventArgs e)
        {
            GlobalUser._interest = interestComboBox.Text;
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
                if (langComboBox.Text == "" || digitalComboBox.Text == "" || sgcomboBox.Text == "")
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

        private void Skills_Load(object sender, EventArgs e)
        {
            
        }

        private void sgcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void interestComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            sgcomboBox.Items.Clear();
            if (interestComboBox.Text == "Mathematics")
            {
                sgcomboBox.Items.Add("Problem-solving skills");
                sgcomboBox.Items.Add("Analytical skills");
                sgcomboBox.Items.Add("Quantitative skills");
                sgcomboBox.Items.Add("Logical reasoning");
                sgcomboBox.Items.Add("Attention to detail");
                sgcomboBox.Items.Add("Communication skills");
                sgcomboBox.Items.Add("Programming skills");
            }
            else if (interestComboBox.Text == "Science")
            {
                sgcomboBox.Items.Add("Observational skills");
                sgcomboBox.Items.Add("Data analysis skills");
                sgcomboBox.Items.Add("Critical thinking skills");
                sgcomboBox.Items.Add("Scientific method skills");
                sgcomboBox.Items.Add("Laboratory skills");
                sgcomboBox.Items.Add("Mathematical modeling skills");
                sgcomboBox.Items.Add("Experimental design skills");
                sgcomboBox.Items.Add("Communication skills");
                sgcomboBox.Items.Add("Research skills");
                sgcomboBox.Items.Add("Knowledge of scientific " + "\n" +
                    "principles and theories");
            }
            else if (interestComboBox.Text == "English language")
            {
                sgcomboBox.Items.Add("Strong written and verbal " + "\n" +
                    "communication skills");
                sgcomboBox.Items.Add("Critical thinking and " + "\n" + 
                    "analysis skills");
                sgcomboBox.Items.Add("Close reading and " + "\n" + 
                    "interpretation skills");
                sgcomboBox.Items.Add("Creative writing and " + "\n" +
                    "storytelling skills");
                sgcomboBox.Items.Add("Research and information" + "\n" +
                    "gathering skills");
                sgcomboBox.Items.Add("Persuasive and argumentative " + "\n" +
                    "writing skills");
                sgcomboBox.Items.Add("Knowledge of grammar, " + "\n" +
                    "syntax, and style");
                sgcomboBox.Items.Add("Cultural awareness and sensitivity");
                sgcomboBox.Items.Add("Editing and proofreading skills");
                sgcomboBox.Items.Add("Attention to detail and accuracy");
            }
            else if (interestComboBox.Text == "History")
            {
                sgcomboBox.Items.Add("Analytical and critical thinking skills");
                sgcomboBox.Items.Add("Research and investigative skills");
                sgcomboBox.Items.Add("Ability to interpret and " + "\n" +
                    "evaluate sources");
                sgcomboBox.Items.Add("Strong written and verbal communication skills");
                sgcomboBox.Items.Add("Attention to detail and accuracy");
                sgcomboBox.Items.Add("Ability to synthesize and " + "\n" +
                    "integrate information");
                sgcomboBox.Items.Add("Understanding of historical " + "\n" +
                    "contexts and perspectives");
                sgcomboBox.Items.Add("Ability to identify and evaluate " + "\n" +
                    "bias and multiple perspectives");
                sgcomboBox.Items.Add("Cultural awareness and sensitivity");
                sgcomboBox.Items.Add("Ability to recognize patterns " + "\n" +
                    "and trends over time.");
            }
            else if (interestComboBox.Text == "Social studies")
            {
                sgcomboBox.Items.Add("Analytical and critical thinking skills");
                sgcomboBox.Items.Add("Research and investigative skills");
                sgcomboBox.Items.Add("Strong written and verbal communication skills");
                sgcomboBox.Items.Add("Cross-cultural and cross-disciplinary understanding");
                sgcomboBox.Items.Add("Knowledge of social, economic, and political systems");
                sgcomboBox.Items.Add("Understanding of historical " + "\n" +
                    "contexts and perspectives");
                sgcomboBox.Items.Add("Ability to identify and evaluate " + "\n" +
                    "bias and multiple perspectives");
                sgcomboBox.Items.Add("Cultural awareness and sensitivity");
                sgcomboBox.Items.Add("Ability to synthesize and integrate information");
                sgcomboBox.Items.Add("Ability to recognize patterns and trends over time");
            }
            else if (interestComboBox.Text == "Computer science")
            {
                sgcomboBox.Items.Add("Programming and coding skills");
                sgcomboBox.Items.Add("Problem-solving and logical reasoning skills");
                sgcomboBox.Items.Add("Algorithmic design and analysis skills");
                sgcomboBox.Items.Add("Data structures and algorithms knowledge");
                sgcomboBox.Items.Add("Understanding of computer " + "\n" +
                    "architecture and operating systems");
                sgcomboBox.Items.Add("Ability to develop software and applications");
                sgcomboBox.Items.Add("Web development and design skills");
                sgcomboBox.Items.Add("Database management and " + "\n" +
                    "data analysis skills");
                sgcomboBox.Items.Add("Understanding of computer networks and security");
                sgcomboBox.Items.Add("Knowledge of artificial intelligence, " + "\n" +
                    "machine learning and data science techniques");
            }
            else if (interestComboBox.Text == "Business")
            {
                sgcomboBox.Items.Add("Strategic thinking and " + "\n" +
                    "decision-making skills");
                sgcomboBox.Items.Add("Leadership and team " + "\n" +
                    "management skills");
                sgcomboBox.Items.Add("Strong communication and " + "\n" +
                    "interpersonal skills");
                sgcomboBox.Items.Add("Analytical and problem-solving skills");
                sgcomboBox.Items.Add("Financial analysis and management skills");
                sgcomboBox.Items.Add("Marketing and sales skills");
                sgcomboBox.Items.Add("Project management and " + "\n" +
                    "organizational skills");
                sgcomboBox.Items.Add("Knowledge of business law and regulations");
                sgcomboBox.Items.Add("Understanding of operations " + "\n" +
                    "and supply chain management");
                sgcomboBox.Items.Add("Ability to develop business " + "\n" +
                    "plans and strategies");
            }
            else if (interestComboBox.Text == "Psychology")
            {
                sgcomboBox.Items.Add("Research and analytical skills");
                sgcomboBox.Items.Add("Understanding of human " + "\n" +
                    "behavior and motivation");
                sgcomboBox.Items.Add("Ability to analyze and interpret data");
                sgcomboBox.Items.Add("Strong written and verbal " + "\n" +
                    "communication skills");
                sgcomboBox.Items.Add("Critical thinking and problem-solving skills");
                sgcomboBox.Items.Add("Knowledge of psychological " + "\n" +
                    "theories and principles");
                sgcomboBox.Items.Add("Counseling and interpersonal skills");
                sgcomboBox.Items.Add("Attention to detail and accuracy");
                sgcomboBox.Items.Add("Cultural awareness and sensitivity");
                sgcomboBox.Items.Add("Ability to identify and evaluate " + "\n" +
                    "bias and multiple perspectives");
            }
            else if (interestComboBox.Text == "Health and wellness")
            {
                sgcomboBox.Items.Add("Knowledge of human anatomy and physiology");
                sgcomboBox.Items.Add("Understanding of disease " + "\n" +
                    "prevention and health promotion");
                sgcomboBox.Items.Add("Counseling and communication skills");
                sgcomboBox.Items.Add("Ability to analyze and " + "\n" +
                    "interpret health data");
                sgcomboBox.Items.Add("Understanding of the principles of " + "\n" +
                    "nutrition and exercise science");
                sgcomboBox.Items.Add("Ability to design and " + "\n" +
                    "implement wellness programs");
                sgcomboBox.Items.Add("Knowledge of alternative and " + "\n" +
                    "complementary therapies");
                sgcomboBox.Items.Add("Ability to conduct health " + "\n" +
                    "assessments and screenings");
                sgcomboBox.Items.Add("Understanding of public health " + "\n" +
                    "policies and regulations");
                sgcomboBox.Items.Add("Ability to educate and promote " + "\n" +
                    "health and wellness to individuals and communities");
            }
            else if (interestComboBox.Text == "Art and design")
            {
                sgcomboBox.Items.Add("Creativity and imagination");
                sgcomboBox.Items.Add("Visual and spatial awareness");
                sgcomboBox.Items.Add("Design thinking and problem-solving skills");
                sgcomboBox.Items.Add("Attention to detail and precision");
                sgcomboBox.Items.Add("Strong communication and " + "\n" +
                    "interpersonal skills");
                sgcomboBox.Items.Add("Ability to work collaboratively in a team");
                sgcomboBox.Items.Add("Knowledge of art history and theory");
                sgcomboBox.Items.Add("Understanding of different " + "\n" +
                    "artistic mediums and technique");
                sgcomboBox.Items.Add("Proficiency in using various " + "\n" +
                    "design software and tools");
                sgcomboBox.Items.Add("Ability to communicate ideas " + "\n" +
                    "visually and conceptually");
            }
        }
    }
}
