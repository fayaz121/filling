using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = textBox1.Text + "\\" + textBox2.Text;
            string d = textBox3.Text + "\\" + textBox2.Text;
            MessageBox.Show("copied");
            File.Copy(s, d);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Source";
            this.label2.Text = "file";
            this.label3.Text = "Destination";
            this.button1.Text = "Copy";
            this.button2.Text = "Clear";
            this.button3.Text = "Exit";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
