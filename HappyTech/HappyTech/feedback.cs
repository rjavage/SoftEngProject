﻿using System;
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
    public partial class feedback : Form
    {
        public string textBoxPosition { get; internal set; }

        private string position;

        public feedback(string position)
        {
            InitializeComponent();
            this.position = position;
            positionLabel.Text = position;
           // MessageBox.Show("Curent position is: "+ this.position);
        }

        private void feedback_Load(object sender, EventArgs e)
        {


        }

        private void templateInput_Paint(object sender, PaintEventArgs e)
        {

        }

        private void positionLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailPreview_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //want to save to database and close form
            this.Close();
        }
    }
}
