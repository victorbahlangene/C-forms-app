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
    public partial class Form2 : Form
    {
        int result;
        int ques1;
        int ques2;
        int ques3;
        int ques4;
        int ques5;
        int ques6;
        int ques7;
        int ques8;
        int ques9;
        int ques10;

        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (A1.Checked == true)
            {
                ques1 = 1;
                //String resultString = ques1.ToString();
                //MessageBox.Show(resultString);
            }
            else
            {
                ques1 = 0;
            }

            if (C2.Checked == true)
            {
                ques2 = 1;
                //String resultString = ques2.ToString();
                //MessageBox.Show(resultString);
            }
            else
            {
                ques2 = 0;
            }

            if (C3.Checked == true)
            {
                ques3 = 1;
                //String resultString = ques3.ToString();
                //MessageBox.Show(resultString);
            }
            else
            {
                ques3 = 0;
            }

            if (A4.Checked == true)
            {
                ques4 = 1;
                //String resultString = ques4.ToString();
                //MessageBox.Show(resultString);
            }
            else
            {
                ques4 = 0;
            }

            if (D5.Checked == true)
            {
                ques5 = 1;
                //String resultString = ques5.ToString();
                //MessageBox.Show(resultString);
            }
            else
            {
                ques5 = 0;
            }

            if (true1.Checked == true)
            {
                ques6 = 1;
            }
            else
            {
                ques6 = 0;
            }

            if (false2.Checked == true)
            {
                ques7 = 1;
            }
            else
            {
                ques7 = 0;
            }

            if (false3.Checked == true)
            {
                ques8 = 1;
            }
            else
            {
                ques8 = 0;
            }

            if (true4.Checked == true)
            {
                ques9 = 1;
            }
            else
            {
                ques9 = 0;
            }

            if (false5.Checked == true)
            {
                ques10 = 1;
            }
            else
            {
                ques10 = 0;
            }

            result = (ques1 + ques2 + ques3 + ques4 + ques5 + ques6 + ques7 + ques8 + ques9 + ques10) * 10;
            String resultString = result.ToString();
            MessageBox.Show("Your total is " + resultString + "%");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
