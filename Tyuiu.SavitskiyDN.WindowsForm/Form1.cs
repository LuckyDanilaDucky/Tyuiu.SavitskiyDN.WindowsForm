using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.SavitskiyDN.WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                int x = Convert.ToInt32(textBox1.Text);
                int y = Convert.ToInt32(textBox2.Text);

                if (radioButton1.Checked)
                {
                    double result = (2 * (1 / Math.Tan(3 * x)) - (Math.Log(Math.Cos(x), Math.E) / Math.Log(1 + Math.Pow(x, 2), Math.E)));
                    textBox3.Text = Convert.ToString(Math.Round(result, 3));
                }
                else if (radioButton2.Checked)
                {
                    double result = ((2 + Math.Pow((Math.Cos(x + y)), 2)) / 1 + Math.Abs((x - (3 * x)) / (1 + Math.Pow(x, 2) * Math.Pow(y, 2))) + x * y);
                    textBox3.Text = Convert.ToString(Math.Round(result, 3));
                }
                else
                {
                    MessageBox.Show("Для проведения расчётов\nнеобходимо выбрать\nхотя бы одной уравнение!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Во время проведения расчётов произошла ошибка!\nПроверьте введённые данные!\nВыполните проверку деления на ноль!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы НТм-22-1\t\nСавицкий Данила Николаевич\t", "Разработчик-тестировщик", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}