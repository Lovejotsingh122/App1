using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button is Clicked");
            //property of message box is to display it as a dialog box.
        }

        private void buttonshow_Click(object sender, EventArgs e)
        {
            label1.Text=(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void but1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTTON 1ST is selected");
        }

        private void buttobut2n2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTTON 2nd is selected");
        }

        private void but3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTTON 3rd is selected");
        }

        private void but4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTTON 4th is selected");
        }

        private void but5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTTON 5th is selected");
        }

        private void but6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BUTTON 6th is selected");
        }
    }
}
