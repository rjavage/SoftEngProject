using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

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
        //click to send email
        private void button2_Click(object sender, EventArgs e)
        {
            //want to send the email from the text box, then close the form
            try
            {

                SmtpClient client = new SmtpClient(emailTextbox.Text);
                MailMessage message = new MailMessage();
                message.From = new MailAddress(enterEmail.Text);
                message.To.Add(enterEmail.Text);
                message.Body = bodyTxt.Text;
                message.Subject = subjectTxt.Text;
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587; 
                smtp.Host = "smtp.mail.yahoo.com";
                client.Credentials = new System.Net.NetworkCredential("happy_tech@yahoo.com", "1a2b3c4d");
                client.EnableSsl = true;
                client.Send(message);
                    

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //want to save to database and close form
            this.Close(); //closing the form
        }
    }
}
