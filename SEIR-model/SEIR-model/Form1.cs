using System;
using System.Windows.Forms;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Windows.Forms.DataVisualization.Charting;

namespace SEIR_model
{
    public partial class Form1 : Form
    {
        // Параметры модели
        private double beta;
        private double sigma;
        private double gamma;
        private double N;

        // Массивы для хранения значений
        private double[] S;
        private double[] E;
        private double[] I;
        private double[] R;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Получение значений параметров от пользователя
            beta = double.Parse(textBox1.Text);
            sigma = double.Parse(textBox2.Text);
            gamma = double.Parse(textBox3.Text);
            N = double.Parse(textBox4.Text);

            // Инициализация массивов
            S = new double[100];
            E = new double[100];
            I = new double[100];
            R = new double[100];

            // Начальные условия
            S[0] = N - 1;
            E[0] = 1;
            I[0] = 0;
            R[0] = 0;

            // Вычисление модели
            for (int t = 1; t < 100; t++)
            {
                S[t] = S[t - 1] - (beta * S[t - 1] * I[t - 1] / N);
                E[t] = E[t - 1] + (beta * S[t - 1] * I[t - 1] / N) - (sigma * E[t - 1]);
                I[t] = I[t - 1] + (sigma * E[t - 1]) - (gamma * I[t - 1]);
                R[t] = R[t - 1] + (gamma * I[t - 1]);

                chart1.Series[0].Points.AddXY(t, S[t]);
                chart1.Series[1].Points.AddXY(t, E[t]);
                chart1.Series[2].Points.AddXY(t, I[t]);
                chart1.Series[3].Points.AddXY(t, R[t]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                //очистка графиков
                chart1.Series[0].Points.Clear();
                chart1.Series[1].Points.Clear();
                chart1.Series[2].Points.Clear();
                chart1.Series[3].Points.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //выход из программы
            if (MessageBox.Show("Вы точно хотите выйти?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
