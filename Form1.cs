using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace formsss
{
    public partial class Form1 : Form
    {
        public static string[] f1data = new string[5];
        public static string val = "";
        public static string gender = "";


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your Text: " + textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = DateTime.Now.ToString();
             
            MessageBox.Show(textBox1.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        public void button4_Click(object sender, EventArgs e)
        {
            
            bool ischecked1 = checkBox1.Checked;
            bool ischecked2 = checkBox2.Checked;
            bool ischecked3 = checkBox3.Checked;

            if (checkBox1.Checked) { val += checkBox1.Text + ' '; }
            if (ischecked2) { val += checkBox2.Text + ' '; }
            if (ischecked3) { val += checkBox3.Text + ' '; }
            
            textBox2.Text = val;

        }

        private void button5_Click(object sender, EventArgs e)
        {
           
           
            if(radioButton1.Checked){gender = radioButton1.Text;}
            if(radioButton2.Checked){gender = radioButton2.Text;}
            if (radioButton3.Checked) { gender = radioButton3.Text;}

            MessageBox.Show(gender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            f1data[0]= textBox1.Text;
            f1data[1] = textBox2.Text;
            f1data[2] = gender;
            
            Form2 f2 = new Form2(this);
            this.Hide();
            f2.Show();

        }






    }
}
