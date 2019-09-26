using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowCalculator
{
    public partial class Form1 : Form
    {
        ArrayList Numbers = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Number add = new Number();
            add.number1 = textBox1.Text;
            add.number2 = textBox2.Text;

            double a, b, c = 0;
            string d = "";

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = a + b;
            d = Convert.ToString(c);
            add.result = d;
            add.calcResult = textBox1.Text + " + " + textBox2.Text + " = " + d;

            Numbers.Add(add.calcResult);
            listBox1.Items.Add(add.calcResult);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Number sub = new Number();
            sub.number1 = textBox1.Text;
            sub.number2 = textBox2.Text;

            double a, b, c = 0;
            string d = "";

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = a - b;
            d = Convert.ToString(c);
            sub.result = d;
            sub.calcResult = textBox1.Text + " - " + textBox2.Text + " = " + d;

            Numbers.Add(sub.calcResult);
            listBox1.Items.Add(sub.calcResult);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Number mult = new Number();
            mult.number1 = textBox1.Text;
            mult.number2 = textBox2.Text;

            double a, b, c = 0;
            string d = "";

            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);
            c = a * b;
            d = Convert.ToString(c);
            mult.result = d;
            mult.calcResult = textBox1.Text + " * " + textBox2.Text + " = " + d;

            Numbers.Add(mult.calcResult);
            listBox1.Items.Add(mult.calcResult);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Number div = new Number();
            div.number1 = textBox1.Text;
            div.number2 = textBox2.Text;

            double a, b, c = 0;
            string d = "";

            a = Convert.ToInt32(textBox1.Text);
            b = Convert.ToInt32(textBox2.Text);
            c = a / b;
            d = Convert.ToString(c);
            div.result = d;
            div.calcResult = textBox1.Text + " / " + textBox2.Text + " = " + d;

            Numbers.Add(div.calcResult);
            listBox1.Items.Add(div.calcResult);
        }
    }
    class Number {
        public string number1 { get; set; }
        public string number2 { get; set; }
        public string result { get; set; }
        public string calcResult { get; set; }
    }
}
