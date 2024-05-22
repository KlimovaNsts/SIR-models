using System;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;

namespace SIRV_model
{
    public partial class Form1 : Form
    {
        // Параметры модели
        private double beta;
        private double gamma;
        private double rho;
        private double sigma;
        private double N;
        

        // Массивы для хранения значений
        private double[] S;
        private double[] I;
        private double[] R;
        private double[] V;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //Получение значений параметров от пользователя
            beta = double.Parse(textBox1.Text);
            gamma = double.Parse(textBox2.Text);
            rho = double.Parse(textBox3.Text);
            sigma = double.Parse(textBox4.Text);
            N = double.Parse(textBox5.Text);

            // Инициализация массивов
            S = new double[100000];
            I = new double[100000];
            R = new double[100000];
            V = new double[100000];

            // Начальные условия
            S[0] = N - 1;
            I[0] = 1;
            R[0] = 0;
            V[0] = 0;

            // Вычисление модели
            for (int t = 1; t < 100; t++)
            {
                S[t] = S[t - 1] - (beta * S[t - 1] * I[t - 1] / N) + (sigma * V[t - 1]);
                I[t] = I[t - 1] + (beta * S[t - 1] * I[t - 1] / N) - (gamma * I[t - 1]) - (rho * I[t - 1]);
                R[t] = R[t - 1] + (gamma * I[t - 1]);
                V[t] = V[t - 1] + (rho * I[t - 1]) - (sigma * V[t - 1]);

                // Вывод результатов
                chartSIRV.Series[0].Points.AddXY(t, S[t]);
                chartSIRV.Series[1].Points.AddXY(t, I[t]);
                chartSIRV.Series[2].Points.AddXY(t, R[t]);
                chartSIRV.Series[3].Points.AddXY(t, V[t]);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //очистка графиков
            chartSIRV.Series[0].Points.Clear();
            chartSIRV.Series[1].Points.Clear();
            chartSIRV.Series[2].Points.Clear();
            chartSIRV.Series[3].Points.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //выход из программы
            if (MessageBox.Show("Вы точно хотите выйти?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}