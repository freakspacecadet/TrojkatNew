using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trójkąt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double a;
        double b;
        double c;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "alfa";
            comboBox2.SelectedItem = "sin";
            a = 1;
            b = 1;
            c = Math.Sqrt(a * a + b * b);
            textBox1.Text = Convert.ToString(String.Format("{0:0.000}", c));
            textBox2.Text = Convert.ToString(String.Format("{0:0.000}", a / c));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string funkcja = (string)comboBox2.SelectedItem;
            string kat = (string)comboBox1.SelectedItem;
            if (funkcja == "sin") {
                if (kat == "alfa") { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", a / c)); }
                else { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", b / c)); }
            }
            else if (funkcja == "cos")
            {
                if (kat == "alfa") { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", b / c)); }
                else { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", a / c)); }
            }
            else if (funkcja == "tg")
            {
                if (kat == "alfa") { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", a / b)); }
                else { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", b / a)); }
            }
            else if (funkcja == "ctg")
            {
                if (kat == "alfa") { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", b / a)); }
                else { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", a / b)); }
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            a = Convert.ToDouble(numericUpDown1.Value);
            c = Math.Sqrt(a * a + b * b);
            textBox1.Text = Convert.ToString(String.Format("{0:0.000}", c));
            comboBox2_SelectedIndexChanged_1(comboBox2, e);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            b = Convert.ToDouble(numericUpDown2.Value);
            c = Math.Sqrt(a * a + b * b);
            textBox1.Text = Convert.ToString(String.Format("{0:0.000}", c));
            comboBox2_SelectedIndexChanged_1(comboBox2, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string funkcja = (string)comboBox2.SelectedItem;
            string kat = (string)comboBox1.SelectedItem;
            if (funkcja == "sin")
            {
                if (kat == "alfa") { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", a / c)); }
                else { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", b / c)); }
            }
            else if (funkcja == "cos")
            {
                if (kat == "alfa") { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", b / c)); }
                else { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", a / c)); }
            }
            else if (funkcja == "tg")
            {
                if (kat == "alfa") { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", a / b)); }
                else { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", b / a)); }
            }
            else if (funkcja == "ctg")
            {
                if (kat == "alfa") { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", b / a)); }
                else { textBox2.Text = Convert.ToString(String.Format("{0:0.000}", a / b)); }
            }
        }

        private void numericUpDown1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox2_SelectedIndexChanged_1(comboBox2, e);
        }

        private void numericUpDown2_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox2_SelectedIndexChanged_1(comboBox2, e);
        }
    }
}
