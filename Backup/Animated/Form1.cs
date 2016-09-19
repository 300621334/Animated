using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Text = "To experience";
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "Chalk it up";
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "Support our schools";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Support our schools";
        }
    }
}