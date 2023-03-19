namespace CVGenesis
{
    partial class Skills
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Skills));
            this.panel1 = new System.Windows.Forms.Panel();
            this.skillListBox = new System.Windows.Forms.ListBox();
            this.skipButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.langComboBox = new System.Windows.Forms.ComboBox();
            this.digitalComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.otherSkillTextBox = new System.Windows.Forms.TextBox();
            this.saveOther = new System.Windows.Forms.Button();
            this.addOther = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.skillListBox);
            this.panel1.Controls.Add(this.skipButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(410, -4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(514, 787);
            this.panel1.TabIndex = 52;
            // 
            // skillListBox
            // 
            this.skillListBox.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.skillListBox.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skillListBox.FormattingEnabled = true;
            this.skillListBox.ItemHeight = 22;
            this.skillListBox.Location = new System.Drawing.Point(0, 152);
            this.skillListBox.Name = "skillListBox";
            this.skillListBox.Size = new System.Drawing.Size(511, 224);
            this.skillListBox.TabIndex = 32;
            // 
            // skipButton
            // 
            this.skipButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.skipButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.skipButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.skipButton.Location = new System.Drawing.Point(37, 551);
            this.skipButton.Name = "skipButton";
            this.skipButton.Size = new System.Drawing.Size(106, 41);
            this.skipButton.TabIndex = 31;
            this.skipButton.Text = "Back";
            this.skipButton.UseVisualStyleBackColor = false;
            this.skipButton.Click += new System.EventHandler(this.skipButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.nextButton.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.SystemColors.Highlight;
            this.nextButton.Location = new System.Drawing.Point(367, 551);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(106, 41);
            this.nextButton.TabIndex = 30;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(438, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 45);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(2, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 35);
            this.label1.TabIndex = 54;
            this.label1.Text = "Skills and Language";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(3, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 28);
            this.label4.TabIndex = 55;
            this.label4.Text = "_______________________";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(4, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 22);
            this.label6.TabIndex = 56;
            this.label6.Text = "Choose language";
            // 
            // langComboBox
            // 
            this.langComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.langComboBox.FormattingEnabled = true;
            this.langComboBox.Items.AddRange(new object[] {
            "English",
            "Spanish",
            "French",
            "German",
            "Italian",
            "Chinese (Mandarin)",
            "Japanese",
            "Korean",
            "Arabic",
            "Portuguese",
            "Russian",
            "Hindi",
            "Bengali",
            "Punjabi",
            "Urdu",
            "Turkish",
            "Dutch",
            "Polish",
            "Swedish",
            "Norwegian",
            "Danish",
            "Finnish",
            "Greek",
            "Hebrew",
            "Thai",
            "Indonesian",
            "Malay",
            "Vietnamese",
            "Tagalog (Filipino)",
            "Swahili",
            "Romanian",
            "Czech",
            "Slovak",
            "Hungarian",
            "Bulgarian",
            "Serbian",
            "Croatian",
            "Slovenian",
            "Macedonian",
            "Ukrainian",
            "Belarusian",
            "Latvian",
            "Lithuanian",
            "Estonian",
            "Icelandic",
            "Gaelic (Irish)",
            "Welsh",
            "Scots Gaelic",
            "Basque",
            "Catalan",
            "Galician",
            "Tamil",
            "Telugu",
            "Kannada",
            "Malayalam",
            "Marathi",
            "Gujarati",
            "Oriya (Odia)",
            "Assamese",
            "Kashmiri",
            "Sindhi"});
            this.langComboBox.Location = new System.Drawing.Point(8, 176);
            this.langComboBox.Name = "langComboBox";
            this.langComboBox.Size = new System.Drawing.Size(244, 24);
            this.langComboBox.TabIndex = 73;
            this.toolTip1.SetToolTip(this.langComboBox, "Choose the language you are proficient in");
            // 
            // digitalComboBox
            // 
            this.digitalComboBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.digitalComboBox.FormattingEnabled = true;
            this.digitalComboBox.Items.AddRange(new object[] {
            "Basic computer literacy",
            "Word processing",
            "Spreadsheets",
            "Presentation software",
            "Email management",
            "Social media management",
            "Search engine optimization and search engine marketing",
            "Graphic design",
            "Video editing",
            "Website development",
            "Mobile app development",
            "Cloud computing",
            "Data analytics and data visualization",
            "Digital marketing",
            "Cybersecurity"});
            this.digitalComboBox.Location = new System.Drawing.Point(8, 291);
            this.digitalComboBox.Name = "digitalComboBox";
            this.digitalComboBox.Size = new System.Drawing.Size(244, 24);
            this.digitalComboBox.TabIndex = 77;
            this.toolTip1.SetToolTip(this.digitalComboBox, "Include your digital skills");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(4, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 76;
            this.label2.Text = "Digital Skills";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label3.Location = new System.Drawing.Point(4, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 22);
            this.label3.TabIndex = 80;
            this.label3.Text = "Other Skills";
            // 
            // otherSkillTextBox
            // 
            this.otherSkillTextBox.BackColor = System.Drawing.SystemColors.MenuBar;
            this.otherSkillTextBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherSkillTextBox.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.otherSkillTextBox.Location = new System.Drawing.Point(7, 418);
            this.otherSkillTextBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.otherSkillTextBox.Name = "otherSkillTextBox";
            this.otherSkillTextBox.Size = new System.Drawing.Size(244, 28);
            this.otherSkillTextBox.TabIndex = 81;
            this.toolTip1.SetToolTip(this.otherSkillTextBox, "Include if you have any other skills");
            // 
            // saveOther
            // 
            this.saveOther.BackColor = System.Drawing.SystemColors.Highlight;
            this.saveOther.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveOther.ForeColor = System.Drawing.Color.Transparent;
            this.saveOther.Location = new System.Drawing.Point(271, 523);
            this.saveOther.Name = "saveOther";
            this.saveOther.Size = new System.Drawing.Size(102, 38);
            this.saveOther.TabIndex = 83;
            this.saveOther.Text = "Save";
            this.saveOther.UseVisualStyleBackColor = false;
            this.saveOther.Click += new System.EventHandler(this.saveOther_Click);
            // 
            // addOther
            // 
            this.addOther.BackColor = System.Drawing.SystemColors.Highlight;
            this.addOther.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOther.ForeColor = System.Drawing.Color.Transparent;
            this.addOther.Location = new System.Drawing.Point(31, 523);
            this.addOther.Name = "addOther";
            this.addOther.Size = new System.Drawing.Size(110, 38);
            this.addOther.TabIndex = 82;
            this.addOther.Text = "Add";
            this.addOther.UseVisualStyleBackColor = false;
            this.addOther.Click += new System.EventHandler(this.addOther_Click);
            // 
            // Skills
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 753);
            this.Controls.Add(this.saveOther);
            this.Controls.Add(this.addOther);
            this.Controls.Add(this.otherSkillTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.digitalComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.langComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Skills";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skills";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button skipButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox langComboBox;
        private System.Windows.Forms.ComboBox digitalComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox skillListBox;
        private System.Windows.Forms.TextBox otherSkillTextBox;
        private System.Windows.Forms.Button saveOther;
        private System.Windows.Forms.Button addOther;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}