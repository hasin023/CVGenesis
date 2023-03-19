namespace CVGenesis
{
    partial class Preview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Preview));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.profCVButton = new System.Windows.Forms.Button();
            this.academicCVButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.signUpLinkLabel = new System.Windows.Forms.LinkLabel();
            this.regLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Font = new System.Drawing.Font("Mistral", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 756);
            this.panel1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(57, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 54);
            this.label3.TabIndex = 2;
            this.label3.Text = "Create Your Professional\r\n   Profile Effortlessly";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("ROG Fonts", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(56, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "CV Genesis";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(33, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(268, 164);
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(362, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Which Type of CV do you want?";
            // 
            // profCVButton
            // 
            this.profCVButton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.profCVButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profCVButton.ForeColor = System.Drawing.Color.Transparent;
            this.profCVButton.Location = new System.Drawing.Point(348, 280);
            this.profCVButton.Name = "profCVButton";
            this.profCVButton.Size = new System.Drawing.Size(195, 68);
            this.profCVButton.TabIndex = 15;
            this.profCVButton.Text = "Industrial CV";
            this.toolTip1.SetToolTip(this.profCVButton, "The industry resume is a document that highlights your \r\nskills and experience sp" +
        "ecifically tailored to one job \r\nor type of work.");
            this.profCVButton.UseVisualStyleBackColor = false;
            this.profCVButton.Click += new System.EventHandler(this.profCVButton_Click);
            // 
            // academicCVButton
            // 
            this.academicCVButton.BackColor = System.Drawing.SystemColors.Highlight;
            this.academicCVButton.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academicCVButton.ForeColor = System.Drawing.Color.Transparent;
            this.academicCVButton.Location = new System.Drawing.Point(575, 283);
            this.academicCVButton.Name = "academicCVButton";
            this.academicCVButton.Size = new System.Drawing.Size(195, 65);
            this.academicCVButton.TabIndex = 16;
            this.academicCVButton.Text = "Academic CV";
            this.toolTip1.SetToolTip(this.academicCVButton, "The academic CV is a representation of you as an \r\nacademic and field expert. You" +
        "r comprehensive \r\nlisting of experience serves to prove your \r\nscholarship and e" +
        "xpertise.");
            this.academicCVButton.UseVisualStyleBackColor = false;
            this.academicCVButton.Click += new System.EventHandler(this.academicCVButton_Click);
            // 
            // signUpLinkLabel
            // 
            this.signUpLinkLabel.AutoSize = true;
            this.signUpLinkLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLinkLabel.LinkColor = System.Drawing.SystemColors.Highlight;
            this.signUpLinkLabel.Location = new System.Drawing.Point(630, 459);
            this.signUpLinkLabel.Name = "signUpLinkLabel";
            this.signUpLinkLabel.Size = new System.Drawing.Size(78, 22);
            this.signUpLinkLabel.TabIndex = 18;
            this.signUpLinkLabel.TabStop = true;
            this.signUpLinkLabel.Text = "Sign Up";
            this.signUpLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signUpLinkLabel_LinkClicked);
            // 
            // regLabel
            // 
            this.regLabel.AutoSize = true;
            this.regLabel.BackColor = System.Drawing.Color.Transparent;
            this.regLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.regLabel.Location = new System.Drawing.Point(385, 438);
            this.regLabel.Name = "regLabel";
            this.regLabel.Size = new System.Drawing.Size(229, 44);
            this.regLabel.TabIndex = 17;
            this.regLabel.Text = "    Wanna use it again?\r\nJoin us to save your Info.";
            // 
            // Preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.signUpLinkLabel);
            this.Controls.Add(this.regLabel);
            this.Controls.Add(this.academicCVButton);
            this.Controls.Add(this.profCVButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Preview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Preview";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button profCVButton;
        private System.Windows.Forms.Button academicCVButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel signUpLinkLabel;
        private System.Windows.Forms.Label regLabel;
    }
}