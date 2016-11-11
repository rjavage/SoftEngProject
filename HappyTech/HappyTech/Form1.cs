// Author: Ryan Savage
// SID: 1431802
// Edited: 12/11/2016

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HappyTech
{
    public partial class Form1 : Form
    {

        //count variable to keep track of textboxes
        private int count = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //default text for labels,buttons on startup
            sectionOneNameLabel.Text = "Section One";
            positionLabel.Text = "Position";
            addSectionButton.Text = "Add New Section";
            addSectionNameLabel.Text = "Section Name:";
            removeSectionButton.Text = "Remove Section";
            addSectionNumberLabel.Text = "Section Number:";
            removeSectionNumberLabel.Text = "Section Number:";



            //add values to addSectionNumberComboBox
            for (int i = 1; i < 100; i++)
                addSectionNumberComboBox.Items.Add(i);

            //add values to removeSectionNumberComboBox
            for (int i = 1; i < 100; i++)
                removeSectionNumberComboBox.Items.Add(i);
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void templateAddSectionButton_Click(object sender, EventArgs e)
        {
            //validation - make sure section has a name
            if (addSectionNameTextbox.Text == "")
            {
                MessageBox.Show("Please enter section name");
            }
            //else create textboxes in panel
            else
            {

                //create textbox objects
                TextBox textbox1 = new TextBox();
                TextBox textbox2 = new TextBox();
                TextBox textbox3 = new TextBox();
                TextBox textbox4 = new TextBox();
                TextBox textbox5 = new TextBox();
                TextBox textbox6 = new TextBox();


                //position of textboxes in panel
                textbox1.Location = new Point(10, 25 * count);
                textbox2.Location = new Point(160, 25 * count);
                textbox3.Location = new Point(10, 70 * count);
                textbox4.Location = new Point(160, 70 * count);
                textbox5.Location = new Point(10, 115 * count);
                textbox6.Location = new Point(160, 115 * count);

                //change height and width of textboxes on right side
                textbox2.Size = new Size(300, 24);
                textbox4.Size = new Size(300, 24);
                textbox6.Size = new Size(300, 24);

                //set name of each textbox
                textbox1.Name = "textbox_" + (count + 1);
                textbox2.Name = "textbox_" + (count + 1);
                textbox3.Name = "textbox_" + (count + 1);
                textbox4.Name = "textbox_" + (count + 1);
                textbox5.Name = "textbox_" + (count + 1);
                textbox6.Name = "textbox_" + (count + 1);

                //add textboxes to panel
                section1.Controls.Add(textbox1);
                section1.Controls.Add(textbox2);
                section1.Controls.Add(textbox3);
                section1.Controls.Add(textbox4);
                section1.Controls.Add(textbox5);
                section1.Controls.Add(textbox6);

                //rename section label with text entered into textbox
                sectionOneNameLabel.Text = addSectionNameTextbox.Text;
            }
        }

        private void positionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}