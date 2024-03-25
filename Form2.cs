using System;
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
    public partial class Form2 : Form
    {
        private string mainTemp = string.Empty;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainTemp = "Fahrenheit";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainTemp = "Celsius";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainTemp = "Kelvin";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (mainTemp == "Fahrenheit") 
            {
                double suma = double.Parse(textBox1.Text);
                
                label5.Text = suma.ToString() + "°F";
            }
            if (mainTemp == "Celcius") 
            {
                double suma = double.Parse(textBox1.Text);
                suma = (suma * 1.8) + 32;
                label5.Text = suma.ToString() + "°F";
            }
            if (mainTemp == "Kelvin") 
            {
                double suma = double.Parse(textBox1.Text);
                suma = 1.8 * (suma - 273) + 32;
                label5.Text = suma.ToString() + "°F";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (mainTemp == "Fahrenheit")
            {
                double suma = double.Parse(textBox1.Text);
                suma = (suma - 32) / 1.79999999;
                label5.Text = suma.ToString() + "°C";
            }
            if (mainTemp == "Celcius")
            {
                double suma = double.Parse(textBox1.Text);
                
                label5.Text = suma.ToString() + "°C";
            }
            if (mainTemp == "Kelvin")
            {
                double suma = double.Parse(textBox1.Text);
                suma = suma - 273.15;
                label5.Text = suma.ToString() + "°C";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (mainTemp == "Fahrenheit")
            {
                double suma = double.Parse(textBox1.Text);
                suma = (suma + 459.67)* (5/9);
                label5.Text = suma.ToString() + "°K";
            }
            if (mainTemp == "Celcius")
            {
                double suma = double.Parse(textBox1.Text);
                suma = suma + 273.15;
                label5.Text = suma.ToString() + "°K";
            }
            if (mainTemp == "Kelvin")
            {
                double suma = double.Parse(textBox1.Text);
                label5.Text = suma.ToString() + "°K";
            }
        }
    }
}
