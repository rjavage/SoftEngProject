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
    public partial class HAPPYTECH_LOGIN : Form
    {
        public HAPPYTECH_LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\github\HappyTech\HappyTech\HappyTechDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From Login where Username ='" + textBox1.Text + "' and Password ='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1") // am using datatable dt row, the valve if is =1 then hide the form 
            {

                this.Hide(); // this hide the login windows form 

                template ss = new template(); // this form open when the login window is hide 
                ss.Show();

            }
            else    // otherwise it ask you to check the username and password 
            {
                MessageBox.Show("please check your Username and Password");
            }
        }

       // private void button2_Click(object sender, EventArgs e)
        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void positionPassed_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
