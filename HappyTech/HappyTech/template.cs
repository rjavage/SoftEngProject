// Author: Ryan Savage
// SID: 1431802
// Edited: 15/11/2016

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HappyTech
{
    public partial class template : Form
    
    {
        public static string passingText;
        
        
        public template()
        
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //default text for labels,buttons on startup
            positionLabel.Text = "Position";
            addSectionButton.Text = "Add New Section";
            addSectionNameLabel.Text = "Section Name:";
            removeSectionButton.Text = "Remove Section";
            addSectionNumberLabel.Text = "Section Number:";
            removeSectionNumberLabel.Text = "Section Number:";
            templateSaveButton.Text = "Save Form";


            //add values to addSectionNumberComboBox
            for (int i = 1; i < 100; i++)
                addSectionNumberComboBox.Items.Add(i);

            //add values to removeSectionNumberComboBox
            for (int i = 1; i < 100; i++)
                removeSectionNumberComboBox.Items.Add(i);
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //**coming back to this**positionLabel.Text = passingText; 


        }

        private void templateAddSectionButton_Click(object sender, EventArgs e)
        {
            //validation - make sure section has a name + number
            if (addSectionNameTextbox.Text == "" || addSectionNumberComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please make sure you have entered a section number and name"); //show messagebox to prompt user input for section number and name
            }
            //else create textboxes in panel
            else
            {

                //create objects
                //panel objects
                Panel sectionOne = new Panel();
                //label objects
                Label sectionOneNameLabel = new Label();
                //textbox objects
                TextBox textbox1 = new TextBox();
                TextBox textbox2 = new TextBox();
                TextBox textbox3 = new TextBox();
                TextBox textbox4 = new TextBox();
                TextBox textbox5 = new TextBox();
                TextBox textbox6 = new TextBox();

                //set positions
                //position of panel in form
                sectionOne.Location = new Point(10,130);
                //position of label in panel
                sectionOneNameLabel.Location = new Point(10, 25);
                //position of textboxes in panel
                textbox1.Location = new Point(10, 70);
                textbox2.Location = new Point(160, 70);
                textbox3.Location = new Point(10, 115);
                textbox4.Location = new Point(160, 115);
                textbox5.Location = new Point(10, 160);
                textbox6.Location = new Point(160, 160);

                //set size of panel
                sectionOne.Size = new Size(460,180);
                //change height and width of textboxes on right side
                textbox2.Size = new Size(300, 24);
                textbox4.Size = new Size(300, 24);
                textbox6.Size = new Size(300, 24);

                /*
                //set name of each textbox
                textbox1.Name = "textbox_" + (count + 1);
                textbox2.Name = "textbox_" + (count + 1);
                textbox3.Name = "textbox_" + (count + 1);
                textbox4.Name = "textbox_" + (count + 1);
                textbox5.Name = "textbox_" + (count + 1);
                textbox6.Name = "textbox_" + (count + 1);
                */

                //add panel to form
                Controls.Add(sectionOne);

                //add label to panel
                sectionOne.Controls.Add(sectionOneNameLabel);

                //rename section label with text entered into textbox
                sectionOneNameLabel.Text = addSectionNameTextbox.Text;

                //add textboxes to panel
                sectionOne.Controls.Add(textbox1);
                sectionOne.Controls.Add(textbox2);
                sectionOne.Controls.Add(textbox3);
                sectionOne.Controls.Add(textbox4);
                sectionOne.Controls.Add(textbox5);
                sectionOne.Controls.Add(textbox6);
            }
        }

        private void templateSaveButton_Click(object sender, EventArgs e)
        {


            //create object of new form
            // we need to open the feedback form, not a new one -mt
            //passingText is what we can call it for now, this will hopefully pull all the input text to the feedback form
            feedbackform fbF = new feedbackform();
            this.Hide();
            feedback ss = new feedback();
            ss.Show();



            MessageBox.Show("Template saved. Click 'Ok' to proceed to the Feedback form.");
            // passingText = templatePositionTextBox.Text;
               
            

        }

        private class feedbackform
        {
            private string text;

          
        }

        private void addSectionNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}