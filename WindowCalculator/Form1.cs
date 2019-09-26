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
            textBox1.Clear();
            textBox2.Clear();

            double a, b, c = 0;
            string d = "";

            a = Convert.ToDouble(add.number1);
            b = Convert.ToDouble(add.number2);
            c = a + b;
            d = Convert.ToString(c);
            add.result = d;
            add.calcResult = add.number1 + " + " + add.number2 + " = " + d;

            Numbers.Add(add);
            listBox1.Items.Add(add.calcResult);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Number sub = new Number();
            sub.number1 = textBox1.Text;
            sub.number2 = textBox2.Text;
            textBox1.Clear();
            textBox2.Clear();

            double a, b, c = 0;
            string d = "";

            a = Convert.ToDouble(sub.number1);
            b = Convert.ToDouble(sub.number2);
            c = a - b;
            d = Convert.ToString(c);
            sub.result = d;
            sub.calcResult = sub.number1 + " - " + sub.number2 + " = " + d;

            Numbers.Add(sub);
            listBox1.Items.Add(sub.calcResult);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Number mult = new Number();
            mult.number1 = textBox1.Text;
            mult.number2 = textBox2.Text;
            textBox1.Clear();
            textBox2.Clear();

            double a, b, c = 0;
            string d = "";

            a = Convert.ToDouble(mult.number1);
            b = Convert.ToDouble(mult.number2);
            c = a * b;
            d = Convert.ToString(c);
            mult.result = d;
            mult.calcResult = mult.number1 + " * " + mult.number2 + " = " + d;

            Numbers.Add(mult);
            listBox1.Items.Add(mult.calcResult);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Number div = new Number();
            div.number1 = textBox1.Text;
            div.number2 = textBox2.Text;
            textBox1.Clear();
            textBox2.Clear();

            double a, b, c = 0;
            string d = "";

            a = Convert.ToDouble(div.number1);
            b = Convert.ToDouble(div.number2);
            c = a / b;
            d = Convert.ToString(c);
            div.result = d;
            div.calcResult = div.number1 + " / " + div.number2 + " = " + d;

            Numbers.Add(div);
            listBox1.Items.Add(div.calcResult);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (Number q in Numbers)
            {
                listBox1.Items.Add(q.calcResult);
            }
        }
    }
}
