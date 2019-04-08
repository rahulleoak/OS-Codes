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
    public partial class Form2 : Form
    {

        System.Diagnostics.Stopwatch tick = new System.Diagnostics.Stopwatch();
        Form1 parent;
        public Form2(Form1 frm)
        {
            parent = frm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Form1.f1data[0];
            textBox2.Text = Form1.f1data[1];
            textBox3.Text = Form1.f1data[2];

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string sec = tick.Elapsed.Hours.ToString() + " : " + tick.Elapsed.Minutes.ToString() + " : " + tick.Elapsed.Seconds.ToString() + " : " + tick.Elapsed.Milliseconds.ToString();
            
            label1.Text = sec;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tick.Start();
            timer1.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string time = tick.Elapsed.Hours.ToString() + " : " + tick.Elapsed.Minutes.ToString() + " : " + tick.Elapsed.Seconds.ToString() + " : " + tick.Elapsed.Milliseconds.ToString();
            tick.Stop();
            timer1.Enabled = true;
            MessageBox.Show(time, "Timer Count", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string time = tick.Elapsed.Hours.ToString() + " : " + tick.Elapsed.Minutes.ToString() + " : " + tick.Elapsed.Seconds.ToString() + " : " + tick.Elapsed.Milliseconds.ToString();
            listBox1.Items.Add(time);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tick.Reset();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Close();
            
        }


    }
}
