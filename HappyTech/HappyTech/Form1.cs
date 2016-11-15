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
            //default text for labels+buttons on startup
           // sectionOneNameLabel.Text = "Section One";
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

            //create section

            
            //validation - make sure section has a name
            if (addSectionNameTextbox.Text == "")
            {
                //show messagebox asking to enter a name into addSectionNameTextBox
                MessageBox.Show("Please enter section name");
            }
            //else create section
            else
            {

                //dynamically add panel
                //create panel objects
                Panel sectionOnePanel = new Panel();

                //set location of panels (x,y)
                sectionOnePanel.Location = new Point(10, 150);

                //assign name to panel
                sectionOnePanel.Name = "sectionOne";

                //set size of panel (width,height)
                sectionOnePanel.Size = new Size(460, 180);

                //add panel to form
                Controls.Add(sectionOnePanel);

                //create label objects
                Label sectionOneNameLabel = new Label();

                //set location of section label
                sectionOneNameLabel.Location = new Point(10, 25);

                //rename section label with text entered into addSectionNameTextbox
                sectionOneNameLabel.Text = addSectionNameTextbox.Text;

                //dynamically add text boxes to panel
                //create textbox objects
                TextBox textbox1 = new TextBox();
                TextBox textbox2 = new TextBox();
                TextBox textbox3 = new TextBox();
                TextBox textbox4 = new TextBox();
                TextBox textbox5 = new TextBox();
                TextBox textbox6 = new TextBox();

                //position of textboxes in panel
                textbox1.Location = new Point(10, 70 * count);
                textbox2.Location = new Point(160, 70 * count);
                textbox3.Location = new Point(10, 115 * count);
                textbox4.Location = new Point(160, 115 * count);
                textbox5.Location = new Point(10, 160 * count);
                textbox6.Location = new Point(160, 160 * count);

                //change height and width of textboxes on right side
                textbox2.Size = new Size(300, 24);
                textbox4.Size = new Size(300, 24);
                textbox6.Size = new Size(300, 24);

                //assign name to each textbox
                textbox1.Name = "textbox_" + (count + 1);
                textbox2.Name = "textbox_" + (count + 1);
                textbox3.Name = "textbox_" + (count + 1);
                textbox4.Name = "textbox_" + (count + 1);
                textbox5.Name = "textbox_" + (count + 1);
                textbox6.Name = "textbox_" + (count + 1);

                //add labels to sectionOne
                sectionOnePanel.Controls.Add(sectionOneNameLabel);

                //add labels to sectionOne
                sectionOnePanel.Controls.Add(textbox1);
                sectionOnePanel.Controls.Add(textbox2);
                sectionOnePanel.Controls.Add(textbox3);
                sectionOnePanel.Controls.Add(textbox4);
                sectionOnePanel.Controls.Add(textbox5);
                sectionOnePanel.Controls.Add(textbox6);
                
            }
        }
    }
}