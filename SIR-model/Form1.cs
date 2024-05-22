using System;
using System.Windows.Forms;

namespace SIR_модель
{
    public partial class Form1 : Form
    {
        //объявление констант
        private int TotalNumberOfPeople, NumberOfInfected;
        private double beta, gamma, step, size;
 
        public Form1() { InitializeComponent(); }
        private void Form1_Load(object sender, EventArgs e) {}
        private void groupBox1_Enter(object sender, EventArgs e) {}

        private void ConstantParams()
        {
            TotalNumberOfPeople = 1000000;   //общее число населения
            NumberOfInfected = 1000;         //начальное число инфекционных
            beta = 0.2;                      //коэффициент инфекционности
            gamma = 0.01;                    //коэффициент выздоровления
            step = 1.0;                      //временной шаг (дни)
            size = 1.0;                      //масштаб
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //задание констант для изменения
            if (textBox_tnop.Text == "" || textBox_noi.Text == "" || textBox_beta.Text == "" ||
                textBox_gamma.Text == "" || textBox_step.Text == "" || textBox_size.Text == "")
            {
                MessageBox.Show("Параметры по умолчанию!", "");
                ConstantParams();
            }
            else
            {
                TotalNumberOfPeople = Convert.ToInt32(textBox_tnop.Text);
                NumberOfInfected = Convert.ToInt32(textBox_noi.Text);
                beta = Convert.ToDouble(textBox_beta.Text);
                gamma = Convert.ToDouble(textBox_gamma.Text);
                step = Convert.ToDouble(textBox_step.Text);
                size = Convert.ToDouble(textBox_size.Text);
            } 

            //установка начальных значений 
            double Susceptible = TotalNumberOfPeople - NumberOfInfected;
            double Infected = NumberOfInfected;
            double Resistant = 0;

            //установка начальных значений на окне рисования графиков 
            chartSIR.Series[0].Points.AddXY(0, Susceptible);
            chartSIR.Series[1].Points.AddXY(0, Infected);
            chartSIR.Series[2].Points.AddXY(0, Resistant);

            //границы рисования графиков
            chartSIR.ChartAreas[0].AxisX.Minimum = 0;
            chartSIR.ChartAreas[0].AxisX.Maximum = 365;
            chartSIR.ChartAreas[0].AxisY.Minimum = 0;
            chartSIR.ChartAreas[0].AxisY.Maximum = TotalNumberOfPeople;

            //цикл изменения графиков по времени
            for (double t = step; t <= 365; t += step)
            {
                //вычисление значений системы дифференциальных уравнений модели
                double dSdt = -beta * Susceptible * Infected / TotalNumberOfPeople * step;
                double dIdt = beta * Susceptible * Infected / TotalNumberOfPeople * step - gamma * Infected;
                double dRdt = gamma * Infected;
                //вычисление новых значений для построения графиков
                Susceptible += dSdt;
                Infected += dIdt;
                Resistant += dRdt;

                //отрисовка точек на окно рисования графиков
                chartSIR.Series[0].Points.AddXY(t, Susceptible / size);
                chartSIR.Series[1].Points.AddXY(t, Infected / size);
                chartSIR.Series[2].Points.AddXY(t, Resistant / size);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //очистка графиков
            chartSIR.Series[0].Points.Clear();
            chartSIR.Series[1].Points.Clear();
            chartSIR.Series[2].Points.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //выход из программы
            if(MessageBox.Show("Вы точно хотите выйти?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}