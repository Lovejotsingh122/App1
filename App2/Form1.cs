using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Hi_Click(object sender, EventArgs e)
        {
            label1.Text = "Hi Button Pressed";
        }

        private void bye_Click(object sender, EventArgs e)
        {
            label1.Text = "Bye button Pressed";
        }

        private void farleft_Click(object sender, EventArgs e)
        {
            label1.Text = "Far left Button Pressed";
        }

        private void farright_Click(object sender, EventArgs e)
        {
            label1.Text = "Far Right button Pressed";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, label2.Font.Style ^ FontStyle.Bold);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            label2.Font = new Font(label2.Font, label2.Font.Style ^ FontStyle.Italic);
        }
    }
}
