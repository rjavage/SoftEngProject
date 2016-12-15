namespace HappyTech
{
    partial class feedback
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
            this.emailPreview = new System.Windows.Forms.Panel();
            this.TxtBody = new System.Windows.Forms.TextBox();
            this.TxtSubject = new System.Windows.Forms.TextBox();
            this.TxtRecievers = new System.Windows.Forms.TextBox();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.templateInput = new System.Windows.Forms.Panel();
            this.positionLabel = new System.Windows.Forms.Label();
            this.save2Database = new System.Windows.Forms.Button();
            this.send2Email = new System.Windows.Forms.Button();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.emailPreview.SuspendLayout();
            this.SuspendLayout();
            // 
            // emailPreview
            // 
            this.emailPreview.Controls.Add(this.TxtBody);
            this.emailPreview.Controls.Add(this.TxtSubject);
            this.emailPreview.Controls.Add(this.TxtRecievers);
            this.emailPreview.Controls.Add(this.txtEmailAddress);
            this.emailPreview.Controls.Add(this.label7);
            this.emailPreview.Controls.Add(this.label4);
            this.emailPreview.Controls.Add(this.label3);
            this.emailPreview.Controls.Add(this.label1);
            this.emailPreview.Location = new System.Drawing.Point(608, 128);
            this.emailPreview.Name = "emailPreview";
            this.emailPreview.Size = new System.Drawing.Size(462, 461);
            this.emailPreview.TabIndex = 48;
            this.emailPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.emailPreview_Paint);
            // 
            // TxtBody
            // 
            this.TxtBody.Location = new System.Drawing.Point(84, 216);
            this.TxtBody.Multiline = true;
            this.TxtBody.Name = "TxtBody";
            this.TxtBody.Size = new System.Drawing.Size(326, 187);
            this.TxtBody.TabIndex = 2;
            // 
            // TxtSubject
            // 
            this.TxtSubject.Location = new System.Drawing.Point(84, 162);
            this.TxtSubject.Name = "TxtSubject";
            this.TxtSubject.Size = new System.Drawing.Size(326, 20);
            this.TxtSubject.TabIndex = 2;
            // 
            // TxtRecievers
            // 
            this.TxtRecievers.Location = new System.Drawing.Point(84, 119);
            this.TxtRecievers.Name = "TxtRecievers";
            this.TxtRecievers.Size = new System.Drawing.Size(326, 20);
            this.TxtRecievers.TabIndex = 2;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Location = new System.Drawing.Point(84, 65);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(326, 20);
            this.txtEmailAddress.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Body:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "CC:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Subject:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "To:";
            // 
            // templateInput
            // 
            this.templateInput.Location = new System.Drawing.Point(30, 135);
            this.templateInput.Name = "templateInput";
            this.templateInput.Size = new System.Drawing.Size(494, 461);
            this.templateInput.TabIndex = 47;
            this.templateInput.Paint += new System.Windows.Forms.PaintEventHandler(this.templateInput_Paint);
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(110, 12);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(69, 13);
            this.positionLabel.TabIndex = 46;
            this.positionLabel.Text = "positionLabel";
            this.positionLabel.Click += new System.EventHandler(this.positionLabel_Click);
            // 
            // save2Database
            // 
            this.save2Database.Location = new System.Drawing.Point(412, 625);
            this.save2Database.Name = "save2Database";
            this.save2Database.Size = new System.Drawing.Size(112, 23);
            this.save2Database.TabIndex = 45;
            this.save2Database.Text = "Save";
            this.save2Database.UseVisualStyleBackColor = true;
            this.save2Database.Click += new System.EventHandler(this.button4_Click);
            // 
            // send2Email
            // 
            this.send2Email.Location = new System.Drawing.Point(958, 625);
            this.send2Email.Name = "send2Email";
            this.send2Email.Size = new System.Drawing.Size(112, 23);
            this.send2Email.TabIndex = 44;
            this.send2Email.Text = "Send Email";
            this.send2Email.UseVisualStyleBackColor = true;
            this.send2Email.Click += new System.EventHandler(this.button2_Click);
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(110, 60);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(226, 20);
            this.emailTextbox.TabIndex = 43;
            // 
            // nameTextbox
            // 
            this.nameTextbox.Location = new System.Drawing.Point(110, 32);
            this.nameTextbox.Name = "nameTextbox";
            this.nameTextbox.Size = new System.Drawing.Size(226, 20);
            this.nameTextbox.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Applicant Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Email:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Position:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 714);
            this.Controls.Add(this.emailPreview);
            this.Controls.Add(this.templateInput);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.save2Database);
            this.Controls.Add(this.send2Email);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "feedback";
            this.Text = "feedback";
            this.Load += new System.EventHandler(this.feedback_Load);
            this.emailPreview.ResumeLayout(false);
            this.emailPreview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel emailPreview;
        private System.Windows.Forms.Panel templateInput;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Button save2Database;
        private System.Windows.Forms.Button send2Email;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBody;
        private System.Windows.Forms.TextBox TxtSubject;
        private System.Windows.Forms.TextBox TxtRecievers;
        private System.Windows.Forms.TextBox txtEmailAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}