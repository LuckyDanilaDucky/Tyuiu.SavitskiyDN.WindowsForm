using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.SavitskiyDN.WindowsForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double[] GetMassFunction(int startValue, int stopValue)

        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];
            double y;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                
                {
                    y = x + Math.Pow(Math.E, x) + ((Math.Sin(Math.Pow(x, 5)) + Math.Pow(x, 3)) / (Math.Pow(3, x))) + ((Math.Pow(x, 5)) / Math.Pow(5, x));

                    valueArray[count] = y;
                    count++;
                }

            }
            return valueArray;

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDev_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выполнил студент группы НТм-22-1\t\nСавицкий Данила Николаевич\t", "Разработчик-тестировщик", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(numericStart.Text);
                int finish = Convert.ToInt32(numericFinish.Text);


                double[] valueArray = GetMassFunction(start, finish);

                textBoxRes.Clear();


                for (int i = 0; i < valueArray.Length; i++)
                {
                    textBoxRes.AppendText($"{valueArray[i]}\r\n");
                }

                chartRes.Series.Clear();

                Series series = new Series("Graph");
                series.ChartType = SeriesChartType.Line;

                for (int i = 0; i < valueArray.Length; i++)
                {
                    series.Points.AddXY(i + start, valueArray[i]);
                }

                chartRes.Series.Add(series);

            }
            catch
            {
                MessageBox.Show("Что-то пошло не так...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericStart_ValueChanged(object sender, EventArgs e)
        {

        }
    }
    }

