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

namespace vchmat6

{

    public partial class Form1 : Form

    {

        public Form1()

        {

            InitializeComponent();

        }

        double x0 = 0, y0 = 10, xn;

        int n;

        double[] x;

        double[] y;

        //проверка на пустоту

        private bool empty(TextBox box)

        {

            if (box.Text == "")

                return true;

            else

                return false;

        }

        private bool check()

        {

            if (empty(textBox1))

            {

                MessageBox.Show("Введите координату х конечной точки.");

                return false;

            }

            if (empty(textBox2))

            {

                MessageBox.Show("Введите шаг.");

                return false;

            }

            if ((double.Parse(textBox2.Text) < 0) || (double.Parse(textBox2.Text) > double.Parse(textBox1.Text)))

            {

                MessageBox.Show("Шаг введен некорректно.");

                textBox2.Clear();

                return false;

            }

            return true;

        }

        //функция, подготавливающая данные для использования методов, задаются значения переменных

        private void data(double h)

        {

            xn = double.Parse(textBox1.Text); //координата х конечной точки

            n = (int)Math.Ceiling((xn - x0) / h); //количество интервалов, округляется в бОльшую

            x = new double[n + 1]; //сторону, если (x(n)-x(0)) не делится на h

            y = new double[n + 1];

            //заполняем массив х в соответствии с шагом

            for (int i = 0; i < n; i++)

                x[i] = x0 + h * i;

            x[n] = xn;

        }

        //построение графика, настраиваются оси

        private void graph(double[] x, double[] y, int i)

        {
            chart1.ChartAreas[0].AxisX.Minimum = x0;
            chart1.ChartAreas[0].AxisX.Maximum = double.Parse(textBox1.Text);
            chart1.Series[0].ChartType = SeriesChartType.Line;
            chart1.Series[0].Points.DataBindXY(x, y);

        }

        //вычисляет функцию f(x,y)

        double function(double x, double y)

        {

            return (Math.Sin(x) - y);

        }

        //стереть график метод Эйлера

        private void button3_Click(object sender, EventArgs e)

        {

            chart1.Series[0].Points.Clear();

        }

        //стереть график исправленный

        private void button4_Click(object sender, EventArgs e)

        {

            chart1.Series[0].Points.Clear();

        }

        //точное решение

        private void button9_Click(object sender, EventArgs e)

        {

            if (!check())

                return;

            double h = double.Parse(textBox2.Text);

            data(h);

            y[0] = y0;

            for (int i = 1; i < n + 1; i++)

                y[i] = -0.5 * Math.Cos(x[i]) + 0.5 * Math.Sin(x[i]) + (double)(11.5) * Math.Exp(-x[i]);

            graph(x, y, 1);

        }

        //стереть точное решение

        private void button10_Click(object sender, EventArgs e)

        {

            chart1.Series[0].Points.Clear();

        }

        //метод Рунге

        double Rhunge(double h, double x, double y)

        {

            return (y + (h / 6) * ((function(x, y) + function(x + (h / 2), y + h * function(x, y) / 2)) + function(x + h / 2, y + h * function(x + (h / 2), y + h * function(x, y) / 2)) / 2 + function(x + h, y + h * h * function(x + (h / 2), y + h * function(x, y) / 2)) / 2));

        }

        //модифицированная формула

        double Eiler(double h, double x, double y)

        {

            return (y + h * (function(x + 0.5 * h, y + 0.5 * h * function(x, y))));

        }

        //стереть график Адамса

        private void button8_Click(object sender, EventArgs e)

        {

            chart1.Series[0].Points.Clear();

        }

        //метод Адамса 3-ого порядка

        private void button11_Click(object sender, EventArgs e)

        {

            if (!check())

                return;

            double h = double.Parse(textBox2.Text);

            data(h);

            double[] k = new double[4];

            double delta;

            y[0] = y0;

            y[1] = Rhunge(h, x[0], y[0]);

            y[2] = Rhunge(h, x[1], y[1]);

            y[3] = Rhunge(h, x[2], y[2]);

            for (int i = 4; i <= n; i++)

            {

                for (int j = 0; j < 3; j++)

                {

                    k[j + 1] = k[j];

                }

                k[0] = function(x[i - 1], y[i - 1]);

                delta = (double)1 / 24 * h * (55 * k[0] - 59 * k[1] + 37 * k[2] - 9 * k[3]);

                y[i] = y[i - 1] + delta;

            }

            graph(x, y, 3);

        }




        //метод Эйлера модифицированный

        private void button2_Click(object sender, EventArgs e)

        {

            if (!check())

                return;

            double h = double.Parse(textBox2.Text);

            data(h);

            y[0] = y0;

            for (int i = 1; i < n; i++)

                y[i] = Eiler(h, x[i - 1], y[i - 1]);

            y[n] = Eiler(h, x[n - 1], y[n - 1]);

            graph(x, y, 2);

        }

        //метод Эйлера

        private void button1_Click(object sender, EventArgs e)

        {

            if (!check())

                return;

            double h = double.Parse(textBox2.Text);

            data(h);

            double h1 = x[n] - x[n - 1];

            y[0] = y0;

            for (int i = 1; i < n; i++)

                y[i] = y[i - 1] + h * function(x[i - 1], y[i - 1]);

            y[n] = y[n - 1] + h1 * function(x[n - 1], y[n - 1]);

            graph(x, y, 0);

        }

    }

}
