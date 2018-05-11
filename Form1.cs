using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_System_2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("username : admin \n Password : ciu");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (username.Text == "admin" && password.Text == "ciu")
            {
                Form2 myForm1 = new Form2();
                myForm1.Show();
                this.Visible = false;
                MessageBox.Show("yo");
            }
            else if (username.Text != "admin" && password.Text == "ciu")
            {
                MessageBox.Show("Your username is incorrect \n please enter the correct username");
            }
            else if (username.Text == "admin" && password.Text != "ciu")
            {
                MessageBox.Show("Your Password is incorrect \n please enter the correct Password");
            }
            else if (username.Text != "admin" && password.Text != "ciu")
            {
                MessageBox.Show("Both your username and Password are incorrect \n please enter the correct username and Password");
            }
            
        }
    }
}
