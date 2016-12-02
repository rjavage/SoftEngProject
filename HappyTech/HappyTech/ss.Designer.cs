namespace Template
{
    partial class ss
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sendEmail = new System.Windows.Forms.Button();
            this.saveFB = new System.Windows.Forms.Button();
            this.emailPreview = new System.Windows.Forms.Panel();
            this.positionPassed = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 665);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1149, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sendEmail
            // 
            this.sendEmail.Location = new System.Drawing.Point(1026, 636);
            this.sendEmail.Name = "sendEmail";
            this.sendEmail.Size = new System.Drawing.Size(75, 23);
            this.sendEmail.TabIndex = 30;
            this.sendEmail.Text = "Send Email";
            this.sendEmail.UseVisualStyleBackColor = true;
            // 
            // saveFB
            // 
            this.saveFB.Location = new System.Drawing.Point(905, 636);
            this.saveFB.Name = "saveFB";
            this.saveFB.Size = new System.Drawing.Size(75, 23);
            this.saveFB.TabIndex = 31;
            this.saveFB.Text = "Save";
            this.saveFB.UseVisualStyleBackColor = true;
            // 
            // emailPreview
            // 
            this.emailPreview.Location = new System.Drawing.Point(132, 151);
            this.emailPreview.Name = "emailPreview";
            this.emailPreview.Size = new System.Drawing.Size(462, 461);
            this.emailPreview.TabIndex = 37;
            // 
            // positionPassed
            // 
            this.positionPassed.Location = new System.Drawing.Point(133, 24);
            this.positionPassed.Name = "positionPassed";
            this.positionPassed.Size = new System.Drawing.Size(225, 20);
            this.positionPassed.TabIndex = 59;
            this.positionPassed.TextChanged += new System.EventHandler(this.positionPassed_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "Template";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(132, 106);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 57;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(133, 51);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(226, 20);
            this.nameTextbox.TabIndex = 56;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Applicant Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Position:";
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(132, 80);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(226, 20);
            this.emailTextbox.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "Email:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Location = new System.Drawing.Point(639, 151);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(462, 461);
            this.panel1.TabIndex = 60;
            // 
            // ss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1149, 687);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.positionPassed);
            this.Controls.Add(this.emailPreview);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveFB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sendEmail);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.emailTextbox);
            this.Name = "ss";
            this.Text = "FeedbackForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button sendEmail;
        private System.Windows.Forms.Button saveFB;
        private System.Windows.Forms.Panel emailPreview;
        private System.Windows.Forms.TextBox positionPassed;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}

