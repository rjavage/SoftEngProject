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
            this.templateInput = new System.Windows.Forms.Panel();
            this.positionLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.nameTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.SuspendLayout();
            // 
            // emailPreview
            // 
            this.emailPreview.Location = new System.Drawing.Point(608, 135);
            this.emailPreview.Name = "emailPreview";
            this.emailPreview.Size = new System.Drawing.Size(462, 461);
            this.emailPreview.TabIndex = 48;
            this.emailPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.emailPreview_Paint);
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(769, 625);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 45;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(954, 625);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 44;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.nameTextbox.TextChanged += new System.EventHandler(this.nameTextbox_TextChanged);
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
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 692);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1110, 22);
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // feedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 714);
            this.Controls.Add(this.emailPreview);
            this.Controls.Add(this.templateInput);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.emailTextbox);
            this.Controls.Add(this.nameTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Name = "feedback";
            this.Text = "feedback";
            this.Load += new System.EventHandler(this.feedback_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel emailPreview;
        private System.Windows.Forms.Panel templateInput;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox emailTextbox;
        private System.Windows.Forms.TextBox nameTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}