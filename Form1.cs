﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {
            double suma = double.Parse(textBox1.Text);
            label3.Text = (suma * 0.51).ToString() + "€";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double suma = double.Parse(textBox1.Text);
            label3.Text = (suma * 0.55).ToString() + "$";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double suma = double.Parse(textBox1.Text);
            label3.Text = (suma * 0.44).ToString() + "£";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Hide();
        }
    }
}
