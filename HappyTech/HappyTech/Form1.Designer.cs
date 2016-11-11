namespace HappyTech
{
    partial class Form1
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
            this.positionLabel = new System.Windows.Forms.Label();
            this.templatePositionTextBox = new System.Windows.Forms.TextBox();
            this.addSectionButton = new System.Windows.Forms.Button();
            this.removeSectionButton = new System.Windows.Forms.Button();
            this.section1 = new System.Windows.Forms.Panel();
            this.addSectionNameTextbox = new System.Windows.Forms.TextBox();
            this.addSectionNameLabel = new System.Windows.Forms.Label();
            this.sectionOneNameLabel = new System.Windows.Forms.Label();
            this.section1.SuspendLayout();
            this.SuspendLayout();
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(13, 13);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(35, 13);
            this.positionLabel.TabIndex = 0;
            this.positionLabel.Text = "label1";
            // 
            // templatePositionTextBox
            // 
            this.templatePositionTextBox.Location = new System.Drawing.Point(63, 10);
            this.templatePositionTextBox.Name = "templatePositionTextBox";
            this.templatePositionTextBox.Size = new System.Drawing.Size(100, 20);
            this.templatePositionTextBox.TabIndex = 1;
            this.templatePositionTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // addSectionButton
            // 
            this.addSectionButton.Location = new System.Drawing.Point(40, 55);
            this.addSectionButton.Name = "addSectionButton";
            this.addSectionButton.Size = new System.Drawing.Size(75, 23);
            this.addSectionButton.TabIndex = 2;
            this.addSectionButton.UseVisualStyleBackColor = true;
            this.addSectionButton.Click += new System.EventHandler(this.templateAddSectionButton_Click);
            // 
            // removeSectionButton
            // 
            this.removeSectionButton.Location = new System.Drawing.Point(419, 49);
            this.removeSectionButton.Name = "removeSectionButton";
            this.removeSectionButton.Size = new System.Drawing.Size(75, 35);
            this.removeSectionButton.TabIndex = 3;
            this.removeSectionButton.UseVisualStyleBackColor = true;
            // 
            // section1
            // 
            this.section1.Controls.Add(this.sectionOneNameLabel);
            this.section1.Location = new System.Drawing.Point(16, 132);
            this.section1.Name = "section1";
            this.section1.Size = new System.Drawing.Size(482, 164);
            this.section1.TabIndex = 4;
            // 
            // addSectionNameTextbox
            // 
            this.addSectionNameTextbox.Location = new System.Drawing.Point(100, 84);
            this.addSectionNameTextbox.Name = "addSectionNameTextbox";
            this.addSectionNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.addSectionNameTextbox.TabIndex = 5;
            // 
            // addSectionNameLabel
            // 
            this.addSectionNameLabel.AutoSize = true;
            this.addSectionNameLabel.Location = new System.Drawing.Point(12, 87);
            this.addSectionNameLabel.Name = "addSectionNameLabel";
            this.addSectionNameLabel.Size = new System.Drawing.Size(35, 13);
            this.addSectionNameLabel.TabIndex = 6;
            this.addSectionNameLabel.Text = "label2";
            // 
            // sectionOneNameLabel
            // 
            this.sectionOneNameLabel.AutoSize = true;
            this.sectionOneNameLabel.Location = new System.Drawing.Point(6, 4);
            this.sectionOneNameLabel.Name = "sectionOneNameLabel";
            this.sectionOneNameLabel.Size = new System.Drawing.Size(35, 13);
            this.sectionOneNameLabel.TabIndex = 0;
            this.sectionOneNameLabel.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 482);
            this.Controls.Add(this.addSectionNameLabel);
            this.Controls.Add(this.addSectionNameTextbox);
            this.Controls.Add(this.section1);
            this.Controls.Add(this.removeSectionButton);
            this.Controls.Add(this.addSectionButton);
            this.Controls.Add(this.templatePositionTextBox);
            this.Controls.Add(this.positionLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.section1.ResumeLayout(false);
            this.section1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox templatePositionTextBox;
        private System.Windows.Forms.Button addSectionButton;
        private System.Windows.Forms.Button removeSectionButton;
        private System.Windows.Forms.Panel section1;
        private System.Windows.Forms.TextBox addSectionNameTextbox;
        private System.Windows.Forms.Label addSectionNameLabel;
        private System.Windows.Forms.Label sectionOneNameLabel;
    }
}

